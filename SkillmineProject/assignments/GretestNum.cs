using System;
using System.Collections.Generic;
using System.Text;

namespace SkillmineProject.assignments
{
    class GretestNum
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Enter the num 1");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the num 2");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the num 3");
            c = int.Parse(Console.ReadLine());

            if (a > b && a > c)
            {
                Console.WriteLine("num 1 is greatest");
            }
            else if (b > a && b > c)
            {
                Console.WriteLine("num 2 is greatest");
            }
            else
            {
                Console.WriteLine("num 3 is greatest");
            }
        }
    }
}
