using Roomy.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Roomy.Controllers
{
    
    public class SharedController : Controller
    {
        private RoomyGaryDbContext db = new RoomyGaryDbContext();
        // GET: Shared
        [ChildActionOnly]
        public ActionResult TopFive()
        {
            var rooms = db.Rooms.OrderByDescending(x => x.Price).Take(5);
            return View("_TopFive", rooms);
        }
    }
}