using System;
using System.Collections.Generic;
using System.Text;

namespace SkillmineProject.arraysExample
{
    class FindEvenArray
    {
        public void EvenArray(int[]a)
        {
            Console.WriteLine("Even Array is ");
            int count = 0;
            for(int i = 0; i< a.Length; i++)
            {
                if(a[i] % 2 == 0)
                {
                    count++;
                }
            }
            int[] even = new int[count];
            int j = 0;
            for( int i = 0; i<a.Length; i++)
            {
                if(a[i] %2 == 0)
                {
                    even[j] = a[i];
                    j++;
                }
            }
            for(int i = 0; i<even.Length; i++)
            {
                Console.WriteLine(even[i] + " ");
            }
        }
    }
}
