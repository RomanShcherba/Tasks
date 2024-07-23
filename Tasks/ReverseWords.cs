namespace ReverseEachWord
{

    /// <summary>
    /// Reverse words
    /// </summary>
    public class ReverseWords
    {

        /// <summary>
        /// Reverse aplhabetic characters of the input string
        /// </summary>
        /// <param name="s">
        /// Input string to process
        /// </param>
        public static string ReverseAlphabeticChars(string s)
        
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

            var alphabetChar = word.Where(c => char.IsLetter(c)).Reverse().ToArray();

            for (int i = 0; i < word.Length; i++)
            {
                if (char.IsLetter(word[i]))
                {
                    reversed[i] = alphabetChar[alphabetIndex];
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