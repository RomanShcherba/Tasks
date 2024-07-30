using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    /// <summary>
    /// Validation hex code
    /// </summary>
    public class ValidHexCode
    {
        /// <summary>
        /// Validation of hex code
        /// </summary>
        /// <param name="inputHex)">
        /// input hex code
        /// </param>
        /// <returns></returns>
        public static bool CheckIsHexValid(string inputHex)
        {
            if (inputHex.Length != 8 && !inputHex.StartsWith("0x"))
            {
                return false;
            }
         
            return inputHex.Substring(2).All(x => "0123456789ABCDEFabcdef".Contains(x));
        }
    }
}

