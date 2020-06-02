using System;
using Fleka.DotnetVcmp.Interop;

namespace Fleka.DotnetVcmp {
    internal static class Main {
        internal static PluginFunctions PluginFunctions;

        [EntryPoint]
        private static void Bootstrap(PluginFunctions pluginFunctions, ref PluginCallbacks pluginCallbacks) {
            PluginFunctions = pluginFunctions;
            BindCallbacks(ref pluginCallbacks);
        }

        private static void BindCallbacks(ref PluginCallbacks pluginCallbacks) {
            
        }
    }
}
