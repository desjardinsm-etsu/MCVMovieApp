using Microsoft.AspNetCore.Mvc;
using MVCMovie.Services;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        private readonly ISayHello _isay;
        private readonly SayHello _say;

        public HelloWorldController(ISayHello isay, SayHello say)
        {
            _isay = isay;
            _say = say;
        }
        // 
        // GET: /HelloWorld/

        public IActionResult Index()
        {

            //var sayHello = new MVCMovie.Services.SayHello();
            return Ok(_say.Number);
        }

        // GET: /HelloWorld/Welcome/ 
        // Requires using System.Text.Encodings.Web;
        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;

            return View();
        }

        // GET: /HelloWorld/Welcome/ 
        // Requires using System.Text.Encodings.Web;
        /*

        public string Welcome(string name, int numTimes = 1)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");
        }
        
        */
    }
}