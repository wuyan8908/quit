using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace quit.Controllers
{
    public class SurveyController : Controller
    {
        // GET: Survey
        public ActionResult Survey()
        {
            return View();
        }
        public ActionResult Addiction()
        {
            return View();
        }
        public ActionResult CalmNegativeEmotions()
        {
            return View();
        }

        public ActionResult Habit()
        {
            return View();
        }
        public ActionResult Indulgence()
        {
            return View();
        }
        public ActionResult SensorimotorStimulation()
        {
            return View();
        }
        public ActionResult SocialSmoking()
        {
            return View();
        }
    }
}