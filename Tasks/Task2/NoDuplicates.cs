namespace Tasks
{
    public class NoDuplicates
    {
        public static int[] RemoveDuplicates(int[] numbers)
        {
            List<int> data = new List<int>();
            HashSet<int> nums = new HashSet<int>();

            foreach (int number in numbers)
            {
                if (!nums.Contains(number))
                {
                    data.Add(number);
                    nums.Add(number); 
                }
            }
            return data.ToArray();
        }
    }
}
