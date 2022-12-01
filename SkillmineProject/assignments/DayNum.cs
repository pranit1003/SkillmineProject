using System;
using System.Collections.Generic;
using System.Text;

namespace SkillmineProject.assignments
{
    class DayNum
    {
        public void Num()
        {
           int num;
            Console.WriteLine("Enter the num");
            num = int.Parse(Console.ReadLine());
            if (num == 1)
            {
                Console.WriteLine("Monday");
            }
            else if (num == 2)
            {
                Console.WriteLine("Tuseday");
            }
            else if (num == 3)
            {
                Console.WriteLine("Wedensday");
            }
            else if (num == 4)
            {
                Console.WriteLine("Thursday");
            }
            else if (num == 5)
            {
                Console.WriteLine("Friday");
            }
            else if (num == 6)
            {
                Console.WriteLine("Saturday");
            }
            else if (num == 7)
            {
                Console.WriteLine("Sunday");
            }
            else
            {
                Console.WriteLine("Invalid Day Number");
            }

        }
            static void Main(string[] args)
{
            DayNum d = new DayNum();
            d.Num();
}
    }
}
