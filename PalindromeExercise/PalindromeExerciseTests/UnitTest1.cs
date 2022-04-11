using System;
using PalindromeExercise;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("something", false)]
        [InlineData("civic", true)]
        [InlineData("kayak", true)]
        [InlineData("madam", true)]
        public void Test1(string word, bool expected)
        {
            //Arrange
            WordSmith challenger = new WordSmith();

            //Act
            bool actual = challenger.IsAPalindrome(word);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
