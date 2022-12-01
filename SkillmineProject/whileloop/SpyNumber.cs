using System;
using System.Collections.Generic;
using System.Text;

namespace SkillmineProject.whileloop
{
    class SpyNumber
    {
        public static void Main(String[] args)
        {
            int num ;
            int product = 1;
            int sum = 0;
            int lastdigit;
           Console.WriteLine("Enter the number to check: ");
           num = int.Parse(Console.ReadLine());
         
            while (num > 0)
            {
                lastdigit = num % 10;
                sum = sum + lastdigit;
                product = product * lastdigit;
                num = num / 10;
            }
           
            if (sum == product)
                Console.WriteLine("The given number is a spy number.");
           else
                Console.WriteLine("The given number is not a spy number.");
        }
    }
}
