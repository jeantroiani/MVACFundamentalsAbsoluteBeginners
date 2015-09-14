using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateAndTime
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime timeNow = DateTime.Now;
            //Console.WriteLine(timeNow.ToString());
            //Console.WriteLine(timeNow.ToOADate());
            //Console.WriteLine(timeNow.AddDays(3).ToLongDateString());
            //Console.WriteLine(timeNow.AddDays(-3).ToLongDateString()); //substract days
            //Console.ReadLine();
            //DateTime myBirthday = new DateTime(1981, 07, 11);
            //Console.WriteLine(myBirthday);
            DateTime myBirthday = DateTime.Parse("1981/11/07");
            TimeSpan myAge = DateTime.Now.Subtract(myBirthday);
            Console.WriteLine(myAge.TotalDays);
            Console.ReadLine();
        }
    }
}
