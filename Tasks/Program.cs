using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    /// <summary>
    /// Program
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Main
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            //Validation hex code

            string input = "0xF34BBC";
            if(ValidHexCode.CheckIsHexValid(input)) 
            {
                int decimalValue = Convert.ToInt32(input.Substring(2), 16);
                string binary = Convert.ToString(decimalValue, 2);
                Console.WriteLine($"valid hex: {input}, \ndecimal: {decimalValue}, \nbinary: {binary}");
            }
            else
            {
                Console.WriteLine("invalid hex code");
            }

            //Convertin to hex

            Console.WriteLine($"\n{ConvertingToHex.ConvertHex("hello world")}\n{ConvertingToHex.ConvertHex("Big Boi")}\n{ConvertingToHex.ConvertHex("Marty Poppinson")}");

            //Reversing binary

            Console.WriteLine($"{ReverseBinary.ReversingBinary(10)}, \n{ReverseBinary.ReversingBinary(12)}, \n{ReverseBinary.ReversingBinary(25)}, \n{ReverseBinary.ReversingBinary(45)}");
        }
    }
}
