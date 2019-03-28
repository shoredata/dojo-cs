using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace firstcsharp_web.Controllers     //be sure to use your own project's namespace!
{
    public class HelloController : Controller   //remember inheritance??
    {
        string stringResults = "";

        //for each route this controller is to handle:
        [HttpGet]       //type of request
        [Route("")]     //associated route string (exclude the leading /)
        public IActionResult getIndex()
        {
            // return View();
            //OR
            // ViewBag.Example = "Hello World!";
            return View("Index");
            //Both of these returns will render the same view (You only need one!)
        }

        [HttpGet]
        [Route("projects")]
        public IActionResult getProjects()
        {
            // return "(( LIST OF PROJECTS ))";
            return View("Projects");
        }

        [HttpGet]
        [Route("contact")]
        public IActionResult getContact()
        {
            // return "(( CONTACT ))";
            return View("Contact");
        }


        [HttpGet]
        [Route("razor")]
        public IActionResult getRazor()
        {
            return View("Razor");
        }

        [HttpGet]
        [Route("datetime")]
        public IActionResult getDateTime()
        {
            return View("DateTime");
        }


        [HttpPost]
        [Route("survey/add")]
        public IActionResult addSurvey(string name, string location, string language, string comment)
        {
            // Do something with form input
            this.stringResults = "Name: " + name + " <br> Location: " + location + " <br> Language: " + language + "<br> Comment: " + comment;
            Console.WriteLine("A: " + this.stringResults);

            ViewBag.Survey = this.stringResults;
            // Console.WriteLine("B: " + stringResults);
            // return View("SurveyResult");

            return RedirectToAction("showSurvey");
        }
        [HttpGet]
        [Route("survey/show")]
        public IActionResult showSurvey()
        {
            Console.WriteLine("B: " + ViewBag.Survey);
            Console.WriteLine("C: " + this.stringResults);
            ViewBag.Survey = "kajfhadksjfhadskjfhd";
            return View("SurveyResult");
        }



        [HttpGet]
        [Route("survey")]
        public IActionResult getSurvey()
        {
            return View("Survey");
        }




        // // Other code
        // [HttpGet]
        // [Route("other/meeeee")]
        // public IActionResult Method()
        // {
        //     // The anonymous object consists of keys and values
        //     // The keys should match the parameter names of the method being redirected to
        //     return RedirectToAction("OtherMethod", new { Food = "sandwiches", Quantity = 5 });
        // }
        
        // [HttpGet]
        // [Route("other/{Food}/{Quantity}")]
        // public IActionResult OtherMethod(string Food, int Quantity)
        // {
        //     Console.WriteLine($"I ate {Quantity} {Food}.");
        //     // Writes "I ate 5 sandwiches."
        //     return View();
        // }



        // // Other code
        // public class FirstController : Controller
        // {
        //     public IActionResult Method()
        //     {
        //         return RedirectToAction("OtherMethod", "Second");
        //     }
        // }
        
        // // In another file
        // public class SecondController : Controller
        // {
        //     public IActionResult OtherMethod()
        //     {
        //         return View();
        //     }
        // }





        // // Other code
        // [HttpGet]
        // [Route("template/{name}")]
        // public JsonResult Method1(string name)
        // {
        //     // Method body
        //     return null;
        // }

        // [HttpGet]
        // [Route("template/{id}/{action}")]
        // public JsonResult Method2(int id, string action)
        // {
        //     // Method body
        //     return null;
        // }

    }
}

