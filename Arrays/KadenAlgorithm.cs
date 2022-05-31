using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Problem: Largest SubArray Sum
 * Input: [-3, -4, 5, -1, 2, -4, 6, -1]
 * Output: 8 
 * Explanation: Subarray [5, -1, 2, -4, 6] is the max sum contiguous subarray with sum 8.
 * 
 * This Algorithm will need to modify if all elements are negative, works best for + and - numbers
 * Time Complexity : O(n)
 */
namespace Arrays
{
    public class KadenAlgorithm
    {
        public int maxSumArray(int[] arr)
        {
            int maxSum = 0;
            int currentSum = 0;

            for(int i=0; i<arr.Length; i++)
            {
                currentSum = currentSum + arr[i];
                
                //for positve number
                while(currentSum > maxSum)
                {
                    maxSum = currentSum;
                }

                //for negative number it will drop that part
                while(currentSum < 0)
                {
                    currentSum = 0;
                }
            }

            return maxSum;
        }
    }
}
