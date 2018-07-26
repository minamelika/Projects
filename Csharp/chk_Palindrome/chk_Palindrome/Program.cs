using System;

namespace chk_Palindrome
{
    class Program
    {

        //    Given the string, check if it is a palindrome.

        //Example
        //    For inputString = "aabaa", the output should be
        //    checkPalindrome(inputString) = true;
        //    For inputString = "abac", the output should be
        //    checkPalindrome(inputString) = false;
        //    For inputString = "a", the output should be
        //    checkPalindrome(inputString) = true.

        static bool checkPalindrome(string inputString)
        {
            char[] flpChars = inputString.ToCharArray();
            Array.Reverse(flpChars);
            string flpString = new string(flpChars);
            bool chkString = (inputString == flpString) ? true : false;
            return chkString;

        }

        static void Main(string[] args)
        {
            string inputString = "";
            Console.WriteLine("Please enter the string that you want to check");
            inputString = Console.ReadLine();
            Console.WriteLine(checkPalindrome(inputString));
            Console.ReadLine();
        }
    }
}
