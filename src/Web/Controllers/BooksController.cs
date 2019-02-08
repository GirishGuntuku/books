using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    public class BooksController : Controller
    {
        public IActionResult Books()
        {
            return View();
        }

        public IActionResult Bview()
        {
            return View();
        }

        

        public IActionResult JSON()
        {
            return Json(new
            {
                apptype = ".NET Core",
                appname = "MVC"
            });
        }

        public IActionResult HTML()
        {
            return Content("<!DOCTYPE html><html><body>Hello World</body></html>", "text/html");
        }

        public IActionResult Greeting()
        {
            return Content("Hello!");
        }

    }
}