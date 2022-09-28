using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using rustammm.Models;
using System.Data;
namespace rustammm.Controllers
{
    public class CalendarController : Controller
    {
        // GET: Calendar
        public proddevEntities mee = new proddevEntities();
        public ActionResult Index()
        {
            if (Session["us_usrname"] == null)
            {
                return RedirectToAction("Login", "Account");
            }
            return View();
        }
        public ActionResult findAll()
        {
            return Json(mee.pd_schedule.Select(e => new
            {
                title = e.sch_task,
                url = e.sch_projnum,
                start = e.sch_date.Value.ToString()
            }).ToList(), JsonRequestBehavior.AllowGet);
        }
    }
}