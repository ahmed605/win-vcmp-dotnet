#pragma once

#include <string>
#include <coreclrhost.h>

namespace dotnet_vcmp {
    class coreclr_funcs {
    public:
        coreclr_funcs() {};
        virtual ~coreclr_funcs() {}

        bool load_from_dynamic_library(std::string p_libraryPath);

        coreclr_initialize_ptr       m_initialize;
        coreclr_create_delegate_ptr  m_createDelegate;
        coreclr_execute_assembly_ptr m_executeAssembly;
        coreclr_shutdown_ptr         m_shutdown;
    }; // class coreclr_funcs
}; // namespace dotnet_vcmp
