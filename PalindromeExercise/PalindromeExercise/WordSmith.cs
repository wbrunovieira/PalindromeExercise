using System;
using System.Linq;
namespace PalindromeExercise
{
    public class WordSmith
    {
        public bool IsAPalindrome(string word)
        {
            // reverse the word // hello // olleh


            var reversed = "";

            for (int i = word.Length - 1; i >= 0; i--)
            {
                reversed += word[i];
            }

            //compare the origin  with the reverse
            if (reversed.ToLower() == word.ToLower())
            {
                return true;
            }
            else
            {
                return false;
            }

            // return wheather they are the same or not

        }
    }
}
