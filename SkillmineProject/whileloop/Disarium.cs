using System;
using System.Collections.Generic;
using System.Text;

namespace SkillmineProject.whileloop
{
    class Disarium
    {
        static void Main(string[] args)
        {
            int num, temp, reminder , power=0;
            int sum = 0;
            int count = 1;

            Console.WriteLine("Enter the Number");
            num = int.Parse(Console.ReadLine());

            temp = num;

            while(temp != 0)
            {
                reminder = temp % 10;
                sum = sum * 10 + reminder;
                temp = temp / 10; 

            }
            temp = sum;
            sum = 0;

            while(temp !=0)
            {
                reminder = temp % 10;

                power = power * temp;
                sum = sum + power;
                temp = temp / 10;

                count++;
            }
            if (sum== num)
            {
                Console.WriteLine("given number is Disarium");
            }
            else
            {
                Console.WriteLine("Given number is not Disarium");
            }
        }
    }
}
