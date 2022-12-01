using System;
using System.Collections.Generic;
using System.Text;

namespace SkillmineProject.whileloop
{
    class Sum1To10
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int i = 1;
            while (i <= 10)
            {
                i++;
                
                sum = sum + i;
            }
            Console.WriteLine("Sum of 10 number is " + sum);
        }
    }
}
