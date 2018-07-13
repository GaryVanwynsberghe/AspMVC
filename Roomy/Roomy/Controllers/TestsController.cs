using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Roomy.Controllers
{
    public class TestsController : Controller
    {
        // GET: Tests
        public ActionResult Index()
        {
            List<string> prenoms = new List<string>
            {
                "Gary","Antoine","Thomas"
            };
            return View(prenoms);
        }
    }
}