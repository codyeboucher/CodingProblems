using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LevelTwo
{
    class CoupleSum
    {
        /*Given an array of integers, find two numbers such that they sum up to a specific target.
        * The method coupleSum should return the indices of the two numbers in the array, where index1 must be less than index2. 
        * Please note that the indices are not zero based, and you can assume that each input has exactly one solution. 
        * Target linear runtime and space complexity.
        * Example:
        * Input Array : {2, 3, 4, 7}  
        * Target      : 7
        * Output      : {2, 3}*/

        public static int[] FindPair(int[] nums, int target)
        {
            var targetPair = new Dictionary<int, int>();
            for(int i = 0; i < nums.Length; i++)
            {
                if(targetPair.ContainsKey(nums[i]))
                {
                    return new int[] { targetPair[nums[i]], i + 1 };
                }
                else
                {
                    targetPair.Add(target - nums[i], i + 1);
                }
            }
            return null;
        }
    }
}
