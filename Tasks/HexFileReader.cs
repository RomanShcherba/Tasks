namespace Tasks
{
    public class HexFileReader
    {
        public byte[] ReadHexString(string filePath)
        {
            string hexString = File.ReadAllText(filePath);
        }
    }
}
