using System;
using System.Collections.Generic;
using System.Text;

namespace SkillmineProject.assignments
{
    class Division5
    {
       public void Num()
        {
            int num1;
            Console.WriteLine("Enter the Number");
            num1 = int.Parse(Console.ReadLine());
            if (num1%5==0)
            {
                Console.WriteLine("Number is Divisible by 5");
            }
            else
            {
                Console.WriteLine("Number is not Divisible by 5");
            }
        }
        static void Main(string[] args)
        {
            Division5 d = new Division5();
            d.Num();
        }
    }
}
