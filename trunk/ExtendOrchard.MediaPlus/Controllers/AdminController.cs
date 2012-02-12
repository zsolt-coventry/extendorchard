using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Orchard.UI.Admin;

namespace ExtendOrchard.MediaPlus.Controllers
{
    [Admin]
    public class AdminController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
