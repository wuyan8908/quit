using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace quit.Controllers
{
    public class MedicationsController : Controller
    {
        // GET: QuittingSupport
        public ActionResult Medications()
        {
            return View();
        }
    }
}