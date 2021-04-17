﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TAO_Project.Models;

namespace TAO_Project.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Discounts discounts = new Discounts();
            discounts.FillList();
            ViewBag.Discounts = discounts;
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}