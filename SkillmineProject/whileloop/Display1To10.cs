using System;
using System.Collections.Generic;
using System.Text;

namespace SkillmineProject.whileloop
{
    class Display1To10
    {
        static void Main(string[] args)
        {
            int i = 1;
            while ( i <= 10)
            {
                i++;
                Console.WriteLine(i);
            }          
        }
    }
    class Display120to200
    {
        static void Main(string[] args)
        {
            int i = 120;
            while (i <= 200)
            {
                i++;
                Console.WriteLine(i);
            }
        }
    }

    class Display75to61
    {
        static void Main(string[] args)
        {
            int i = 75;
            while (i >= 61)
            {
                i--;
                Console.WriteLine(i);
            }
        }
    }
}

