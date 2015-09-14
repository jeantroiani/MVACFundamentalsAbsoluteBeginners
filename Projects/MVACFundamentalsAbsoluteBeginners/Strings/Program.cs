using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //Substring
            string myString = "  Hello, how are you?  ";
            //myString = myString.Substring(7, 4);      //substitute
            myString = myString.ToUpper();              //Uppercase
            myString = myString.Replace(" ", "--");     //replace 
            myString = String.Format("Length before: {0} -- After: {1}", myString.Length, myString.Trim().Length);
            Console.WriteLine(myString);
            Console.ReadLine();
        }
    }
}
