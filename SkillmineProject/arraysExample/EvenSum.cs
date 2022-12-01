using System;
using System.Collections.Generic;
using System.Text;

namespace SkillmineProject.arraysExample
{
    class EvenSum
    {
        static void EvenSumNum(int[] arr, int n)
        {
            int even = 0;
           
            for (int i = 0; i < n; i++)
            {
                if (i % 2 == 0)
                    even += arr[i];
             
            }
            Console.WriteLine("Even index positions sum "
                              + even);
          
        }

        static public void Main()
        {

            // Code
            int[] arr = { 1, 2, 3, 4, 5, 6 };
            int n = arr.Length;

            EvenSumNum(arr, n);
        }
    }
}
