using System;
using Fleka.DotnetVcmp.Interop;

namespace Fleka.DotnetVcmp {
    /// <summary>
    /// This exception indicates that an operation has been requested which can not execute until
    /// the server initializes.
    /// </summary>
    public class ServerNotInitializedException: Exception {
        public ServerNotInitializedException()
        :   base("This operation is not supported prior to the server initializing.") {}
    }
}
