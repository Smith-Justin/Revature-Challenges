using System.Text.RegularExpressions;

namespace Week1.Domain
{
    public class Palindrome
    {
        
        public static bool Checkpalindrome(string palindrome)
        {
            string lowercaseAlphanumericPalindrome = palindrome.ToLower();

            lowercaseAlphanumericPalindrome = Regex.Replace(lowercaseAlphanumericPalindrome, @"[^a-z0-9]", "");
            

            bool isPalindrome=true;
            int length = lowercaseAlphanumericPalindrome.Length;
            for(int i=0; i<length; i++)
            {
                if(!lowercaseAlphanumericPalindrome[i].Equals(lowercaseAlphanumericPalindrome[length - 1 - i]))
                {
                    isPalindrome = false;
                    break;
                }
            }

            return isPalindrome;
        }
    }
}