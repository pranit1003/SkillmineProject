using System;
using System.Collections.Generic;
using System.Text;

namespace SkillmineProject.assignments
{
    class OddEven
    {
        static void Main(string[] args)
        {


            int num;
            Console.WriteLine("Enter the Number");
            num = int.Parse(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine("Number is even");

            }
            else
            {
                Console.WriteLine("Number is Odd");
            }
        }

    }
}
