using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    public class Compression
    {
        //Type 1 : aabbbcccc => abc
        public string CompressionType_1(string str)
        {
            string s = str[0] +"";
            for(int i=1; i<str.Length; i++)
            {
                char curr = str[i];
                char prev = str[i-1];

                if(curr != prev)
                {
                    s+= curr;
                }
            }
            return s;
        }


        //Type 2 : aabbbccccd => a2b3c4d  - will not print the count if element count is 1 else it will print the no. 
        public string CompressionType_2(string str)
        {
            string s = str[0] + "";
            int count = 1;
            for(int i=1; i<=str.Length-1; i++)
            {
                char curr = str[i];
                char prev = str[i - 1];

                if(curr != prev)
                {
                    if (count > 1)
                    {
                        s += count;
                        count = 1;
                    }
                    s = s + curr;
                }
                else
                {
                   count++;
                }
                
            }
            if (count > 1)
            {
                s += count;
                count=1;
            }
            return s;
        }
    }
}
