using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TAO_Project.Models;

namespace TAO_Project.Controllers
{
    public class CalculationController : Controller
    {
        // GET: Calculation
        public ActionResult Index()
        {
            Discounts discounts = new Discounts();
            discounts.FillList();
            ViewBag.Discounts = discounts;
            return View();
        }
    }
}