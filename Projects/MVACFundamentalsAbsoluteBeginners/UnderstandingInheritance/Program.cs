using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.Maker = "BMW";
            myCar.Colour = "Grey";
            myCar.Year = 2015;
            myCar.Model = "1 Series";

            //new instance of Truck
            Truck myTruck = new Truck();
            myTruck.Year = 2005;
            myTruck.Maker = "Ford";
            myTruck.Colour = "Cherry red";
            myTruck.Model = "f350";
            myTruck.TowingCapacity = 3;

            printCarDetails(myCar);
            printCarDetails(myTruck);
            Console.ReadLine();
        }


        private static void printCarDetails(Car car)
        {
            Console.WriteLine("Here are the Car's details: {0}",car.FormatMe());
        }


    }

    class Car
    {
        public string Maker { get; set; }
        public string Colour { get; set; }
        public int Year { get; set; }
        public string Model { get; set; }

        public string FormatMe()
        {
            return String.Format("{0} - {1} - {2} - {3}",
                this.Maker,
                this.Model,
                this.Year,
                this.Colour
                );
        }
    }

    class Truck : Car
    {
        public int TowingCapacity { get; set; }

    }
}
