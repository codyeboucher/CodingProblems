using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LevelOne
{
    class NumberAppearsOnce
    {
        /*Write a method that returns a number that appears only once in an array.
        * Assume the array will surely have a unique value. The array will never be empty.
        * Examples:
        * {1,2,3,4,1,2,4,3,5} ==> 5*/

        public static int SoloNumber(int[] nums)
        {
            var result = 0;
            var numberCount = new Dictionary<int, int>();

            foreach (var num in nums)
            {
                if(numberCount.ContainsKey(num))
                {
                    numberCount[num]++;
                }
                else
                {
                    numberCount.Add(num, 1);
                }
            }

            foreach (var num in nums)
            {
                if(numberCount[num] == 1)
                {
                    result = num;
                    break;
                }
            }
            return result;
        }
    }
}
