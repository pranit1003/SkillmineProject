using System;
using System.Collections.Generic;
using System.Text;

namespace SkillmineProject.whileloop
{
    class Tablenum
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter the Table Number");
            num = int.Parse(Console.ReadLine());
            int i = 1;
            while ( i <= 10)
            {
               
                Console.WriteLine(num * i);
                i++;
            }

        }
    }
}

