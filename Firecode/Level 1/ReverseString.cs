using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LevelOne
{
    class ReverseString
    {
        /* Write a method that takes in a String and returns the reversed version of the String.
        * Examples:
        * reverseString("abcde") -> "edcba"
        * reverseString("1") -> "1"
        * reverseString("") -> ""
        * reverse("madam") -> "madam"
        * reverse(null) -> null */

        //check if null / empty string or single char and returns 
        //loops through starting at last character and appends to stringbuilder
        public static string Reverse(string input)
        {
            if (input == null)
            {
                return null;
            }
            if (input.Length <= 1)
            {
                return input;
            }
            var sb = new StringBuilder();
            for(int i = input.Length-1; i >= 0; i--)
            {
                sb.Append(input[i]);
            }
            return sb.ToString();
        }
    }
}
