using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LevelTwo
{
    class TransposeSquareMatrix
    {
        /*You are given a square 2D image matrix where each integer represents a pixel. 
        * Write a method transposeMatrix to transform the matrix into its Transpose - in-place. 
        * Example:Input image :
        * 1 0
        * 1 0 
        * Modified to :
        * 1 1
        * 0 0*/

        public static void TransposeMatrix(int[,] matrix)
        {
            var a = matrix.GetLength(0);
            var b = matrix.GetLength(1);

            for(int row = 0; row < a; row++)
            {
                for(int col = row + 1; col < b; col++)
                {
                    var temp = matrix[row, col];
                    matrix[row, col] = matrix[col, row];
                    matrix[col, row] = temp;
                }
            }
        }
    }
}
