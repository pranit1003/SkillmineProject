using System;
using System.Collections.Generic;
using System.Text;

namespace SkillmineProject.assignments
{
    class GreatestTernary
    {
       public void Num() 
        {
            int a, b, c;
            Console.WriteLine("Enter the num");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());

            int greatestNum = a > b && a > c ? a : b > a && b > c ? b : c;
            Console.WriteLine(greatestNum);

        }
        static void Main(string[] args)
        {
            GreatestTernary G = new GreatestTernary();
            G.Num();
        }

    }
}