using System;
using System.Text;
using System.IO;
using System.Reflection;

namespace Fleka.DotnetVcmp.Interop {
    internal static class Main {
        private static byte Bootstrap(PluginFunctions pluginFuncs, ref PluginCallbacks pluginCallbacks) {
            EntryPointDelegate entryPoint = FindEntryPoint();

            if (entryPoint == null) {
                throw new MissingMethodException("Entry point not found.");
            }

            entryPoint(pluginFuncs, ref pluginCallbacks);

            return 1;
        }

        private static EntryPointDelegate FindEntryPoint() {
            string assemblyDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

            foreach (string assemblyFile in Directory.GetFiles(assemblyDirectory, "*.dll", SearchOption.TopDirectoryOnly)) {
                Assembly.LoadFrom(assemblyFile);
            }

            foreach (Assembly assembly in AppDomain.CurrentDomain.GetAssemblies()) {
                foreach (Type type in assembly.GetTypes()) {
                    foreach (MethodInfo methodInfo in type.GetMethods()) {
                        foreach (CustomAttributeData attributeData in methodInfo.CustomAttributes) {
                            if (attributeData.AttributeType == typeof(EntryPointAttribute)) {
                                return (EntryPointDelegate) methodInfo.CreateDelegate(typeof(EntryPointDelegate));
                            }
                        }
                    }
                }
            }

            return null;
        }
    }
}
