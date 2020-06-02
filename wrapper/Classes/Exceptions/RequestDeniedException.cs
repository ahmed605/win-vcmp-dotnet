using System;
using Fleka.DotnetVcmp.Interop;

namespace Fleka.DotnetVcmp {
    /// <summary>
    /// This exception indicates that the specified request was denied.
    /// </summary>
    public class RequestDeniedException: VcmpInternalException {
        internal RequestDeniedException()
        :   base("The specified request was denied.") {}
    }
}
