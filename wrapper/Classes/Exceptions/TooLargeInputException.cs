using System;
using Fleka.DotnetVcmp.Interop;

namespace Fleka.DotnetVcmp {
    /// <summary>
    /// This exception indicates that the specified input was too large to be processed.
    /// </summary>
    public class TooLargeInputException: VcmpInternalException {
        internal TooLargeInputException()
        :   base("The specified input was too large to be processed.") {}
    }
}
