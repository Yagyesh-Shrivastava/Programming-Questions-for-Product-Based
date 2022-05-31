using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public class BuySellStock_Type2
    {
        public int maxProfit(int[] arr)
        {
            int profit = 0;
            for(int i = 0; i < arr.Length-1; i++)
            {
                if(arr[i] < arr[i+1])
                {
                    profit += (arr[i + 1] - arr[i]);
                }
            }
            return profit;
        }
    }
}
