using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Services;


namespace TUWebService
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {
        [WebMethod]
        public string ReadPath(string fileName)
        {
            string text = "";

            try
            {
                text = File.ReadAllText(@"C:\inetpub\wwwroot\" + fileName);
            }
            catch (FileNotFoundException)
            {
                text = "A file with the inserted filename above does not exist. Did you forget .txt?";
            }
            catch (DriveNotFoundException)
            {
                text = "Check connection and try again.";
            }
            catch (DirectoryNotFoundException)
            {
                text = "Please type filename.";
            }

            return text;
        }

    }
}
