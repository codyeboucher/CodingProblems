using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LevelOne
{
    class RepeatedArrayElements
    {
        /*Write a method duplicate to find the repeated or duplicate elements in an array. 
        * This method should return a list of repeated integers in a string with the elements sorted in ascending order 
        * (as illustrated below). 
        * duplicate({1,3,4,2,1}) --> "[1]"
        * duplicate({1,3,4,2,1,2,4}) --> "[1, 2, 4]"*/

        public static string Duplicate(int[] numbers)
        {
            var nums = new HashSet<int>();
            var duplicates = new SortedSet<int>();

            foreach (var num in numbers)
            {
                if(nums.Contains(num))
                {
                    duplicates.Add(num);
                }
                else
                {
                    nums.Add(num);
                }
            }
            return string.Join(" ", duplicates);
        }
    }
}
