namespace Tasks
{
    public class Program
    {
        public static void Main()
        {
            var (rows, columns) = SnailArray.ValidInput();
            Console.WriteLine($"Valid rows {rows} and columns {columns}");

            int[,] matrix = new int[rows, columns];
            Random random = new Random();
            SnailArray.Matrix(matrix, random);

            Console.WriteLine();
            SnailArray.PrintDiagonal(matrix);
        }
    }
}
