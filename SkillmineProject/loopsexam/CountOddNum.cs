using System;
using System.Collections.Generic;
using System.Text;

namespace SkillmineProject.loopsexam
{
    class CountOddNum
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int i;
            for ( i = 1; i<=20; i++)
            {
                if(i%2 != 0)
                {
                    Console.WriteLine(i);
                    
                }
                
            }
            sum = sum + i;
        }
    }
}
