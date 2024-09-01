using Tasks.Task2;

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
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("Enter a line");
                string inputLine = Console.ReadLine();

                if (inputLine.ToLower() == "exit")
                    break;

                Console.WriteLine(ReverseWords.ReverseAlphabeticChars(inputLine));
            }

            //Removing duplicates

            int[] inp1 = { 1, 1, 2 };
            int[] inp2 = { 1, 2, 1, 1, 3, 2 };


            int[] output1 = WithoutDuplicates.RemoveDuplicates(inp1);
            int[] output2 = WithoutDuplicates.RemoveDuplicates(inp2);

            int[] output3 = WithoutDuplicates.DuplicatesRemove(inp1);
            int[] output4 = WithoutDuplicates.DuplicatesRemove(inp2);

            Console.WriteLine($"[{string.Join(", ", output1)}], [{string.Join(", ", output2)}]");
            Console.WriteLine($"[{string.Join(", ", output3)}], [{string.Join(", ", output4)}]");

            //Summ without duplicates

            List<int> list1 = new List<int>() { 3, 4, 3, 6 };
            List<int> list2 = new List<int>() { 1, 10, 3, 10, 10 };

            Console.WriteLine($"Sum without duplicates list1:{Sum.SumIgnoringDuplicates(list1)}, list2:{Sum.SumIgnoringDuplicates(list2)}");

            //Square summ

            var l1 = new List<object> { 1, 2, 3 };
            Console.WriteLine(SumSquares.SquareSumm(l1) == 14);

            var l2 = new List<object> { new List<object> { 1, 2 }, 3 };
            Console.WriteLine(SumSquares.SquareSumm(l2) == 14);

            var l3 = new List<object> { new List<object> { new List<object> { new List<object> { new List<object> { new List<object> { new List<object> { new List<object> { new List<object> { new List<object> { new List<object> { new List<object> { 1 } } } } } } } } } } } };
            Console.WriteLine(SumSquares.SquareSumm(l3) == 1);

            var l4 = new List<object> { 10, new List<object> { new List<object> { 10 }, 10 }, new List<object> { 10 } };
            Console.WriteLine(SumSquares.SquareSumm(l4) == 400);

        }
    }
}


