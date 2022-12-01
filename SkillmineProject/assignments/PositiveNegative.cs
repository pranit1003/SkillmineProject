using System;
using System.Collections.Generic;
using System.Text;

namespace SkillmineProject.assignments
{
    class PositiveNegative
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter the Number");
            num = int.Parse(Console.ReadLine());

            if(num>0)
            {
                Console.WriteLine("Given Number is Positive");
            }
            else if(num<0)
            {
                Console.WriteLine("Given Number Is Negative");
            }
            else
            {
                Console.WriteLine("Given Number Is Zero");
            }
            
        }
    }
}
