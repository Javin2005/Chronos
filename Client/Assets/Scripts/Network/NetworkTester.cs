using UnityEngine;
using Chronos.Shared;
public class NetworkTester : MonoBehaviour
{

    void Start()
    {
        Debug.Log("Testing Protocol Packing");

        PingPacket testPacket = new PingPacket();
        testPacket.Header.Type = PacketType.Ping;
        testPacket.Header.Sequence = 1;
        testPacket.ClientTimestamp = 0;


        byte[] data = NetworkUtils.Serialize(testPacket);

        Debug.Log($"C# Packet Size: {data.Length} bytes");

        if (data.Length == 13)
        {
            Debug.Log("<color=green>SUCCESS: C# matches C++ size (13 bytes)!</color>");
        }
        else
        {
            Debug.LogError($"FAILED: Size is {data.Length}, expected 13. Check your Packing!");
        }
    }
}