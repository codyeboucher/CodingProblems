using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LevelOne
{
    class Fibonacci
    {
        /*Write a recursive method fib(n) that returns the nth Fibonacci number. 
         * n is 0 indexed, which means that in the sequence 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, ..., 
         * n == 0 should return 0 and n == 3 should return 2. Assume n is less than 15.*/

        public static int RecFibonacci(int num)
        {
            if(num == 0)
            {
                return 0;
            }
            if(num == 1)
            {
                return 1;
            }
            return RecFibonacci(num - 1) + RecFibonacci(num - 2);
        }

        /*Your goal is to write an optimal method - betterFibonacci that returns the nth Fibonacci number in the sequence. 
        * n is 0 indexed, which means that in the sequence 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, ..., 
        * n == 0 should return 0 and n == 3 should return 2. 
        * Your method should exhibit a runtime complexity of O(n) and use constant O(1) space. 
        * With this implementation, your method should be able to compute larger sequences where n > 40.
        */

        public static int BetterFibonacci(int num)
        {
            if(num == 0)
            {
                return 0;
            }
            if(num == 1)
            {
                return 1;
            }
            var prev = 1;
            var curr = 1;
            var temp = 0;
            for (int i = 2; i < num; i++)
            {
                temp = prev + curr;
                prev = curr;
                curr = temp;
            }
            return temp;
        }
    }
}
