using System;
using System.Collections.Generic;
using System.Text;

namespace SkillmineProject.whileloop
{
    class DigitSum
    {
        static void Main(string[]args )
        {
            Console.WriteLine("Enter the Number");
            int num = int.Parse(Console.ReadLine());
            int sum = 0;

            while(num >0)
            {
                int digit = num % 10;
                sum = sum + digit;
                num = num / 10;
            }
            Console.WriteLine("sum of digits = " + sum);
        }
    }
}
