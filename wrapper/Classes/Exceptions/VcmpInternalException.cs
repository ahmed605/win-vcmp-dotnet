using System;
using Fleka.DotnetVcmp.Interop;

namespace Fleka.DotnetVcmp {
    /// <summary>
    /// This exception indicates a VCMP error reported by GetLastError.
    /// </summary>
    public abstract class VcmpInternalException: Exception {
        internal VcmpInternalException(string message)
        :   base(message) {}
    }
}
