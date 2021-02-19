using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployedWindowsClient
{
    class DataAccessLayer
    {
        public string ReadFile(string fileName)
        {

            try
            {
                WebService1 proxy = new WebService1();
                return proxy.ReadPath(fileName);
            }
            catch (System.Web.Services.Protocols.SoapException ex)
            {
                return "";
            }
            
        }
    }
}
