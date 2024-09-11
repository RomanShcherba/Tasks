namespace Tasks.Parser
{
    /// <summary>
    /// NCSI Control packet header
    /// </summary>
    public class NcsiControlPacketHeader
    {
        public byte McId { get; set; }
        public byte HeaderRevision { get; set; }
        public byte Reserved1 { get; set; }
        public byte InstanceId { get; set; }
        public byte ControlPacketType { get; set; }
        public byte ChannelId { get; set; }
        public byte Flags { get; set; }
        public ushort PayloadLength { get; set; }
        public string Reserved2 { get; set; }
        public string Reserved3 { get; set; }
        public string ResponseCode { get; set; }
        public string ReasonCode { get; set; }
        public string Checksum { get; set; }
        public string Padding { get; set; }

        /// <summary>
        /// NCSI packet header parser
        /// </summary>
        public NcsiControlPacketHeader(byte[] data)
        {
            McId = data[14];
            HeaderRevision = data[15];
            Reserved1 = data[16];
            InstanceId = data[17];
            ControlPacketType = data[18];
            ChannelId = data[19];

            byte flagsByte = data[20];
            Flags = (byte)(flagsByte & 0x0F);
            ushort payloadLength = BitConverter.ToUInt16(data, 21);
            PayloadLength = (ushort)(payloadLength & 0x0FFF);
            Reserved2 = BitConverter.ToString(data.Skip(23).Take(4).ToArray()).Replace("-", "");
            Reserved3 = BitConverter.ToString(data.Skip(27).Take(4).ToArray()).Replace("-", "");
            ResponseCode = BitConverter.ToString(data.Skip(31).Take(2).ToArray()).Replace("-", "");
            ReasonCode = BitConverter.ToString(data.Skip(33).Take(2).ToArray()).Replace("-", "");
            Checksum = BitConverter.ToString(data.Skip(35).Take(4).ToArray()).Replace("-", "");
            Padding = BitConverter.ToString(data.Skip(39).Take(24).ToArray()).Replace("-", "");
        }

        /// <summary>
        /// Display fields
        /// </summary>
        public void Display()
        {
            Console.WriteLine("\nNCSI Control Packet header:");
            Console.WriteLine($"MC ID: 0x{McId:X2}");
            Console.WriteLine($"Header revision: 0x{HeaderRevision:X2}");
            Console.WriteLine($"Reserved: 0x{Reserved1:X2}");
            Console.WriteLine($"Instance ID (IID): 0x{InstanceId:X2}");
            Console.WriteLine($"Control Packet type: 0x{ControlPacketType:X2}");
            Console.WriteLine($"Channel ID: 0x{ChannelId:X2}");
            Console.WriteLine($"Flags: 0x{Flags:X2}");
            Console.WriteLine($"Payload length: 0x{PayloadLength:X3}"); 
            Console.WriteLine($"Reserved2: 0x{Reserved2}");
            Console.WriteLine($"Reserved3: 0x{Reserved3}");
            Console.WriteLine($"Response Code: 0x{ResponseCode}");
            Console.WriteLine($"Reason Code: 0x{ReasonCode}");
            Console.WriteLine($"Checksum: 0x{Checksum}");
            Console.WriteLine($"Padding: 0x{Padding}");
        }
    }
}
