using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCBasics.Controllers
{
    public class CountriesController : Controller
    {
        // GET: Countries
        public ActionResult Index()
        {
            ViewBag.listCountries =  
                new List<string>()
                    {
                        "India",
                        "Australia",
                        "Canada",
                        "USA",
                        "United Kingdom"
                    };
            return View();
        }
    }
}