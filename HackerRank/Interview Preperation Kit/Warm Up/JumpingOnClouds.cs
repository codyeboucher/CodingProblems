using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank_Interview_Preperation.Warm_Up
{
    class JumpingOnClouds
    {
        /*https://www.hackerrank.com/challenges/jumping-on-the-clouds/problem
         *Emma is playing a new mobile game that starts with consecutively numbered clouds. 
         * Some of the clouds are thunderheads and others are cumulus. 
         * She can jump on any cumulus cloud having a number that is equal to the number of the current cloud plus 1 or 2. 
         * She must avoid the thunderheads. 
         * Determine the minimum number of jumps it will take Emma to jump from her starting postion to the last cloud. 
         * It is always possible to win the game.
         *For each game, Emma will get an array of clouds numbered 0 if they are safe or 1 if they must be avoided. 
         * For example, c = [0,1,0,0,0,1,0] indexed from 0...6. 
         * The number on each cloud is its index in the list so she must avoid the clouds at indexes 1 and 5. 
         * She could follow the following two paths: 0->2->4->6 or 0->2->3->4->6 . 
         * The first path takes 3 jumps while the second takes 4.
         *Function Description
         *Complete the jumpingOnClouds function in the editor below. It should return the minimum number of jumps required, as an integer.
         *jumpingOnClouds has the following parameter(s):
         *c: an array of binary integers */

        //Since it is always possible to win the game we just loop through the array and check if we can move forward 2 spaces,
        //checking if 2 spaces forward is within the array bounds and is 0.
        //if yes increment i by 1 (i will always increment by 1 in loop moving us forward 2 places) and increment jumps by 1;
        //Since there is always a solution we can always move forward and jump 1;
        public static int CloudJump(int[] c)
        {
            var jumps = 0;
            for (int i = 0; i < c.Length - 1; i++)
            {
                if (i + 2 < c.Length && c[i + 2] == 0)
                {
                    i++;
                }
                jumps++;
            }
            return jumps;
        }
    }
}
