namespace Tasks
{
    /// <summary>
    /// No duplicates
    /// </summary>
    public class NoDuplicates
    {
        /// <summary>
        /// Remove duplicates from array
        /// </summary>
        /// <param name="numbers">
        /// numbers
        /// </param>
        public static int[] RemoveDuplicates(int[] numbers)
        {
            List<int> data = new List<int>();

            foreach (int number in numbers)
            {
                if (!data.Contains(number))
                {
                    data.Add(number);
                }
            }
            return data.ToArray();
        }
        
        /// <summary>
        /// Remove duplicates but with HashSet
        /// </summary>
        /// <param name="numbers">
        /// numbers
        /// </param>
        public static int[] DuplicatesRemove(int[] numbers)
        {
            HashSet<int> nums = new HashSet<int>();

            return numbers.Distinct().ToArray();

        }
    }
}
