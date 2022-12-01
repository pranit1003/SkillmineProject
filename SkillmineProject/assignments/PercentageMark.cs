using System;
using System.Collections.Generic;
using System.Text;

namespace SkillmineProject.assignments
{
    class PercentageMark
    {
        static void Main(string[]args)
        {
            int english, maths, history, hindi, science;
            Console.WriteLine("Enter the marks of English");
            english = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the marks of Maths");
            maths = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the marks of History");
            history = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the marks of Hindi");
            hindi = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the marks of Science");
            science = int.Parse(Console.ReadLine());

            int percentage = ((english + maths + history + hindi + science) * 100) / 500;
            
            if(percentage>70)
            {
                Console.WriteLine("Distinction");
            }
            else if(percentage<70 && percentage>60)
            {
                Console.WriteLine("First Class");
            }
            else if (percentage < 60 && percentage > 50)
            {
                Console.WriteLine("Second Class");
            }
            else if (percentage < 50 && percentage > 35)
            {
                Console.WriteLine(" Pass ");
            }
            else
            {
                Console.WriteLine(" Fail ");
            }


        }
    }
}
