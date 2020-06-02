using System;
using Fleka.DotnetVcmp.Interop;

namespace Fleka.DotnetVcmp {
    /// <summary>
    /// This exception indicates that the entity pool does not have any space left for a new entity.
    /// </summary>
    public class PoolExhaustedException: VcmpInternalException {
        internal PoolExhaustedException()
        :   base("The entity pool does not have any space left for a new entity.") {}
    }
}
