#include "dotnet_vcmp_exception.hxx"

namespace dotnet_vcmp {
    dotnet_vcmp_exception::dotnet_vcmp_exception(std::string p_description)
    :   m_description(p_description) {};

    const char* dotnet_vcmp_exception::what() const noexcept {
        return m_description.c_str();
    }
}; // namespace dotnet_vcmp
