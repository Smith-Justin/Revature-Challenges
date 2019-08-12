using System;
using Week1.Domain;

namespace Week1.Client
{
    class Program
    {
        
        static void Main(string[] args)
        {
            System.Console.WriteLine(Palindrome.Checkpalindrome(args[0]));
        }
    }
}
