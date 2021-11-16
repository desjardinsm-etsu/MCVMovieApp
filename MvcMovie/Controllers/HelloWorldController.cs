using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // 
        // GET: /HelloWorld/

        List<string> list = new List<string>();

        
        public IActionResult Index()
        {
            ViewData["Names"] = list;
            return View();
        }

        public IActionResult Seed()
        {

            list.Add("Mathew");
            list.Add("Suzy");
            list.Add("Ryan");
            list.Add("Michael");
            list.Add("Emily");
            list.Add("Melissa");
            list.Add("Brad");

            return Redirect("/helloworld");
        }



        // GET: /HelloWorld/Welcome/ 
        // Requires using System.Text.Encodings.Web;
        public IActionResult Welcome(string name, int id = 1)
        {
            //get data from the data base....
            //
            // return HtmlEncoder.Default.Encode($"Hello {name}, ID: {id}");

           


            return Redirect("/helloworld");

        }

        //GET
        public IActionResult CreateWelcome()
        {
            return View();
        }

        public IActionResult Delete(string name)
        {
            //do whateever you need to do to delete
            list.Remove(name);
            return Redirect("/helloworld");

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