using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace quit.Controllers
{
    public class SurveyController : Controller
    {
        // GET: QuittingSupport
        public ActionResult Survey()
        {
            return View();
        }
    }
}