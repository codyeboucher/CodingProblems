using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Easy
{
    public static class SingleNumber
    {
        //https://leetcode.com/problems/single-number/
        //Given a non-empty array of integers, every element appears twice except for one. Find that single one.


        //Sort array so duplicate elements are next to each other, if current number does not == number next to it
        //it is the solo number. Increment +2 so you jump to the next pair of numbers. If none is found that means,
        //last element is the odd one out so return it.
        public static int SoloNumber(int[] nums)
        {
            Array.Sort(nums);
            for (int i = 0; i < nums.Length - 2; i += 2)
            {
                if (nums[i] != nums[i + 1])
                {
                    return nums[i];
                }
            }
            return nums[nums.Length - 1];
        }

        //Use a set to store the nums, if the num is already in the set remove it else add it
        //(so the pairs are always removed), and return the only element left, the solo element 
        public static int SoloNumberHash(int[] nums)
        {
            var set = new HashSet<int>();
            foreach (var num in nums)
            {
                if(set.Contains(num))
                {
                    set.Remove(num);
                }
                else
                {
                    set.Add(num);
                }
            }
            return set.First();
        }
    }
}
