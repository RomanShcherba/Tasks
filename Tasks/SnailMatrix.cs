using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    public class SnailArray
    {
        public static void MatrixNumberRange (int rows, int columns)
        {
            if (rows < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(rows));
            }
            if (columns < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(columns));
            }
        }
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
        public static int ValidInput()
        {
            int input;

            while (int.TryParse(Console.ReadLine(), out input) || input <= 0 || input >= 46340)
            {
                 Console.WriteLine("Invalid input");
            }
            return input;
        }

        public static void PrintDiagonal(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);
            
            for(int x = 0;x < rows; x++)
            {
                for(int y = 0;y < columns; y++)
                {
                }
            }
        }
    }
}
