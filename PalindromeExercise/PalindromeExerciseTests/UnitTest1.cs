using System;
using Xunit;
using PalindromeExercise;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("hello", false)]
        [InlineData("Racecar", true)]
        public void MyTest(string word, bool expected)
        {
            //arrange

            var tester = new WordSmith();

            // act

            var actual = tester.IsAPalindrome(word);

            //assert
            Assert.Equal(actual, expected);
        } 
    }
}
