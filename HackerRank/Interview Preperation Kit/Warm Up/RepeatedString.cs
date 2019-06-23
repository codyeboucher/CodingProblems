using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank_Interview_Preperation.Warm_Up
{
    class RepeatedString
    {
        /*https://www.hackerrank.com/challenges/repeated-string/problem
        * Lilah has a string, s, of lowercase English letters that she repeated infinitely many times.
        * Given an integer, n, find and print the number of letter a's in the first n letters of Lilah's infinite string.
        * For example, if the string s = 'abcac' and n = 10, 
        * the substring we consider is abcacabcac, the first 10 characters of her infinite string. 
        * There are 4 occurrences of a in the substring.
        * Function Description
        * Complete the repeatedString function in the editor below. 
        * It should return an integer representing the number of occurrences of a in the prefix of length n in the infinitely repeating string.
        * repeatedString has the following parameter(s):
        * s: a string to repeat
        * n: the number of characters to consider*/


        //Find the number of A's in the string s. 
        //Find how many times the whole string will be repeated and multiply by the number of A's in a complete string.
        //Check for any characters that wouldn't fit inside a complete string and iterate over them checking for A's and add to total.
        public static int RepeatedStringA(string s, int n)
        {
            var aCount = 0;

            foreach (var ch in s)
            {
                if(ch == 'a')
                {
                    aCount++;
                }
            }

            var result = aCount * (n / s.Length);

            for(int i = 0; i < n % s.Length; i++)
            {
                if(s[i] == 'a')
                {
                    result++;
                }
            }
            return result;
        }
    }
}
