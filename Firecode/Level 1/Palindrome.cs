using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LevelOne
{
    class Palindrome
    {
        /*A palindrome is a string or sequence of characters that reads the same backward as forward. 
        * For example, "madam" is a palindrome. Write a method that takes in a String and returns a boolean -> true 
        * if the input String is a palindrome and false if it is not. 
        * An empty string and a null input are considered palindromes. 
        * You also need to account for the space character. For example, "race car" 
        * should return false as read backward it is "rac ecar".
        * Examples:
        * isStringPalindrome("madam") -> true
        * isStringPalindrome("aabb") -> false
        * isStringPalindrome("race car") -> false
        * isStringPalindrome("") -> true
        * isStringPalindrome(null) -> true*/

        public static bool IsStringPalindrome(string input)
        {
            if(string.IsNullOrEmpty(input))
            {
                return true;
            }

            var low = 0;
            var high = input.Length - 1;

            while(low < high)
            {
                if(input[low++] != input[high--])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
