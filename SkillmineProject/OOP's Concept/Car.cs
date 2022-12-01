using System;
using System.Collections.Generic;
using System.Text;

namespace SkillmineProject.OOP_s_Concept
{
    class Car
    {
        int CarModelNum;
        string CarName;
        int CarPrize;
        string CarColour;

        public void AcceptDetails(int CarModelNum, string CarName,  int CarPrize ,string CarColour)
        {
            this.CarModelNum = CarModelNum;
            this.CarName = CarName;
           this.CarPrize = CarPrize;
            this.CarColour = CarColour;
        }
        public void Display()
        {
            Console.WriteLine("Car Model is " + CarModelNum);
            Console.WriteLine("Car Name is " + CarName);
            Console.WriteLine("Car Price is " + CarPrize);
            Console.WriteLine("Car Colour is " + CarColour);
           
        }
        static void Main(string[] args)
        {
            Car c = new Car();
            c.AcceptDetails(2012, "Audi", 510000, "Black");
            c.Display();

            Car c1 = new Car();
            c1.AcceptDetails(2015, "BMW", 500000, "White");
            c1.Display();

            Car c2 = new Car();
            c2.AcceptDetails(2019, "Mercedez", 710000, "Silver");
            c2.Display();
        }
    }
}
