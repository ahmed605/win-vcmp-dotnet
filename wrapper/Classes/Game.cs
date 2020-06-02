using System;

namespace Fleka.DotnetVcmp {
    /// <summary>
    /// This class represents the VCMP server.
    /// </summary>
    public static class Game {
        /// <summary>
        /// Whether the server is initialized or not.
        /// </summary>
        public static bool IsInitialized {
            get;
            internal set;
        }

        /// <summary>
        /// This property contains operations that can be done directly to the server.
        /// </summary>
        public static IServer Server {
            get;
            internal set;
        }
    }
}
