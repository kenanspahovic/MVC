using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Prodavnica.Controllers
{
    public class PrimjerController : Controller
    {
        // GET: Primjer
        public ActionResult Index()
        {
            return View();
        }
    }
}