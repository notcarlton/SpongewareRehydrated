using System;
using System.Collections.Generic;

namespace SpongewareRehydrated.Network.Packets
{
    public struct Packet // based off of muck's packets
    {
        public List<byte> Data;
        public PacketType Type;
        public Packet(PacketType type)
        {
            Data = new List<byte>();
            Type = type;
        }

        public void Reset()
        {
            Data.Clear();
        }

        public void Write(byte thing)
        {
            Data.Add(thing);
        }

        public void Write(byte[] things)
        {
            Data.AddRange(things);
        }

        public void Write(int thing)
        {
            Data.AddRange(BitConverter.GetBytes(thing));
        }

        public void Write(float thing)
        {
            Data.AddRange(BitConverter.GetBytes(thing));
        }

        public void Write(bool thing)
        {
            Data.AddRange(BitConverter.GetBytes(thing));
        }

        // TODO: the rest of this shit lmao
    }

    public enum PacketType
    {
        PlayerPosition, // write x, y, and z floats
        PlayerRotation, // idfk
        Fire, // bullet raycast for validation
        Death // tell other players that you died
    }
}