using System;
using System.Collections.Generic;
using System.Text;

namespace SkillmineProject.assignments
{
    class LearYear
    {
        static void Main(string[] args)
        {
            int year;
            Console.WriteLine("Enter the Number");
            year = int.Parse(Console.ReadLine());

            if (year %4 ==0)
            {
                Console.WriteLine("Given year is Leap year");
            }
            else
            {
                Console.WriteLine("Given year is not Leap year");
            }
        }
    }
}
