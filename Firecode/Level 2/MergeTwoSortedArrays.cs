using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LevelTwo
{
    class MergeTwoSortedArrays
    {
        /*The idea behind the classic Mergesort algorithm is to divide an array in half, sort each half, and then use
        * a merge() method to merge the two halves into a single sorted array. 
        * Implement the merge() method that takes in 
        * two sorted arrays and returns a third sorted array that contains elements of both the input arrays. 
        * You can assume
        * that the input arrays will always be sorted in ascending order and can have different sizes.
        * Examples:
        * merge({2,5,7,8,9},{9}) -> {2,5,7,8,9,9}
        * merge()({7,8},{1,2}) -> {1,2,7,8}
        * merge()({2},{}) -> {2}
        * {} -> [Empty] Array*/

        public static int[] Merge(int[] left, int[] right)
        {
            var sortedArr = new int[left.Length + right.Length];
            var leftIndex = 0;
            var rightIndex = 0;
            var sortedCt = 0;

            //both arrays have elements
            while(leftIndex < left.Length && rightIndex < right.Length)
            {
                sortedArr[sortedCt++] = left[leftIndex] < right[rightIndex] ? left[leftIndex++] : right[rightIndex++];
            }

            //left has elements 
            while(leftIndex < left.Length)
            {
                sortedArr[sortedCt++] = left[leftIndex++];
            }

            //right has elements
            while(rightIndex < right.Length)
            {
                sortedArr[sortedCt++] = right[rightIndex++];
            }

            return sortedArr;
        }
    }
}
