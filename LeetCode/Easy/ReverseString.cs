using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Easy
{
    public class ReverseString
    {
        // https://leetcode.com/problems/reverse-string/
        //Do not allocate extra space for another array, 
        //you must do this by modifying the input array in-place with O(1) extra memory.


        //iterate through half of the array (so you don't swap and reswap
        //swap current element with end element minus current amount (and 1 so its not out of range)
        public static void ReverseAString(char[] s)
        {
            for(int i = 0; i < s.Length / 2; i++)
            {
                var temp = s[i];
                s[i] = s[s.Length - i - 1];
                s[s.Length - i - 1] = temp;
            }
        }
    }
}
