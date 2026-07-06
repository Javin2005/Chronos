### what did you do today: 
- **initaliserade allt**
## [Date] - Protocol Mirroring
- Successfully verified C++ struct sizes (NetHeader: 5, PingPacket: 13).
- Created C# mirror of the protocol in Unity.
- Researched Marshalling in C# to understand how to convert structs to byte arrays.
- Setup Unity 6 project structure with folders for Scripts/Network.
- Identified the need for `Pack = 1` to ensure cross-language compatibility.
- Resolved environment issues (installed .NET SDK 8.0, configured Unity Registry).
- Successfully ran the NetworkTester in Unity.
- Confirmed that the Marshalling logic produces exactly 13 bytes, matching the C++ server's expectation.