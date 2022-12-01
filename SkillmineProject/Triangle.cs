using System;
using System.Collections.Generic;
using System.Text;

namespace SkillmineProject
{
    class Triangle
    {
        static void Main(string[] args)
        {
            int x1, x2;
            Console.WriteLine("Enter the value of base");
           x1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the value of height");
            x2 = int.Parse(Console.ReadLine());

            Console.WriteLine(0.5 * x1 * x2);
        }
    }
}
