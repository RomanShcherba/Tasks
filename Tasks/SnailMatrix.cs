using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    public class SnailArray
    {
        /// <summary>
        /// 
        /// </summary>
        public static void Matrix(int[,] matrix, Random random)
        {
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);

            for (int x = 0; x < rows; x++)
            {
                for (int y = 0; y < columns; y++)
                {
                    matrix[x, y] = random.Next(0, 101);
                }
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public static (int rows, int columns) ValidInput()
        {
            int rows, columns;

            do
            {
                Console.WriteLine("Enter number of rows");
            }

            while (!int.TryParse(Console.ReadLine(), out rows) || rows <= 0 || rows >= 46340);

            do
            {
                Console.WriteLine("Enter number of columns");
            }
            while (!int.TryParse(Console.ReadLine(), out columns) || columns <= 0 || columns >= 46340);
   
            return (rows, columns);
        }
        /// <summary>
        /// 
        /// </summary>
        public static void PrintDiagonal(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);
            
            for(int x = 0;x < rows; x++)
            {
                for(int y = 0;y < columns; y++)
                {
                    if (x == y)
                    {

                    }
                    Console.Write(matrix[x, y].ToString().PadLeft(4));

                }
                Console.WriteLine();
            }
        }
    }
}
