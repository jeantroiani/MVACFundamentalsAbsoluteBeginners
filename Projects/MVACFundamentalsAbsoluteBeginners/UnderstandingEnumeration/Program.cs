using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingEnumeration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("hello world");

            //SuperHero myValue = SuperHero.Batman;

            Console.WriteLine("Type in a superhero's name to see his nickname: ");
            string userValue = Console.ReadLine();

            SuperHero myValue;

            // < > is a generic, userValue: user input, true: ignore or not capitalization, out: sends out from the method to the caller, to be use in switch.
            if (Enum.TryParse<SuperHero>(userValue, true, out myValue))
            {
                switch (myValue)
                {
                    case SuperHero.Batman:
                        Console.WriteLine("Caped Crusader");
                        break;
                    case SuperHero.Superman:
                        Console.WriteLine("man of Steel");
                        break;
                    case SuperHero.GreenLantern:
                        Console.WriteLine("Emerald knight");
                        break;
                    default:
                        break;
                }
            }
            else
            {
                Console.WriteLine("Does not computed");
            }
            Console.ReadLine();
        }
    }

    enum SuperHero
    {
        Batman,
        Superman,
        GreenLantern
    }
}
