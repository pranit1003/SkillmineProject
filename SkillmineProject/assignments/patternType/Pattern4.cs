using System;
using System.Collections.Generic;
using System.Text;

namespace SkillmineProject.assignments.patternType
{
    class Pattern4
    {
        static void Main(string[] args)
        {

            for (int i = 1; i <= 4; i++)
            {
                for (int j = 4; j >= 1; j--)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }

        }
    }
}
