using System;
using System.Collections.Generic;
using System.Text;

namespace SkillmineProject.arraysExample
{
    class CountOdd
    {
        static void Main(string[] args)
        {
           
            int  odd = 0;
          
            int[] arr = new int[5];
            for (int i = 0; i < arr.Length; i++)
            {
                
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
       
           
            for (int i = 0; i < arr.Length ; i++)
            {
            
                if (arr[i] % 2 == 0)
                {
                    odd++;
                }
            }

            Console.Write("Total Odd numbers are " +odd);

            Console.ReadLine();
        }
    }
}
