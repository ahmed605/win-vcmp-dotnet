#pragma once

#include <exception>
#include <string>

namespace dotnet_vcmp {
    class dotnet_vcmp_exception: public std::exception {
    public:
        dotnet_vcmp_exception(std::string p_description);
        virtual ~dotnet_vcmp_exception() {};

        virtual const char* what() const noexcept;

    protected:
        std::string m_description;
    }; // class dotnet_vcmp_exception
}; // namespace dotnet_vcmp
