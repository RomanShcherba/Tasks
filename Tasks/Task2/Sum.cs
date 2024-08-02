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
        public static int SummIgnoringDuplicates(List<int> numbers)
        {
            HashSet<int> unique = new HashSet<int>();
            HashSet<int> duplicates = new HashSet<int>();

            int summ = 0;

            foreach (int number in numbers)
            {
                if (duplicates.Contains(number))
                {
                    continue;
                }
                if (unique.Contains(number))
                {
                    unique.Remove(number);
                    duplicates.Add(number);
                }
                else
                {
                    unique.Add(number);
                }
            }
            foreach (int number in unique)
            {
                summ += number;
            }
            return summ;
        }
    }
}
