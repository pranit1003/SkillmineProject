using System;
using System.Collections.Generic;
using System.Text;

namespace SkillmineProject.assignments
{
    class Division3
    {
        public void Num()
        {
            int num1;
            Console.WriteLine("Enter the Number");
            num1 = int.Parse(Console.ReadLine());
            if (num1 % 3 == 0)
            {
                Console.WriteLine("Number is Divisible by 3");
            }
            else if (num1 % 9 == 0)
            {
                Console.WriteLine("Number is Divisible by 9");
            }
            else
            {
                Console.WriteLine("Number is not Divisible by 3  or 9");
            }
        }
        static void Main(string[] args)
        {
            Division3 d = new Division3();
            d.Num();
        }
    }
}
