using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using SpongewareRehydrated.Network.Packets;
using System.Net.Sockets;

namespace SpongewareRehydrated.Network
{
    public class PacketSender
    {
        private BinaryFormatter _formatter = new BinaryFormatter();
        private TcpClient _client = new TcpClient();
        private string _ip;

        public PacketSender(string ip)
        {
            _ip = ip;
        }
        public void SendToServer(Packet packet) // ok
        {
            
        }
    }
}