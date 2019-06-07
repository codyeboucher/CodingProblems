using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LevelTwo
{
    class PowerOfTwo
    {
        /*Write a method - isPowOfTwo to test whether or not a given positive integer is a power of 2. 
        * Your method should run in constant O(1) time and use O(1) space.
        * Examples: 
        * isPowOfTwo(5) ==> false
        * isPowOfTwo(8) ==> true*/

        public static bool IsPowerOfTwo(int num)
        {
            return (num != 0) && (num & (num - 1)) == 0;
        }
    }
}
