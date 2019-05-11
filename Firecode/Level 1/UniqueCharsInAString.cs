using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LevelOne
{
    class UniqueCharsInAString
    {
        /*Write a method that takes in an input String and returns true if all the characters in the String are unique and false if there is even a single repeated character.
        * The method should return true if the input is null or empty String.
        * Examples: 
        * areAllCharactersUnique("abcde") -> true
        * areAllCharactersUnique("aa") -> false */

        public static bool AreCharsUnique(string input)
        {
            if(string.IsNullOrEmpty(input) == true)
            {
                return true;
            }

            var uniqueChars = new HashSet<char>();

            foreach (var ch in input)
            {
                if(!uniqueChars.Add(ch))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
