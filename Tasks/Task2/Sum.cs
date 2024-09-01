namespace Tasks.Task2
{
    /// <summary>
    /// Summing
    /// </summary>
    public class Sum
    {
        /// <summary>
        /// Summa with ignoring duplicate numbers
        /// </summary>
        /// <param name="numbers">
        /// numbers
        /// </param>
        public static int SumIgnoringDuplicates(List<int> numbers)
        {
            int sum = 0;

            sum = numbers.Where(x => numbers.Count(n => n == x) == 1).Sum();

            return sum;
        }
    }
}
