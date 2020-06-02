using System;
using Fleka.DotnetVcmp.Interop;

namespace Fleka.DotnetVcmp {
    /// <summary>
    /// This exception indicates that the specified entity was not found.
    /// </summary>
    public class NoSuchEntityException: VcmpInternalException {
        internal NoSuchEntityException()
        :   base("The specified entity was not found.") {}
    }
}
