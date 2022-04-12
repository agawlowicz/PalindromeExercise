using System;
using System.Linq;

namespace PalindromeExercise
{
    public class WordSmith
    {
        public WordSmith()
        {
        }

        public bool IsAPalindrome(string str)
            => str.Replace(" ", "").ToLower().SequenceEqual(str.Replace(" ", "").ToLower().Reverse());
    }
}
