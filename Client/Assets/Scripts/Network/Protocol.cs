using System;
using System.Runtime.InteropServices;

namespace Chronos.Shared
{
    public enum PacketType : byte
    {
        Ping = 1,
        JoinRequest = 2,
        Welcome = 3
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

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct JoinRequestPacket
    {
        public NetHeader header;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string PlayerName;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct WelcomePacket
    {
        public NetHeader header;
        public ushort PlayerId;
    }
}