namespace Palindrome.Domain
{
  class PalindromeChecker
  {

    public static bool IsPalindrome(string input)
    {
      if (input.Length <= 1)
        return true;
      else
      {
        if (input[0] != input[input.Length - 1])
          return false;
        else
          return IsPalindrome(input.Substring(1, input.Length - 2));
      }
    }
  }
}