#pragma once

#include <string>
#include <vector>
#include <utility>
#include <plugin.h>
#include <json.hpp>

#include "coreclr_funcs.hxx"

namespace dotnet_vcmp {
    class plugin_host {
    public:
        plugin_host(const PluginFuncs &p_pluginFuncs,
                    PluginCallbacks   &p_pluginCallbacks,
                    PluginInfo        &p_pluginInfo);
        virtual ~plugin_host() {}

        void setup_plugin_info();

        void load_config();

        void init_runtime();
        void shutdown_runtime();

        void bootstrap();

    private:
        nlohmann::json m_config;

        const PluginFuncs &m_pluginFuncs;
        PluginCallbacks   &m_pluginCallbacks;
        PluginInfo        &m_pluginInfo;

        coreclr_funcs  m_coreclrFuncs;
        void          *m_coreclrHostHandle;
        unsigned int   m_coreclrDomainId;

        std::string                                                   m_trustedPlatformAssemblies;
        std::string                                                   m_assembliesDirectory;
        std::string                                                   m_nativeAssembliesDirectory;
        std::string                                                   m_nativeDllSearchDirectories;
        std::string                                                   m_serverExecutable;
        std::pair<std::vector<const char*>, std::vector<const char*>> m_appdomainProperties;

        void load_library_functions();
        void probe_trusted_platform_assemblies();
        void load_assemblies_directories();
        void load_native_dll_search_directories();
        void load_server_executable();
        void load_appdomain_properties();
        void start_runtime();
    }; // class plugin_host
}; // namespace dotnet_vcmp
