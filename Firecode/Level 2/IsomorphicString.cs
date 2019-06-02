using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LevelTwo
{
    class IsomorphicString
    {
        /*Given two strings - input1 and input2, determine if they are isomorphic. 
        * Two strings are isomorphic if the letters in one string can be remapped to get the second string. 
        * Remapping a letter means replacing all occurrences of it with another letter. 
        * The ordering of the letters remains unchanged.
        * Input 1 : css  
        * Input 2 : dll
        * Output  : true
        * 
        * Input 1 : css 
        * Input 2 : dle
        * Output  : false*/

        public static bool IsIsomorphic(string input1, string input2)
        {
            if(input1.Length != input2.Length)
            {
                return false;
            }

            var firstMapping = new Dictionary<char, char>();
            var secMapping = new Dictionary<char, char>();

            for(int i = 0; i < input1.Length; i++) 
            {
                var char1 = input1[i];
                var char2 = input2[i];
                
                if(firstMapping.ContainsKey(char1))
                {
                    if(firstMapping[char1] != char2)
                    {
                        return false;
                    }
                }
                else if(secMapping.ContainsKey(char2))
                {
                    return false;
                }
                else
                {
                    firstMapping.Add(char1, char2);
                    secMapping.Add(char2, char1);
                }
            }
            return true;
        }

    }
}
