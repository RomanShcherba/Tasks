using ReverseEachWord;

/// <summary>
/// Program
/// </summary>
public class Program : ReverseWords
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

            Console.WriteLine(ReverseAlphabeticChars(inputLine));

        }
    }
}