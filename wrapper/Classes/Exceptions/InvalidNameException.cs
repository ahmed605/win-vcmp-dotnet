using System;
using Fleka.DotnetVcmp.Interop;

namespace Fleka.DotnetVcmp {
    /// <summary>
    /// This exception indicates that the specified name is invalid.
    /// </summary>
    public class InvalidNameException: VcmpInternalException {
        internal InvalidNameException()
        :   base("The specified name is invalid.") {}
    }
}
