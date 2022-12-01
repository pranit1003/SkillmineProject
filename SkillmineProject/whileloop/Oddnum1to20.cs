using System;
using System.Collections.Generic;
using System.Text;

namespace SkillmineProject.whileloop
{
    class Oddnum1to20
    {
        static void Main(string[] args)
        {
            int i = 1;
            while (i <= 20)
            {
                
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
                i++;
            }
        }
    }
}
