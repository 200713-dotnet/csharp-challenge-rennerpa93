using Xunit;
using Palindrome.Domain.Models;

namespace Palindrome.Testing.Tests
{
  public class PalindromeCheckerTest {

    [Theory]
    [InlineData("racecar")]
    public void PalindromeTest(string input) {

      var sut = new PalindromeChecker();
      bool actual = sut.IsPalindrome(input);

      Assert.True(actual);
    }
  }
}