Task6_SnaiMatrix

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
        public static void Main()
        {
            var (rows, columns) = SnailMatrix.ValidInput();
            Console.WriteLine($"\nValid rows {rows} and columns {columns}");

            int[,] matrix = SnailMatrix.Matrix(rows, columns);
          
            Console.WriteLine();
            SnailMatrix.PrintDiagonal(matrix, rows, columns);

            int diagonal = SnailMatrix.CalculateMainDiagonal(matrix, rows, columns);
            Console.WriteLine($"\nSum of main diagonal {diagonal}");

            Console.WriteLine("\nElemetns sorted in snail shell order:");
            int[] snailOrder = SnailMatrix.SnailShellOrder(matrix, rows, columns);
            Console.WriteLine(string.Join(",", snailOrder));

       
        }
    }
}
