﻿
namespace Tasks
{
    public class SnailMatrix
    {
        /// <summary>
        /// Matrix with random numbers
        /// </summary>
        public static int[,] Matrix(int rows, int columns)
        {
            Random random = new Random();
            int[,] matrix = new int[rows, columns];

            for (int x = 0; x < rows; x++)
            {
                for (int y = 0; y < columns; y++)
                {
                    matrix[x, y] = random.Next(0, 101);
                }
            }
            return matrix;
        }
        /// <summary>
        /// Valid input check
        /// </summary>
        public static (int rows, int columns) ValidInput()
        {
            int maxRangeQuantity = 46340;
            int rows, columns;

            do
            {
                Console.WriteLine("Enter number of rows");
            }

            while (!int.TryParse(Console.ReadLine(), out rows) || rows <= 0 || rows >= maxRangeQuantity);

            do
            {
                Console.WriteLine("Enter number of columns");
            }
            while (!int.TryParse(Console.ReadLine(), out columns) || columns <= 0 || columns >= maxRangeQuantity);
   
            return (rows, columns);
        }
        /// <summary>
        /// Print main diagonal
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
                        Console.ForegroundColor = ConsoleColor.Magenta;
                    }
                    Console.Write(matrix[x, y].ToString().PadLeft(4));
                    Console.ResetColor();
                }
                Console.WriteLine();
            }
        }
        /// <summary>
        /// Calculate main diagonal
        /// </summary>
        public static int CalculateMainDiagonal(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);
            int diagonal = 0;
            int size = Math.Min(rows, columns);
            for (int x = 0; x < size; x++) 
            {
                diagonal += matrix[x, x];
            }
            return diagonal;
        }
        /// <summary>
        /// Snail shell order
        /// </summary>
        public static int[] SnailShellOrder(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);
            int[] snailOrder = new int[rows * columns];
            int index = 0;
            int top = 0, bottom = rows - 1, left = 0, right = columns - 1;

            while (top <= bottom && left <= right)
            {
                for (int i = left; i <= right; i++)
                    snailOrder[index++] = matrix[top, i];
                top++;

                for (int i = top; i <= bottom; i++)
                    snailOrder[index++] = matrix[i, right];
                right--;

                for (int i = right; i >= left; i--)
                     snailOrder[index++] = matrix[bottom, i];
                bottom--;
       
                for (int i = bottom; i >= top; i--)
                    snailOrder[index++] = matrix[i, left];
                left++;
            }
            return snailOrder;
        }
    }
}
