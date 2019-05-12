using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LevelOne
{
    class BinarySearch
    {
        /*Write a method that searches an Array of integers for a given integer using the 
        * Binary Search Algorithm. If the input integer is found in the array, return true. Otherwise, return false.
        * You can assume that the given array of integers is already sorted
        * in ascending order.
        * Examples:
        * binarySearch({2,5,7,8,9},9) -> true
        * binarySearch({2,8,9,12},6) -> false
        * binarySearch({2},4) -> false
        * binarySearch({},9) -> false*/

        public static bool Search(int[] numbers, int num)
        {
            int low = 0;
            int high = numbers.Length;
            while(low < high)
            {
                var mid = (low + high) / 2;
                if(numbers[mid] == num)
                {
                    return true;
                }
                if(numbers[mid] > num)
                {
                    high = mid - 1;
                }
                else
                {
                    low = mid + 1;
                }
            }
            return false;
        }
    }
}
