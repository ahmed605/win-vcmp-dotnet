#include "plugin_host.hxx"

#include <iostream>
#include <string>
#include <set>
#include <iostream>
#include <fstream>
#include <filesystem>

#include "info.hxx"
#include "dotnet_vcmp_exception.hxx"
#include "validate_hresult.hxx"
using namespace std::filesystem;

#ifdef _WIN32
#define PATH_DELIMETER (";")
#else
#define PATH_DELIMETER (":")
#endif

namespace dotnet_vcmp {
    typedef unsigned char (*bootstrap_function_t)(const PluginFuncs &p_pluginFuncs, PluginCallbacks &p_pluginCallbacks);

    plugin_host::plugin_host(const PluginFuncs &p_pluginFuncs, PluginCallbacks &p_pluginCallbacks, PluginInfo &p_pluginInfo)
    :   m_pluginFuncs(p_pluginFuncs), m_pluginCallbacks(p_pluginCallbacks), m_pluginInfo(p_pluginInfo) {}

    void plugin_host::setup_plugin_info() {
        m_pluginInfo.apiMajorVersion = PLUGIN_API_MAJOR;
        m_pluginInfo.apiMinorVersion = PLUGIN_API_MINOR;

        m_pluginInfo.pluginVersion = PLUGIN_VERSION;
        snprintf(m_pluginInfo.name, sizeof m_pluginInfo.name, "%s", PLUGIN_NAME);
    }

    void plugin_host::load_config() {
        std::ifstream configFileStream(CONFIG_PATH);
        std::stringstream buffer;
        buffer << configFileStream.rdbuf();

        m_config = nlohmann::json::parse(buffer.str());
    }

    void plugin_host::init_runtime() {
        load_library_functions();
        probe_trusted_platform_assemblies();
        load_assemblies_directories();
        load_native_dll_search_directories();
        load_server_executable();
        load_appdomain_properties();
        start_runtime();
    }

    void plugin_host::shutdown_runtime() {
        m_coreclrFuncs.m_shutdown(m_coreclrHostHandle, m_coreclrDomainId);
    }

    void plugin_host::bootstrap() {
        bootstrap_function_t bootstrapDelegate;

        int errorCode = m_coreclrFuncs.m_createDelegate(
            m_coreclrHostHandle,
            m_coreclrDomainId,
            ENTRY_POINT_ASSEMBLY_NAME,
            ENTRY_POINT_TYPE_NAME,
            ENTRY_POINT_METHOD_NAME,
            reinterpret_cast<void**>(&bootstrapDelegate)
        );

        validate_hresult("create bootstrap delegate", errorCode);
        if (bootstrapDelegate == nullptr) {
            throw dotnet_vcmp_exception(std::string("coreclr_create_delegate resulted in nullptr"));
        }

        bootstrapDelegate(m_pluginFuncs, m_pluginCallbacks);
    }

    void plugin_host::load_library_functions() {
        std::string libraryPath = m_config["clr"]["runtime-directory"].get<std::string>();

        if (!m_coreclrFuncs.load_from_dynamic_library(libraryPath)) {
            throw dotnet_vcmp_exception(std::string("Failed to open runtime library from ") + libraryPath);
        }
    }

    void plugin_host::probe_trusted_platform_assemblies() {
        std::set<std::string> assemblyExtensions = {
            ".dll",
            ".exe",
            ".winmd"
        };

        for (auto &file: std::filesystem::directory_iterator(m_config["clr"]["runtime-directory"].get<std::string>())) {
            if (assemblyExtensions.find(file.path().extension().string()) != assemblyExtensions.end()) {
                if (m_trustedPlatformAssemblies != "") {
                    m_trustedPlatformAssemblies += PATH_DELIMETER;
                }

                m_trustedPlatformAssemblies += std::filesystem::canonical(file.path()).string();
            }
        }
    }

    void plugin_host::load_assemblies_directories() {
        m_assembliesDirectory  = std::filesystem::canonical(m_config["clr"]["assemblies-directory"].get<std::string>()).string();
        m_nativeAssembliesDirectory = std::filesystem::canonical(m_config["clr"]["native-image-assemblies-directory"].get<std::string>()).string();
    }

    void plugin_host::load_native_dll_search_directories() {
        for (auto searchDirectory: m_config["clr"]["native-dll-search-directories"].get<std::vector<std::string>>()) {
            if (m_nativeDllSearchDirectories != "") {
                m_nativeDllSearchDirectories += PATH_DELIMETER;
            }

            m_nativeDllSearchDirectories += searchDirectory;
        }
    }

    void plugin_host::load_server_executable() {
		m_serverExecutable = std::filesystem::canonical(m_config["clr"]["server-executable"].get<std::string>()).string();
    }

    void plugin_host::load_appdomain_properties() {
        m_appdomainProperties = {
            {
                "TRUSTED_PLATFORM_ASSEMBLIES",
                "APP_PATHS",
                "APP_NI_PATHS",
                "NATIVE_DLL_SEARCH_DIRECTORIES"
            },
            {
                m_trustedPlatformAssemblies.c_str(),
                m_assembliesDirectory.c_str(),
                m_nativeAssembliesDirectory.c_str(),
                m_nativeDllSearchDirectories.c_str()
            }
        };
    }

    void plugin_host::start_runtime() {
        int errorCode = m_coreclrFuncs.m_initialize(
            m_serverExecutable.c_str(),
            m_config["app-domain"]["friendly-name"].get<std::string>().c_str(),
            m_appdomainProperties.first.size(),
            m_appdomainProperties.first.data(),
            m_appdomainProperties.second.data(),
            &m_coreclrHostHandle,
            &m_coreclrDomainId
        );

        validate_hresult("initialize CLR", errorCode);
    }
}; // namespace dotnet_vcmp
