using System.Runtime.InteropServices;

namespace Fleka.DotnetVcmp.Interop {
    [StructLayout(LayoutKind.Sequential, CharSet=CharSet.Ansi)]
    public unsafe struct ServerSettings {
        private uint StructSize;
        public fixed byte ServerName[128];
        public uint MaxPlayers;
        public uint Port;
        public uint Flags;
    }
}
