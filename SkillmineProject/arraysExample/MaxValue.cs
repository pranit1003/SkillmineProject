using System;
using System.Collections.Generic;
using System.Text;

namespace SkillmineProject.arraysExample
{
    class MaxValue
    {
        public static void Main()
        {
            int[] arr = new int[5] { 99, 95, 93, 89, 87 };
            int i, max, min, n;
            // size of the array
            n = 5;
            max = arr[0];
           
            for (i = 1; i < n; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
               
            }
            Console.Write("Maximum element = {0} "+ max);
      
         }
    }
}

