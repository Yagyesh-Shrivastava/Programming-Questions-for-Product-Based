using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public class BuySellStock_Type1
    {
        public int maxProfit(int[] arr)
        {
            int maxProfit = 0;
            int minSoFar = arr[0];

            for(int i =0; i < arr.Length; i++)
            {
                minSoFar = Math.Min(minSoFar, arr[i]);
                int Profit = arr[i] - minSoFar;
                maxProfit = Math.Max(maxProfit, Profit);
            }

            return maxProfit;
        }
    }
}
