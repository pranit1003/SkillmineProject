﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SkillmineProject.assignments.patternType
{
    class Pattern6
    {
        static void Main(string[] args)
        {

            for (int i = 1; i <= 4 ; i++)
            {
                for (int j = i; j <= 3; j++)
                {
                    Console.Write(" ");
                }
               for( int k = 1 ; k<=i; k++ )
                {
                    Console.Write(" * ");
                }
                for (int l = 2 ; l <= i; l++)
                {
                    Console.Write(" * ");
                }
                Console.WriteLine();
            }

        }
    }
}
