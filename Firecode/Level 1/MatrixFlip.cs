using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LevelOne
{
    class MatrixFlip
    {
        /*You are given an m x n 2D image matrix where each integer represents a pixel. Flip it in-place along its vertical axis.
        * Example:
        * Input image :  
        *    1 0
        *    1 0 
        * Modified to :   
        *    0 1
        *    0 1*/

        public static void VerticalFlip(int[,] matrix)
        {
            var a = matrix.GetLength(0);
            var b = matrix.GetLength(1);

            for(int row = 0; row < a; row++)
            {
                for(int col = 0; col < b / 2; col++)
                {
                    var temp = matrix[row, col];
                    matrix[row, col] = matrix[row, b - col - 1];
                    matrix[row, b - col - 1] = temp;
                }
            }
        }

        /*You are given an m x n 2D image matrix where each integer represents a pixel. Flip it in-place along its horizontal axis.
        * Example:
        * Input image :  
        *   1 1
        *   0 0 
        * Modified to :   
        *   0 0
        *   1 1*/

        public static void HorizontalFlip(int[,] matrix)
        {
            var a = matrix.GetLength(0);
            var b = matrix.GetLength(1);

            for(int row = 0; row < a / 2; row++)
            {
                for(int col = 0; col < b; col++)
                {
                    var temp = matrix[row, col];
                    matrix[row, col] = matrix[a - row - 1, col];
                    matrix[a - row - 1, col] = temp;
                }
            }
        }
    }
}
