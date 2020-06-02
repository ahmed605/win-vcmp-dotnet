using System;
using Fleka.DotnetVcmp.Interop;

namespace Fleka.DotnetVcmp {
    /// <summary>
    /// This exception indicates that the specified argument was null.
    /// This exception should NOT be occurring. Create an issue on GitLab if it does.
    /// </summary>
    public class NullArgumentException: VcmpInternalException {
        internal NullArgumentException()
        :   base("The specified argument was null. Please create an issue on GitLab.") {}
    }
}
