
namespace Tasks
{
    public class SnailMatrix
    {
        /// <summary>
        /// 
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
        /// 
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
                        Console.ForegroundColor = ConsoleColor.Magenta;
                    }
                    Console.Write(matrix[x, y].ToString().PadLeft(4));
                    Console.ResetColor();
                }
                Console.WriteLine();
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public static int CalculateMainDiagonal(int[,] matrix)
        {
            int diagonal = 0;
            int size = Math.Min(matrix.GetLength(0), matrix.GetLength(1));
            for (int x = 0; x < size; x++) 
            {
                diagonal += matrix[x, x];
            }
            return diagonal;
        }
    }
}
