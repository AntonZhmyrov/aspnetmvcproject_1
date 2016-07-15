using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AspNetMvcDi_1.Interfaces;

namespace AspNetMvcDi_1.Controllers
{
    public class HomeController : Controller
    {
	    private IAccountManager _manager;

	    public HomeController(IAccountManager manager)
	    {
		    _manager = manager;
	    }

        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

		[HttpGet]
	    public JsonResult GetAccounts(int skip, int amount)
	    {
		    return Json(_manager.NextAccounts(skip, amount), JsonRequestBehavior.AllowGet);
	    }
    }
}