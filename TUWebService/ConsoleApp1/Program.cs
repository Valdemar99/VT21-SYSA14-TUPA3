using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Services;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            WebService1 proxy = new WebService1();
            string fileContent = "";
            string anotherFile = "";

            try
            {
                do
                {
                    do
                    {
                        Console.WriteLine("Please choose txt-file to be printed: ");
                        string filename = Console.ReadLine();

                        fileContent = proxy.ReadPath(filename);
                        Console.WriteLine("\n" + fileContent + "\n");

                    } while (fileContent == "A file with the inserted filename above does not exist. Did you forget .txt?");

                } while (fileContent == "Please type filename.");


                do
                {
                    Console.WriteLine("Do you want to read another txt-file?(Write yes/Yes) ");
                    anotherFile = Console.ReadLine();

                    if (anotherFile.Equals("Yes") || anotherFile.Equals("yes"))
                    {
                        do
                        {
                            do
                            {
                                Console.WriteLine("Please choose txt-file to be printed: ");
                                string filename = Console.ReadLine();

                                fileContent = proxy.ReadPath(filename);
                                Console.WriteLine("\n" + fileContent + "\n");
                            } while (fileContent == "A file with the inserted filename above does not exist. Did you forget .txt?");

                        } while (fileContent == "Please type filename.");

                    }

                } while (anotherFile.Equals("Yes") || anotherFile.Equals("yes"));

            }
            catch (WebException)
            {
                Console.WriteLine("\nPlease check your connection and try again.");
            }

            Console.WriteLine("\n---END OF FILE READING---");
            Console.ReadLine();

        }
    }
}
