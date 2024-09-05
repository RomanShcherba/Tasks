using Tasks.Parser;

namespace Tasks
{
    public class Program
    {
        static void Main()
        {

            string filePath = @"Data\HexInput.txt";

            string[] hexStrings = File.ReadAllLines(filePath);

            foreach (string hexString in hexStrings)
            {
                byte[] data = Enumerable.Range(0, hexString.Length)
                                        .Where(x => x % 2 == 0)
                                        .Select(x => Convert.ToByte(hexString.Substring(x, 2), 16))
                                        .ToArray();

                EthernetFrameHeader ethernetHeader = new EthernetFrameHeader(data);
                ethernetHeader.Display();

                NcsiControlPacketHeader ncsiControlPacketHeader = new NcsiControlPacketHeader(data);
                ncsiControlPacketHeader.Display();
            }
        }
    }
}
