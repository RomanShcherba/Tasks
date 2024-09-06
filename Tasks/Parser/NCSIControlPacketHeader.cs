namespace Tasks.Parser
{
    public class NcsiControlPacketHeader
    {
        public byte McId { get; set; }
        public byte HeaderRevision { get; set; }
        public byte Reserved1 { get; set; }
        public byte InstanceId { get; set; }
        public byte ControlPacketType { get; set; }
        public byte ChannelId { get; set; }
        public string Flags { get; set; }
        public string PayloadLength { get; set; }
        public string Reserved2 { get; set; }
        public string Reserved3 { get; set; }
        public string ResponseCode { get; set; }
        public string ReasonCode { get; set; }
        public string Checksum { get; set; }
        public string Padding { get; set; }

        public NcsiControlPacketHeader(byte[] data)
        {
            McId = data[15];
            HeaderRevision = data[16];
            Reserved1 = data[17];
            InstanceId = data[18];
            ControlPacketType = data[19];
            ChannelId = data[20];
            Flags = BitConverter.ToString(data.Skip(20).Take(2).ToArray()).Replace("-", "");
            PayloadLength = BitConverter.ToString(data.Skip(22).Take(2).ToArray()).Replace("-", "");
            Reserved2 = BitConverter.ToString(data.Skip(24).Take(2).ToArray()).Replace("-", "");
            Reserved3 = BitConverter.ToString(data.Skip(26).Take(4).ToArray()).Replace("-", "");
            ResponseCode = BitConverter.ToString(data.Skip(30).Take(2).ToArray()).Replace("-", "");
            ReasonCode = BitConverter.ToString(data.Skip(32).Take(2).ToArray()).Replace("-", "");
            Checksum = BitConverter.ToString(data.Skip(34).Take(4).ToArray()).Replace("-", "");
            Padding = BitConverter.ToString(data.Skip(38).Take(24).ToArray()).Replace("-", "");
        }
        public void Display()
        {
            Console.WriteLine("\nNCSI Control Packet header:");
            Console.WriteLine($"MC ID: 0x{McId:X2}");
            Console.WriteLine($"Header revision: 0x{HeaderRevision:X2}");
            Console.WriteLine($"Reserved: 0x{Reserved1:X2}");
            Console.WriteLine($"Instance ID (IID): 0x{InstanceId:X2}");
            Console.WriteLine($"Control Packet type: 0x{ControlPacketType:X2}");
            Console.WriteLine($"Channel ID: 0x{ChannelId:X2}");
            Console.WriteLine($"Flags: 0x{Flags}");
            Console.WriteLine($"Payload length: 0x{PayloadLength}");
            Console.WriteLine($"Reserved: 0x{Reserved2}");
            Console.WriteLine($"Reserved: 0x{Reserved3}");
            Console.WriteLine($"Response Code: 0x{ResponseCode}");
            Console.WriteLine($"Reason Code: 0x{ReasonCode}");
            Console.WriteLine($"Checksum: 0x{Checksum}");
            Console.WriteLine($"Padding: 0x{Padding}");
        }

        public static byte[] ConvertToBigEndian(byte[] data)
        {
            if (BitConverter.IsLittleEndian)
            {
                Array.Reverse(data);
            }
            return data;
        }
    }
}