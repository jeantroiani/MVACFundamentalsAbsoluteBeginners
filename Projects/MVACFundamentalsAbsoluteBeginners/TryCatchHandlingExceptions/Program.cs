using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchHandlingExceptions
{
    class Program
    {
        static void Main(string[] args)
        {

            StreamReader myReader = new StreamReader("Values1.txt");

            try {
                //opens the file

                string line = "";

                while (line != null)
                {
                    //reads one line at a time.
                    line = myReader.ReadLine();
                    if (line != null)
                    {
                        Console.WriteLine(line);
                    }
                   
                }

         

            }
            catch(DirectoryNotFoundException e)
            {
                Console.WriteLine("Could't find the file");
            }
            catch(FileNotFoundException e)
            {
                Console.WriteLine("Couldn't fund this file");
            }
            catch(Exception e)
            {
                Console.WriteLine("Something didn't quite work correctly: {0}", e.Message);
            }
            finally
            {
                //perform cleanups, close conenctions or roll back the data.
                myReader.Close();
            }
            Console.ReadLine();
        }
    }
}
