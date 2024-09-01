using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    /// <summary>
    /// Reverse binary
    /// </summary>
    public class ReverseBinary
    {
        /// <summary>
        /// Reversing binary to string
        /// </summary>
        /// <param name="n">
        /// integer 
        /// </param>
        /// <returns></returns>
        public static int ReversingBinary(int n)
        {
            int result = Convert.ToInt32(new string(Convert.ToString(n, 2).Reverse().ToArray()), 2);

            return result;
        }
    }
}
