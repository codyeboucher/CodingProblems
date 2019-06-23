using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank_Interview_Preperation.Warm_Up
{
    class CountingValleys
    {
        /*https://www.hackerrank.com/challenges/counting-valleys/problem
         * Gary is an avid hiker. He tracks his hikes meticulously, paying close attention to small details like topography. 
         * During his last hike he took exactly  steps. For every step he took, he noted if it was an uphill, U, or a downhill, D step. 
         * Gary's hikes start and end at sea level and each step up or down represents a  unit change in altitude. 
         * We define the following terms:
         * A mountain is a sequence of consecutive steps above sea level, starting with a step up from sea level and ending with a step down to sea level.
         * A valley is a sequence of consecutive steps below sea level, starting with a step down from sea level and ending with a step up to sea level.
         * Given Gary's sequence of up and down steps during his last hike, find and print the number of valleys he walked through.
         * For example, if Gary's path is s = [DDUUUUDD, he first enters a valley 2 units deep. 
         *  Then he climbs out an up onto a mountain 2 units high. Finally, he returns to sea level and ends his hike.
         * Function Description
         * Complete the countingValleys function below. It must return an integer that denotes the number of valleys Gary traversed.
         * countingValleys has the following parameter(s):
         * n: the number of steps Gary takes
         * s: a string describing his path*/
        
        
        //We've reached a valley if we go below sea level, 0, and back to it.
        //Iterate through the string and track the height moving up or down 1 for each character
        //If we move up check if we've reached 0 or sea level, if yes we went through a valley so increase count.
        public static int ValleyCount(int n, string s)
        {
            var valleys = 0;
            var height = 0;
            foreach (var ch in s)
            {
                if(ch == 'U')
                {
                    height++;
                    if(height == 0)
                    {
                        valleys++;
                    }
                }
                else
                {
                    height--;
                }
            }
            return valleys;
        }
    }
}
