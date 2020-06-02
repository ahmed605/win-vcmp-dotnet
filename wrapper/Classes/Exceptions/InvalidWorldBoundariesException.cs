using System;
using Fleka.DotnetVcmp.Interop;

namespace Fleka.DotnetVcmp {
    /// <summary>
    /// This exception indicates that the specified world boundaries are outside Vice City's limits.
    /// </summary>
    public class InvalidWorldBoundariesException: VcmpInternalException {
        internal InvalidWorldBoundariesException()
        :   base("The specified world boundaries are outside Vice City's limits.") {}
    }
}
