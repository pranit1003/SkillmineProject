using System;
using System.Collections.Generic;
using System.Text;

namespace SkillmineProject.loopsexam
{
    class FactorsNum
    {
        static void Main(string [] args)
        {
            int number;
            Console.WriteLine("Enter the Number");
            number = int.Parse(Console.ReadLine());

            for (int i =1; i<= number; ++i)
            {
                if(number % i ==0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
