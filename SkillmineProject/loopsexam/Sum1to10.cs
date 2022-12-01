using System;
using System.Collections.Generic;
using System.Text;

namespace SkillmineProject.loopsexam
{
    class Sum1to10
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for ( int i =1;i<= 10; i++)
            {
                sum = sum + i;
            }
            Console.WriteLine("Sum of 10 number is " + sum);
        }
    }
}
