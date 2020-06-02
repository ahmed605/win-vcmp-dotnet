#include "coreclr_funcs.hxx"

#ifdef _WIN32
#include <Windows.h>

typedef HMODULE dynamic_library_t;

#define CORECLR_PATH_FROM_RUNTIME_DIRECTORY ("/coreclr.dll")

#define LOAD_CORECLR_LIBRARY(PATH) LoadLibrary((PATH))
#define RESOLVE_SYMBOL(LIBRARY, SYMBOL) GetProcAddress((LIBRARY), (SYMBOL))
#else
#include <dlfcn.h>

typedef void* dynamic_library_t;

#define CORECLR_PATH_FROM_RUNTIME_DIRECTORY ("/libcoreclr.so")

#define LOAD_CORECLR_LIBRARY(PATH) dlopen((PATH), (RTLD_NOW | RTLD_LOCAL))
#define RESOLVE_SYMBOL(LIBRARY, SYMBOL) dlsym((LIBRARY), (SYMBOL))
#endif

namespace dotnet_vcmp {
    bool coreclr_funcs::load_from_dynamic_library(const std::string p_libraryPath) {
        dynamic_library_t coreclrLib = LOAD_CORECLR_LIBRARY((p_libraryPath + CORECLR_PATH_FROM_RUNTIME_DIRECTORY).c_str());

        if (coreclrLib == nullptr) {
            return false;
        } else {
            m_initialize      = reinterpret_cast<coreclr_initialize_ptr>(RESOLVE_SYMBOL(coreclrLib, "coreclr_initialize"));
            m_createDelegate  = reinterpret_cast<coreclr_create_delegate_ptr>(RESOLVE_SYMBOL(coreclrLib, "coreclr_create_delegate"));
            m_executeAssembly = reinterpret_cast<coreclr_execute_assembly_ptr>(RESOLVE_SYMBOL(coreclrLib, "coreclr_execute_assembly"));
            m_shutdown        = reinterpret_cast<coreclr_shutdown_ptr>(RESOLVE_SYMBOL(coreclrLib, "coreclr_shutdown"));

            return true;
        }
    }
}; // namespace dotnet_vcmp
