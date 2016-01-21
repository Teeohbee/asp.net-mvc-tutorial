using System.Web.Mvc;
using System.Web;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: /HelloWorld/ 
        public string Index()
        {
            return "This is my default action...";
        }
        // GET: /HelloWorld/Welcome/ 
        public string Welcome(string name, int ID = 1)
        {
            return HttpUtility.HtmlEncode(
                "Hello " + name + ", ID: " + ID);
        }
    }
}