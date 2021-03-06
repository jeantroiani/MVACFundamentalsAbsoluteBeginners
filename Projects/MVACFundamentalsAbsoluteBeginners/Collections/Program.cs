﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
                Car car1 = new Car();
                car1.Make = "Oldsmobile";
                car1.Model = "Cutlas Supreme";

                Car car2 = new Car();
                car2.Make = "Geo";
                car2.Model = "Prism";

                Book b1 = new Book();
                b1.Author = "Robert Tabor";
                b1.Title = "Microsoft .NET XML Web Services";
                b1.ISBN = "0-000-00000-0";

            //LIST
            List<Car> myList = new List<Car>();

            myList.Add(car1);
            myList.Add(car2);
            //myList.Add(b1);   List cannot hold anytoher type but Cars

            foreach (Car car in myList)
            {
                Console.WriteLine(car.Make);
            }

            //DICTIONARY
            Dictionary<string, Car> myDictionary = new Dictionary<string, Car>();
            myDictionary.Add(car1.Make, car1);
            myDictionary.Add(car2.Make, car2);
            Console.WriteLine(myDictionary["Geo"].Model);

            Console.ReadLine();
        }

        //Definition
        string[] names = { "Bob", "Steve", "Brian", "Chuck" };

            Car car3 = new Car() { Make = "Nissan", Model = "Altima" };
            Car car4 = new Car() { Make = "Fiat", Model = "Ritmo" };

            //Collection initializer

            List<Car> myList = new List<Car>()
            {
                new Car() { Make = "Nissan", Model = "Altima" },
                new Car() { Make = "Fiat", Model = "Ritmo" }
            };
        }

    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
    }

    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
    }
}
