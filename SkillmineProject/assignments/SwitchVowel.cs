﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SkillmineProject.assignments
{
    class SwitchVowel
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter alphabets");
            char ch;
            ch = Convert.ToChar(Console.ReadLine());

            switch (ch)
            {
                case 'A' : Console.WriteLine("Vowel");
                    break;
               
                case 'E': Console.WriteLine("Vowel");
                    break;

                case 'I': Console.WriteLine("Vowel");
                    break;

                case 'O': Console.WriteLine("Vowel");
                    break;

                case 'U': Console.WriteLine("Vowel");
                    break;

                default: Console.WriteLine("Consonant");
                    break;

            }



        }
    }
}
