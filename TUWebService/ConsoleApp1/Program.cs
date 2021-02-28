using ConsoleApp1.ServiceReferenceForTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Services;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            WebService1SoapClient web = new WebService1SoapClient();
            string fileContent = "";
            string anotherFile = "";

            do
            {
                Console.WriteLine("Please choose txt-file to be printed: ");
                string filename = Console.ReadLine();
                
                fileContent = web.ReadPath(filename);
                Console.WriteLine("\n" + fileContent + "\n");

            } while (fileContent == "A file with the inserted filename above does not exist. Did you forget .txt?");

            

            do
            {
                Console.WriteLine("Do you want to read another txt-file?(Write yes/Yes) ");
                anotherFile = Console.ReadLine();

                if (anotherFile.Equals("Yes") || anotherFile.Equals("yes"))
                {
                    do
                    {
                        Console.WriteLine("Please choose txt-file to be printed: ");
                        string filename = Console.ReadLine();

                        fileContent = web.ReadPath(filename);
                        Console.WriteLine("\n" + fileContent + "\n");

                    } while (fileContent == "A file with the inserted filename above does not exist. Did you forget .txt?");
                }

            } while (anotherFile.Equals("Yes") || anotherFile.Equals("yes")); 
            

            Console.WriteLine("\n---END OF FILE READING---");
            Console.ReadLine();

        }
    }
}
