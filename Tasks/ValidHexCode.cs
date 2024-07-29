using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    public class ValidHexCode
    {
        public static bool ValidHex(string hex)
        {
            if (hex.Length == 8)
            {
                return true;
            }
            if (hex.StartsWith("0x"))
            {
                return true;
            }
        }
    }
}

