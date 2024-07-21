using ReverseEachWord;
using System;
using System.Linq;
using System.Text.RegularExpressions;

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

            Console.WriteLine(ReverseWords.ReverseNonAlphabetic(inputLine));
        }
    }
}