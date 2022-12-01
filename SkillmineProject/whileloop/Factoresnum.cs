using System;
using System.Collections.Generic;
using System.Text;

namespace SkillmineProject.whileloop
{
    class Factoresnum
    {
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("Enter the Number");
            number = int.Parse(Console.ReadLine());
            int i =1 ;
            while (i <= number)
            {
                
                if (number % i == 0)
                {
                    Console.WriteLine(i);
                }
                ++i;
            }
        }
    }
}
