using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    public class FizzBuzz
    {
        //https://leetcode.com/problems/fizz-buzz/
        //Write a program that outputs the string representation of numbers from 1 to n.

        //But for multiples of three it should output “Fizz” instead of the number 
        //and for the multiples of five output “Buzz”. For numbers which are multiples of 
        //both three and five output “FizzBuzz”.

        public static IList<string> FizzBuzzz(int n)
        {
            var result = new List<string>();
            for(int i = 1; i <= n; i++)
            {
                if(i % 3 == 0 && i % 5 == 0)
                {
                    result.Add("FizzBuzz");
                }
                else if(i % 3 == 0)
                {
                    result.Add("Fizz");
                }
                else if(i % 5 == 0)
                {
                    result.Add("Buzz");
                }
                else
                {
                    result.Add(i.ToString());
                }
            }
            return result;
        }
    }
}
