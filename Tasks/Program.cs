namespace Tasks
{
    public class Program
    {
        public static void Main()
        {
            var (rows, columns) = SnailMatrix.ValidInput();
            Console.WriteLine($"Valid rows {rows} and columns {columns}");

            int[,] matrix = SnailMatrix.Matrix(rows, columns);
          
            Console.WriteLine();
            SnailMatrix.PrintDiagonal(matrix);

            int diagonal = SnailMatrix.CalculateMainDiagonal(matrix);
            Console.WriteLine($"Sum of main diagonal {diagonal}");
        }
    }
}
