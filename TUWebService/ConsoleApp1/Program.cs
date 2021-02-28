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
            Console.WriteLine(web.ReadPath("doyle.txt"));
            Console.ReadLine();

        }
    }
}
