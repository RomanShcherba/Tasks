using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks.Task2
{
    /// <summary>
    /// Summ of squares
    /// </summary>
    public class SumSquares
    {
        /// <summary>
        /// Summing squares in list of objects 
        /// </summary>
        /// <param name="list">
        /// List of objects
        /// </param>
        public static int SquareSumm (List<object> list)
        {
            int summ = 0;

            foreach (var number in list)
            {
                if (number is List<object>)
                {
                    summ += SquareSumm((List<object>)number);
                }
                else if (number is int)
                {
                    summ += (int)number * (int)number;
                }
            }
            return summ;
        }
    }
}
