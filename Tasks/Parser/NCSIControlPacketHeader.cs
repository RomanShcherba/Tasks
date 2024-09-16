namespace Tasks.Parser
{
    /// <summary>
    /// NCSI Control packet header
    /// </summary>
    public class NcsiControlPacketHeader
    {
        /// <summary>
        /// Check sumary
        /// </summary>
        public string Checksum { get; set; }
        /// <summary>
        /// Control Packet Type
        /// </summary>
        public byte ControlPacketType { get; set; }
        /// <summary>
        /// Channel Id
        /// </summary>
        public byte ChannelId { get; set; }
        /// <summary>
        /// Flags
        /// </summary>
        public byte Flags { get; set; }
        /// <summary>
        /// Header Revision
        /// </summary>
        public byte HeaderRevision { get; set; }
        /// <summary>
        /// Instance Id
        /// </summary>
        public byte InstanceId { get; set; }
        /// <summary>
        /// Management Controller ID
        /// </summary>
        public byte McId { get; set; }
        /// <summary>
        /// Payload Length
        /// </summary>
        public ushort PayloadLength { get; set; }
        /// <summary>
        /// Padding
        /// </summary>
        public string Padding { get; set; }
        /// <summary>
        /// Reversed 1
        /// </summary>
        public byte Reserved1 { get; set; }
        /// <summary>
        /// Reserved 2
        /// </summary>
        public string Reserved2 { get; set; }
        /// <summary>
        /// Resereved 3
        /// </summary>
        public string Reserved3 { get; set; }
        /// <summary>
        /// Response Code
        /// </summary>
        public string ResponseCode { get; set; }
        /// <summary>
        /// Reason Code
        /// </summary>
        public string ReasonCode { get; set; }
        /// <summary>
        /// NCSI packet header parser
        /// </summary>
  
        public NcsiControlPacketHeader(byte[] data)
        {
            this.McId = data[0];
            this.HeaderRevision = data[15];
            this.Reserved1 = data[16];
            this.InstanceId = data[17];
            this.ControlPacketType = data[18];
            this.ChannelId = data[19];

            byte flagsByte = data[20];
            this.Flags = (byte)(flagsByte & 0x0F);
            ushort payloadLength = BitConverter.ToUInt16(data, 21);
            this.PayloadLength = (ushort)(payloadLength & 0x0FFF);
            this.Reserved2 = BitConverter.ToString(data.Skip(23).Take(4).ToArray()).Replace("-", "");
            this.Reserved3 = BitConverter.ToString(data.Skip(27).Take(4).ToArray()).Replace("-", "");
            this.ResponseCode = BitConverter.ToString(data.Skip(31).Take(2).ToArray()).Replace("-", "");
            this.ReasonCode = BitConverter.ToString(data.Skip(33).Take(2).ToArray()).Replace("-", "");
            this.Checksum = BitConverter.ToString(data.Skip(35).Take(4).ToArray()).Replace("-", "");
            this.Padding = BitConverter.ToString(data.Skip(39).Take(24).ToArray()).Replace("-", "");
        }

        /// <summary>
        /// Display fields
        /// </summary>
        public void Display()
        {
            Console.WriteLine($"\nNCSI Control Packet header: \nMC ID: 0x{McId:X2},\nHeader revision: 0x{HeaderRevision:X2}, \nReserved: 0x{Reserved1:X2}, \nInstance ID (IID): 0x{InstanceId:X2}, \nControl Packet type: 0x{ControlPacketType:X2}, \nChannel ID: 0x{ChannelId:X2}, \nFlags: 0x{Flags:X2}, \nPayload length: 0x{PayloadLength:X3}, \nReserved2: 0x{Reserved2}, \nReserved3: 0x{Reserved3}, \nResponse Code: 0x{ResponseCode}, \nReason Code: 0x{ReasonCode}, \nChecksum: 0x{Checksum}, \nPadding: 0x{Padding}");
        }
    }
}
