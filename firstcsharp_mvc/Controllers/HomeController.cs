using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using firstcsharp_mvc.Models;

namespace firstcsharp_mvc.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }



        public IActionResult ViewModelFunIndex()
        {
            ViewData["Message"] = "Message here: from HomeController.cs .. imagine this is 4 liens of garbage";
            string str = "This is a string that is being passed to an @model in the view from the controller.";
            return View(str);
        }
        public IActionResult ViewModelFunNumbers()
        {
            ViewData["Message"] = "Message here ...";
            int[] ints = new int[] { 99, 98, 92, 97, 95}; 
            return View(ints);
        }
        public IActionResult ViewModelFunUsers()
        {
            ViewData["Message"] = "Message here ...";

            // string[] names = new string[]
            // {
            //     "Sally", "Billy", "Joey", "Moose"
            // };

            List<UserModel> users = new List<UserModel>
            {
                new UserModel(){ Name = "Andy", Email="email@gmail.com" },
                new UserModel(){ Name = "Bob", Email="email@gmail.com" },
                new UserModel(){ Name = "Craig", Email="email@gmail.com" },
                new UserModel(){ Name = "Dave", Email="email@gmail.com" },
                new UserModel(){ Name = "Evan", Email="email@gmail.com" },
                new UserModel(){ Name = "Fergusson", Email="email@gmail.com" },
                new UserModel(){ Name = "Gorgonzola", Email="email@gmail.com" },
                new UserModel(){ Name = "Hank", Email="email@gmail.com" },
                new UserModel(){ Name = "Igor", Email="email@gmail.com" },
            };

            return View(users);
        }
        public IActionResult ViewModelFunUser()
        {
            ViewData["Message"] = "Message here ...";

            UserModel user = new UserModel()
            {
                Name = "Devon Newsome",
                Email = "Newsom",
            };
            // Here we pass this instance to our View
            return View(user);
        }



        public IActionResult WizardRegForm()	// updated
        {
            // use the debugger to inspect this HogwartsStudent instance!
            Console.WriteLine("Show New Student Form");
            return View();
        } 

        // other code ...
        [HttpPost("register")]
        public IActionResult RegisterWizard(HogwartsStudentModel student)	// updated
        {
            // use the debugger to inspect this HogwartsStudent instance!
            Console.WriteLine("Got Student");
            return View("ShowWizard", student);
        } 


        public IActionResult NewUser()	// updated
        {
            // use the debugger to inspect this HogwartsStudent instance!
            Console.WriteLine("Show New User Form");
            return View();
        } 

        [HttpPost("usermodel/create")]
        public IActionResult Create(UserModel user)
        {
            if(ModelState.IsValid)
            {
                // do something!  maybe insert into db?  then we will redirect

                return RedirectToAction("ShowUser");
            }
            else
            {
                // Oh no!  We need to return a ViewResponse to preserve the ModelState, and the errors it now contains!
                return View("NewUser");
            }
        }

        public IActionResult ShowUser()
        {
            ViewData["Message"] = "HEY NOW! Message here ...";
            string str = "SUCCESS!!!";

            // Here we pass this instance to our View
            return View("ShowUser", str);
        }








        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
