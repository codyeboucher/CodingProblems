using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LevelOne
{
    class MissingNumber
    {
        /*Given an Array containing 9 numbers ranging from 1 to 10, write a method to find the missing number. 
        * Assume you have 9 numbers between 1 to 10 and only one number is missing.
        * findMissingNumber({1,2,4,5,6,7,8,9,10}) --> 3*/

        public static int FindMissingNum(int[] nums)
        {
            var total = 55;
            foreach (var num in nums)
            {
                total -= num;
            }
            return total;
        }
    }
}
