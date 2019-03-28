    using Microsoft.AspNetCore.Mvc;
    namespace firstcsharp_web.Controllers     //be sure to use your own project's namespace!
    {
        public class HelloController : Controller   //remember inheritance??
        {
            //for each route this controller is to handle:
            [HttpGet]       //type of request
            [Route("")]     //associated route string (exclude the leading /)
            public string Index()
            {
                return "(( INDEX ))";
            }

            [HttpGet]
            [Route("projects")]
            public string getList()
            {
                return "(( LIST OF PROJECTS ))";
            }

            [HttpGet]
            [Route("contact")]
            public string getOne()
            {
                return "(( CONTACT ))";
            }



            // Other code
            [HttpGet]
            [Route("template/{name}")]
            public JsonResult Method1(string name)
            {
                // Method body
                return null;
            }

            [HttpGet]
            [Route("template/{id}/{action}")]
            public JsonResult Method2(int id, string action)
            {
                // Method body
                return null;
            }

        }
    }
