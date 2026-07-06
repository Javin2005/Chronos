using UnityEngine;
using Chronos.Shared;
using System.Net.Sockets;
using System;

public class NetworkTester : MonoBehaviour
{
    void Start()
    {
        Debug.Log("Starting Network Handshake Test");

        PingPacket testPacket = new PingPacket();
        testPacket.Header.Type = PacketType.Ping;
        testPacket.Header.Sequence = 42;

        testPacket.ClientTimestamp = (ulong)DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();

        byte[] data = NetworkUtils.Serialize(testPacket);

        Debug.Log($"C# Packet Size: {data.Length} bytes");

        if (data.Length == 13)
        {
            Debug.Log("<color=green>SUCCESS: Local size is 13 bytes. Sending to server...</color>");

            try
            {
                using (UdpClient client = new UdpClient())
                {
                    client.Connect("127.0.0.1", 9999);

                    client.Send(data, data.Length);

                    Debug.Log("Packet sent to 127.0.0.1:9999");
                }
            }
            catch (Exception e)
            {
                Debug.LogError($"Network Error: {e.Message}");
            }
        }
        else
        {
            Debug.LogError($"FAILED: Size is {data.Length}, expected 13.");
        }


    }
}