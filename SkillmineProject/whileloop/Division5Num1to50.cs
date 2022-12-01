using System;
using System.Collections.Generic;
using System.Text;

namespace SkillmineProject.whileloop
{
    class Division5Num1to50
    {

        static void Main(string[] args)
        {
            int sum = 0;
            int i = 1;
            while (i <= 50)
            {
               
                if (i % 5 == 0 )
                {
                    Console.WriteLine(i);
                    sum = sum + i;
                }
                i++;
            }
            Console.WriteLine("Sum is " + sum);
        }
    }
}
