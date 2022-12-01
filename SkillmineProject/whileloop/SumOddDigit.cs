using System;
using System.Collections.Generic;
using System.Text;

namespace SkillmineProject.whileloop
{
    class SumOddDigit
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int i = 1;
            while (i <= 20)
            {
               
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                    sum = sum + i;
                }
                i++;
            }
            Console.WriteLine("Sum of Odd number is " + sum);
        }
    }

}

