using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ReverseEachWord
{
    public class ReverseWords
    {
        /// <summary>
        /// Reverse non alphabetic word
        /// </summary>
        /// <param name="s">
        /// String to process
        /// </param>
        public static string ReverseNonAlphabetic(string s)
        {
            string[] words = s.Split(new char[] { ' ' }, StringSplitOptions.None);
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = ReverseWord(words[i]);
            }
            return string.Join(" ", words);

        }
        /// <summary>
        /// Reversing word
        /// </summary>
        /// <param name="word">
        /// Alphabetical symbols that are entered
        /// </param>
        static string ReverseWord(string word)
        {
            char[] reversed = new char[word.Length];
            int alphabetIndex = 0;

            var alphaChar = word.Where(c => Char.IsLetter(c)).Reverse().ToArray();

            for (int i = 0; i < word.Length; i++)
            {
                if (char.IsLetter(word[i]))
                {
                    reversed[i] = alphaChar[alphabetIndex];
                    alphabetIndex++;
                }
                else
                {
                    reversed[i] = word[i];
                }
            }
            return new string(reversed);
        }
    }
}