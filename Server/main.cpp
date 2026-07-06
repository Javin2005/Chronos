#include <iostream>
#include "Protocol.h"

using namespace std;

int main()
{
    cout << "Project Chronos: Server Initialization" << endl;

    cout << "Size of NetHeader: " << sizeof(NetHeader) << " bytes (Expected: 5)" << endl;
    cout << "Size of PingPocket: " << sizeof(PingPacket) << " bytes (Expected 13)" << endl;

    if (sizeof(NetHeader) != 5)
    {
        cerr << "CRITICAL: Struct packing failed for NetHeader!" << endl;
        return 1;
    }

    cout << "Protocol verification successful. Server ready for implementation" << endl;
    return 0;
}