using System;
using System.Runtime.InteropServices;

namespace Chronos.Shared
{
    public enum PacketType : byte
    {
        Ping = 1,
        Welcome = 2,
        PlayerInput = 3,
        StateUpdate = 4
    }

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct NetHeader
    {
        public PacketType Type;
        public uint Sequence;

    }

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct PingPacket
    {
        public NetHeader Header;
        public ulong ClientTimestamp;
    }
}