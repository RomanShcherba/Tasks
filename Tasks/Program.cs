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
            Console.WriteLine($"Valid rows {rows} and columns {columns}");

            int[,] matrix = SnailMatrix.Matrix(rows, columns);
          
            Console.WriteLine();
            SnailMatrix.PrintDiagonal(matrix);

            int diagonal = SnailMatrix.CalculateMainDiagonal(matrix);
            Console.WriteLine($"Sum of main diagonal {diagonal}");

            Console.WriteLine("Elemetns sorted in snail shell order:");
            int[] snailOrder = SnailMatrix.SnailShellOrder(matrix);
            Console.WriteLine(string.Join(",", snailOrder));
        }
    }
}
