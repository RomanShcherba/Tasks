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


            int[] inp1 = { 1, 1, 2 };
            int[] inp2 = { 1, 2, 1, 1, 3, 2 };

            
            int[] output1 = NoDuplicates.RemoveDuplicates(inp1);
            int[] output2 = NoDuplicates.RemoveDuplicates(inp2);

            Console.WriteLine($"[{string.Join(", ", output1)}], [{string.Join(",",output2)}]");
            
        }
    }
}


