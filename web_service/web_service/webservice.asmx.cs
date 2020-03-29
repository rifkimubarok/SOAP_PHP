using System;
using System.Web;
using System.Web.Services;

namespace web_service
{
    [WebService(Namespace = "webservice")]
    public class webservice : System.Web.Services.WebService
    {
        [WebMethod]
        public string helloWorld()
        {
            return "Hello World!";
        }

        [WebMethod]
        public int Tambah(int a, int b)
        {
            return a + b;
        }

        [WebMethod]
        public int Kurang(int a, int b)
        {
            return a - b;
        }

        [WebMethod]
        public int kali(int a, int b)
        {
            return a * b;
        }

        [WebMethod]
        public double bagi(double a, double b)
        {
            return a / b;
        }
    }
}
