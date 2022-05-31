using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public class RotateArray
    {
        public void rotate(int[][] matrix)
        {
            //Step 1: Rotating the col and rows of matrix or transpose a matrix
            for(int i=0; i<matrix.Length; i++)
            {
                for(int j=i; j<matrix[0].Length; j++)
                {
                    int temp = 0;
                    temp = matrix[i][j];
                    matrix[i][j] = matrix[j][i];
                    matrix[j][i] = temp;
                }
            }

            //Step 2: reverse the rows and column of the matrix with 2 pointer approach
            for(int i=0; i<matrix.Length; i++)
            {
                for( int j=0; j<matrix.Length/2; j++)
                {
                    int temp = 0;
                    temp = matrix[i][j];
                    matrix[i][j] = matrix[i][matrix.Length - 1 - j];
                    matrix[i][matrix.Length - 1 - j] = temp;
                }
            }

            //Step 3: Printing the elements
        //    Console.WriteLine("Rotated Array: ");
        //    for(int i =0; i<m; i++)
        //    {
        //        for(int j=0; i<n; j++)
        //        {
        //            Console.WriteLine(matrix[i,j] + " ");
        //        }
        //        Console.WriteLine();
        //    }
        }
    }
}
