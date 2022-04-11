using System;
using System.Linq;
using System.Collections.Generic;
namespace PalindromeExercise
{
    public class WordSmith
    {
        public WordSmith()
        {
        }

        public bool IsAPalindrome(string str)
        {
            return str.SequenceEqual(str.Reverse());
        }
    }
}
