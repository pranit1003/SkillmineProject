using System;
using System.Collections.Generic;
using System.Text;

namespace SkillmineProject.arraysExample
{
    class MinValue
    {
        public static void Main()
        {
            int[] arr = new int[5] { 99, 95, 93, 89, 87 };
            int i, min, n;
            // size of the array
            n = 5;

            min = arr[0];
            for (i = 1; i < n; i++)
            {

                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }

            Console.Write("Minimum element = {0} ", min);
        }
    }
}

