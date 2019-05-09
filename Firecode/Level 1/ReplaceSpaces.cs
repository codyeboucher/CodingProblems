using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LevelOne
{
    class ReplaceSpaces
    {
        /* Write a method to replace all spaces in a string with a given replacement string. 
        * replace("This is a test","/") --> "This/is/a/test"
        * Note: Avoid using the in-built String.Replace() method. */

        public static string Replace(string input, string replacement)
        {
            var sb = new StringBuilder();

            for(int i = 0; i < input.Length; i++)
            {
                if (input[i] != ' ')
                {
                    sb.Append(input[i]);
                }
                else
                {
                    sb.Append(replacement);
                }
            }
            return sb.ToString();
        }
    }
}
