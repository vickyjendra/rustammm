﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace rustammm.Controllers
{
    public class HomeController : Controller
    {
       

        public ActionResult Index()
        {
            if (Session["us_usrname"] == null)
            {
                return RedirectToAction("Login", "Account");
            }

            return View();
        }
    }
}