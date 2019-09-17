using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace quit.Controllers
{
    public class BenefitController : Controller
    {
        // GET: Benefit
        public ActionResult BenefitsOfQuitting()
        {
            return View();
        }
    }
}