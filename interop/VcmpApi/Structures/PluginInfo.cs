using System.Runtime.InteropServices;

namespace Fleka.DotnetVcmp.Interop {
    [StructLayout(LayoutKind.Sequential, CharSet=CharSet.Ansi)]
    public unsafe struct PluginInfo {
        private uint StructSize;
        public uint PluginID;
        [MarshalAs(UnmanagedType.LPStr)]
        public fixed byte Name[32];
        public uint PluginVersion;
        public ushort ApiMajorVersion;
        public ushort ApiMinorVersion;
    }
}
