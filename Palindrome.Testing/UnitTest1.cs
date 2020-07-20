using System;
using Xunit;

namespace Palindrome.Testing
{
  public class UnitTest1
  {
    [Fact]
    public void IsPalindromeTest()
    {
      var sut = new PalindromeChecker();


      Assert.IsType<PalindromeChecker>(sut);
      Assert.NotNull(sut);
    }
  }
}