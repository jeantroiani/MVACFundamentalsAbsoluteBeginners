using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectLifeTime
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.Make = "Misjdsalkd";

            Car mySecondCar = new Car("Fiat", "Uno", "red", 2012);
            Car myThirdCar = new Car
            {
                Make = "Ford",
                Year = 2000,
            };
            Console.WriteLine(mySecondCar.Make);
            Console.ReadLine();
        }
        class Car
        {
            public string Make { get; set; }
            public string Model { get; set; }
            public int Year { get; set; }
            public string Colour { get; set; }

            //default Make for every instance.
            //public Car() {
            //    this.Make = "Nissan";
            //}
            //or
            public Car (){ }
            public Car(string make, string model, string colour, int year) {
                Make = make;
                Model = model;
                Colour = colour;
                Year = year;
            }
        }
    }
}
