namespace Tasks.Parser
{
    /// <summary>
    /// Ethernet frame header
    /// </summary>
    public class EthernetFrameHeader
    {
        public string DestinationAddress { get; set; }
        public string SourceAddress { get;  set; }
        public string EtherType { get; set; }

        /// <summary>
        /// Ethernet frame header parser
        /// </summary>
        public EthernetFrameHeader(byte[] data)
        {
            DestinationAddress = BitConverter.ToString(data.Take(6).ToArray()).Replace("-", ":");
            SourceAddress = BitConverter.ToString(data.Skip(6).Take(6).ToArray()).Replace("-", ":");
            EtherType = BitConverter.ToString(data.Skip(12).Take(2).ToArray()).Replace("-", "");
        }
        /// <summary>
        /// Display fields
        /// </summary>
        public void Display()
        {
            Console.WriteLine($"\nEthernet frame header: \nDestination Address (DA): {DestinationAddress}, \nSource Address (SA): {SourceAddress},\nEtherType: 0x{EtherType} ");
        }
    }
}