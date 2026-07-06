#include <iostream>
#include "Protocol.hpp"
#include <asio.hpp>

using namespace std;
using namespace asio;
using asio::ip::udp;

int main()
{
    try
    {
        io_context io_context;

        udp::socket socket(io_context, udp::endpoint(udp::v4(), 9999));

        cout << "Server is listening on port 9999..." << endl;

        while (true)
        {

            char recv_buf[1024];
            udp::endpoint remote_endpoint;

            size_t bytes_received = socket.receive_from(
                buffer(recv_buf),
                remote_endpoint);

            cout << "Received " << bytes_received << " bytes from " << remote_endpoint << endl;

            if (bytes_received >= sizeof(NetHeader))
            {
                NetHeader *header = reinterpret_cast<NetHeader *>(recv_buf);

                if (header->type == PacketType::Ping)
                {
                    cout << "It's a Ping! Sequence: " << header->sequence << endl;
                }
            }
        }
    }
    catch (exception &e)
    {
        cerr << "Error: " << e.what() << endl;
    }
    return 0;
}