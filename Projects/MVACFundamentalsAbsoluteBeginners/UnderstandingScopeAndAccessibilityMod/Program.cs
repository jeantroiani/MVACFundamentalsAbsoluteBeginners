using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingScopeAndAccessibilityMod
{
    class Program
    {
        private static string k = "";
        static void Main(string[] args)
        {
            string j = "";
            for (int i = 0; i < 10; i++)
            {
                j = i.ToString();
                k = i.ToString();
                Console.WriteLine(i);
                //This does not work because i lives inside the if statement
                //if (i == 9)
                //{
                //    string l = i.ToString();
                //}
                //Console.WriteLine("Value of l: {0}", l);
            }
            Console.WriteLine("Outside of the for loop: {0}", j);
            Console.WriteLine("k: {0}", k);
            helperMethod();

            Car myCar = new Car();

            myCar.DoSomething();
      
            Console.ReadLine();
        }

        static void helperMethod()
        {
            Console.WriteLine("k from the helperMethod: {0}", k);
        }
    }

    class Car
    {
        //public methods
        public void DoSomething()
        {
            Console.WriteLine(helperMethod());
        }

        //private methods
        private string helperMethod()
        {
            return "Hello World";
        }
    }
}
