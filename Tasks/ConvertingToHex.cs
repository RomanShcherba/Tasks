using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    /// <summary>
    /// Converting to hex
    /// </summary>
    public class ConvertingToHex
    {
        /// <summary>
        /// Converting chars to hex 
        /// </summary>
        /// <param name="data">
        /// input data
        /// </param>
        /// <returns></returns>
        public static string ConvertHex(string data)
        {
            char[] chars = data.ToCharArray();
            string output = "";

            foreach (char c in chars)
            {
                output += ((int)c).ToString("x2") + " ";
            }
            return output;
        }
    }
}
