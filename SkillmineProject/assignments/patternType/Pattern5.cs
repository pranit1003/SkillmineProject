using System;
using System.Collections.Generic;
using System.Text;

namespace SkillmineProject.assignments.patternType
{
    class Pattern5
    {
        static void Main(string[] args)
        {

            for (int i = 1; i <= 5; i++)
            {
                for (int j = i; j <= 5 ; j++ )
                {
                    Console.Write(" * ");
                }
                Console.WriteLine();
            }

        }
    }
}
