using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace quit.Controllers
{
    public class CalculatorController : Controller
    {
        // GET: Calculator
        public ActionResult Calculator()
        {
            return View();
        }
    }
}