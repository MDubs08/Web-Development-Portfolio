using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Portfolio.Controllers
{
    public class DesignController : Controller
    {
        // GET: Design
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult BlackjackTable()
        {
            return View();
        }
    }
}