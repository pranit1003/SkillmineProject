using System;
using System.Collections.Generic;
using System.Text;

namespace SkillmineProject.loopsexam
{
    class Division5And3
    {
        static void Main(string []args)
        {
            for (int i = 1 ; i<= 50; i++)
            {
                if (i%5 ==0 && i%3 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
