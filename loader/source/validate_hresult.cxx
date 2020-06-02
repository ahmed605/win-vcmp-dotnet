#include "validate_hresult.hxx"

#include <sstream>

#include "dotnet_vcmp_exception.hxx"

namespace dotnet_vcmp {
    std::string get_error_hex(int errorCode);

    void validate_hresult(std::string description, int errorCode) {
        if (errorCode == 0) {
            // success.
            return;
        } else {
            throw dotnet_vcmp_exception("Failed to " + description + " (HRESULT " + get_error_hex(errorCode) + ", code " + get_error_hex(errorCode & 0xFFFF) + ")");
        }
    }

    std::string get_error_hex(int errorCode) {
        std::stringstream errorHex;
        errorHex << "0x" << std::hex << errorCode;
        return errorHex.str();
    }
}; // namespace dotnet_vcmp
