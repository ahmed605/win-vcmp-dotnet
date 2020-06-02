using System;
using Fleka.DotnetVcmp.Interop;

namespace Fleka.DotnetVcmp {
    /// <summary>
    /// This exception indicates that the specified buffer was too small to fit the requested data.
    /// This exception should NOT be occurring. Create an issue on GitLab if it does.
    /// </summary>
    public class BufferTooSmallException: VcmpInternalException {
        internal BufferTooSmallException()
        :   base("The specified buffer was too small to fit the requested data. Please create an issue on GitLab.") {}
    }
}
