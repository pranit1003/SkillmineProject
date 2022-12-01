using System;
using System.Collections.Generic;
using System.Text;

namespace SkillmineProject.whileloop
{
    class Oddnum
    {
        static void Main(string[] args)
        {
            int i = 120;
            while ( i >= 81)
            {
                
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
                i--;
            }
        }
    }

}
