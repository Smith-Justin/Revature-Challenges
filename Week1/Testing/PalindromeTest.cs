using Week1.Domain;
using Xunit;

namespace Week1.Testing
{
    
    public class PalindromeTest
    {
        [Fact]
        public void Test_Palindrome()
        {
            //arrange
            var palindromeString="A man, a plan, a cat, a ham, a yak, a yam, a hat, a canal-Panama!";
            var expected = true;

            //act
            var actual = Palindrome.Checkpalindrome(palindromeString);

            //assert
            Assert.True(actual == expected);
        }

        [Fact]
        public void Test_Non_Palindrome()
        {
            //arrange
            var nonPalindromeString="fee fi fo fum";
            var expected = false;

            //act
            var actual = Palindrome.Checkpalindrome(nonPalindromeString);

            //assert
            Assert.True(actual == expected);
        }
    }
}