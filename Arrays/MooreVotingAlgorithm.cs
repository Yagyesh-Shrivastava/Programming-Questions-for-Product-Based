using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public class MooreVotingAlgorithm
    {
        //Step 1: Find the candidate which might be the maximum in array
        
        public int majorityElement(int[] arr)
        {
            int count = 1;
            int res = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                if(arr[i] == arr[res])
                {
                    count++;
                }
                else
                {
                    count--;
                }

                if (count == 0)
                {
                    count = 1;
                    res = i;
                }
            }

            //Step 2: Find the frequency of the candidate found. if It is greater than N/2 or not. 
            count = 0;
            for(int i=0; i < arr.Length; i++)
            {
                if(arr[res] == arr[i])
                {
                    count++;
                }
            }
            if(count < arr.Length/2)
            {
                Console.WriteLine("No element is majority");
            }
            return arr[res];
        }
    }
}
