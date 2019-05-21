using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LevelTwo
{
    class BinaryRepresentation
    {
        /*Write a method to compute the binary representation of a positive integer. The method should return a string with 1s and 0s. 
        * computeBinary(6) ==> "110"
        * computeBinary(5) ==> "101"
        * Note: Use the minimum number of binary digits needed for the representation (Truncate unnecessary trailing 0s).
        * computeBinary(5) ==> "0101" (incorrect)
        * computeBinary(5) ==> "101" (correct)*/

        public static string ComputeBinary(int num)
        {
            var sb = new StringBuilder();

            if(num < 2)
            {
                return num.ToString();
            }

            while(num > 0)
            {
                sb.Insert(0, num % 2);
                num /= 2;
            }
            return sb.ToString();
        }
    }
}
