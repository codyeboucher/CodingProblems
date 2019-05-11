using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LevelOne
{
    class FirstNonDuplicateChar
    {
        /*Find the first non-duplicate character in a string. Return null if no unique character is found. 
        * firstNonRepeatedCharacter( "abcdcd" ) --> 'a'
        * firstNonRepeatedCharacter( "cbcd" ) --> 'b'
        * firstNonRepeatedCharacter( "cdcd" ) --> null */

        public static char? FirstNonDupChar(string input)
        {
            var charCount = new Dictionary<char, int>();
            foreach (var ch in input)
            {
                if(charCount.ContainsKey(ch))
                {
                    charCount[ch]++;
                }
                else
                {
                    charCount.Add(ch, 1);
                }
            }

            foreach (var ch in input)
            {
                if(charCount[ch] == 1)
                {
                    return ch;
                }
            }
            return null;
        }
    }
}
