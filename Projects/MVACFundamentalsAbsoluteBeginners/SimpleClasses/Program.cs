using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myNewCar = new Car();
            myNewCar.Make = "Chevrolet";
            myNewCar.Model = "Yukon";
            myNewCar.Year = 2004;
            myNewCar.Colour = "blue";

            //Console.WriteLine("{0} - {1} - {2} :$ {3}", myNewCar.Model, myNewCar.Make, myNewCar.Colour, determineMarketValue(myNewCar));
            Console.WriteLine("{0} - {1} - {2} :$ {3}", myNewCar.Model, myNewCar.Make, myNewCar.Colour, myNewCar.determinePrice());
            //double marketValueOfCar = determineMarketValue(myNewCar);
            Console.ReadLine();
        }
        //Helper method
        //private static double determineMarketValue(Car _car) {
        //    double carValue = 100.00;
        //    return carValue;
        //}
    }

    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Colour { get; set; }

        //Class method
        public double determinePrice()
        {
            double carValue = 100.00;
            if (this.Year > 1990)
            {
                carValue = 200.90;
            }
            else
            {
                carValue = 120.34;
            }
            return carValue;
        }
    }
}
