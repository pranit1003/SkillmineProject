using System;
using System.Collections.Generic;
using System.Text;

namespace SkillmineProject.loopsexam
{
    class TableNum
    {
        static void Main(string [] args)
        {
            int num;
            Console.WriteLine("Enter the Table Number");
            num = int.Parse(Console.ReadLine());

            for (int i = 1; i<=10; i++)
            {
                Console.WriteLine(num * i);
            }
           
        }
    }
}
