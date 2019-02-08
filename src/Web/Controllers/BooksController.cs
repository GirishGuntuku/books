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

    }
}