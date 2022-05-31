using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    public class Exam
    {
        public string Codility1(string str)
        {
            string s = str[0] + "";
            int count = 1;
            for (int i = 1; i <= str.Length - 1; i++)
            {
                char curr = str[i];
                char prev = str[i - 1];

                if (curr == prev)
                {
                    count++;
                    s += curr;
                }
                

            }
            if (count != 2)
            {
                Console.WriteLine("No element is found");
            }


            return s;
        }
    }
}
