using EmployedWindowsClient.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace EmployedWindowsClient
{
    class DataAccessLayer
    {
        public string ReadFile(string fileName)
        {
            WebService1SoapClient proxy = new WebService1SoapClient();
            string fileContent = "";
            try
            {
                fileContent = proxy.ReadPath(fileName);

            }catch (EndpointNotFoundException) {
                fileContent = "Check your connection and try again.";
            }

            return fileContent;
        }
    }
}
