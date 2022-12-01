using System;
using System.Collections.Generic;
using System.Text;

namespace SkillmineProject.whileloop
{
    class SumlessThan10
    {
        static void Main(string[]args)
        {
            int i = 0;
            int sum = 0;
            while(i<=20)
            {
                sum = sum + i;
                if (sum>10)
                {
                    break;
                }
                i++;
            }
            Console.WriteLine(sum);
        }
    }
}
