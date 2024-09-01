using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
