using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank_Interview_Preperation.Warm_Up
{
    class SockMerchant
    {
        /* https://www.hackerrank.com/challenges/sock-merchant/problem
        * John works at a clothing store. He has a large pile of socks that he must pair by color for sale. 
        * Given an array of integers representing the color of each sock, determine how many pairs of socks with matching colors there are.
        * For example, there are n = 7 socks with colors ar = [1, 2, 1, 2, 1, 3, 2]. There is one pair of color 1 and one of color 2. 
        * There are three odd socks left, one of each color. The number of pairs is 2.
        * Function Description
        * Complete the sockMerchant function it must return an integer representing the number of matching pairs of socks that are available.
        * sockMerchant has the following parameter(s):
        * n: the number of socks in the pile, ar: the colors of each sock */


        //loop thorugh all the socks and use a set to store the sock numbers.
        //if number in the set matches the current number we know we have a pair so add to the total pairs and remove the sock from set.

        public static int SockMerchantCalc(int n , int[] ar)
        {
            var pairs = 0;
            var pairSet = new HashSet<int>();
            foreach (var num in ar)
            {
                if(!pairSet.Add(num))
                {
                    pairs++;
                    pairSet.Remove(num);
                }
                else
                {
                    pairSet.Add(num);
                }
            }
            return pairs;
        }

        //Use a dictionary to store the total number of each type of sock. 
        //Divide the total by 2 to the get the number of pairs and add to total pair count

        //public static int SockMerchantCalc(int n, int[] ar)
        //{
        //    var pairs = 0;
        //    var sockCount = new Dictionary<int, int>();

        //    foreach (var num in ar)
        //    {
        //        if(sockCount.ContainsKey(num))
        //        {
        //            sockCount[num]++;
        //        }
        //        else
        //        {
        //            sockCount.Add(num, 1);
        //        }
        //    }

        //    foreach (var sock in sockCount)
        //    {
        //        pairs += sock.Value / 2;
        //    }

        //    return pairs;
        //}
    }
}
