using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace quit.Controllers
{
    public class QuittingSupportController : Controller
    {
        // GET: QuittingSupport
        public ActionResult QuittingSupport()
        {
            return View();
        }
        public ActionResult Medications()
        {
            return View();
        }
        public ActionResult NicotineReplacements()
        {
            return View();
        }
        public ActionResult OtherOptions()
        {
            return View();
        }
        public ActionResult SupportFromProfessionals()
        {
            return View();
        }

        public ActionResult QuittingSupportOptions()
        {
            return View();
        }
    }
}