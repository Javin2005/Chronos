#pragma once
#include <cstdint>

enum class PacketType : uint8_t
{
    Ping = 1,
    JoinRequest = 2,
    Welcome = 3
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

struct JoinRequestPacket
{
    NetHeader header;
    char playerName[16];
};

struct WelcomePacket
{
    NetHeader header;
    uint16_t player_Id;
};

#pragma pack(pop)