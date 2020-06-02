using System;
using Fleka.DotnetVcmp.Interop;

namespace Fleka.DotnetVcmp {
    /// <summary>
    /// This exception indicates that the specified argument was not in the range of allowed values.
    /// </summary>
    public class ArgumentOutOfBoundsException: VcmpInternalException {
        internal ArgumentOutOfBoundsException()
        :   base("The specified argument was not in the range of allowed values.") {}
    }
}
