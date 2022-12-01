using System;
using System.Collections.Generic;
using System.Text;

namespace SkillmineProject.whileloop
{
    class Division5and3
    {
        static void Main(string[] args)
        {
            int i=1;
            while (  i <= 50)
            {
                i++;
                if (i % 5 == 0 && i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

    }
}
