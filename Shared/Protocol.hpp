#pragma once
#include <cstdint>

enum class PacketType : uint8_t
{
    Ping = 1,
    Welcome = 2,
    PlayerInput = 3,
    StateUpdate = 4
};

#pragma pack(push, 1)
struct NetHeader
{
    PacketType type;
    uint32_t sequence;
};

struct PingPacket
{
    NetHeader header;
    uint64_t clientTimestamp;
};

#pragma pack(pop)