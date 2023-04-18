using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        //GET: /HelloWorld/
        public string Index()
        {
            return "This is my default action...";
        }
        //
        //GET: /HelloWorld/Welcome/
        //要求 using System.Text.Encodings.Web;
        public string Welcome(string name,int ID = 1)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, ID :{ID}");
        }
    }
}
