using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _作業_Demo_MaxContinuousValue____21謝孟勳
{
    //陣列裡只會有 0, 3, 找出連續3 最大的總和
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] items = { 0, 3, 3, 0, 0, 3, 3, 3 };
            int maxSummary = 0; 

            int sum = 0; 

            for (int i = 0; i < items.Length; i++)
            {
                int item = items[i]; 
                if (item == 0)
                {
                    sum = 0; 
                    continue; 
                }

                sum += item; 
                if (sum > maxSummary) 
                {
                    maxSummary = sum;
                }
            }

            Console.WriteLine(maxSummary);
        }
    }
}
