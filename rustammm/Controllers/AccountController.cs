using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using rustammm.Models;
using System.Security;
using System.Security.Cryptography;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
namespace rustammm.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        proddevEntities entity = new proddevEntities();
        public ActionResult Index()
        {
            if (Session["us_usrname"] != null)
            {

                return View();
            }
            else
            {
                return RedirectToAction("Login", "Account");
            }
         
        }
        public ActionResult Login()
        {
            if (Session["us_usrname"] != null)
            {
                Session["us_usrname"].ToString();
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View();
            }

        }
        [HttpPost]
        public ActionResult Login(LoginViewModel credentails)
        {

            string encrypt1 = encrypt.MD5Hash(credentails.us_pwd);
            bool userExist = entity.pd_user.Any(x => x.us_usrname == credentails.us_usrname && x.us_pwd == encrypt1);
            pd_user u = entity.pd_user.FirstOrDefault(x => x.us_usrname == credentails.us_usrname && x.us_pwd == encrypt1);

            if (userExist)
            {
                Session["us_usrname"] = u.us_usrname.ToString();
                FormsAuthentication.SetAuthCookie(u.us_usrname, false);

                return RedirectToAction("Index", "Home");
            }
            ModelState.AddModelError("", "udah ada");
            if (Session["us_usrname"] == null)
            {
                return RedirectToAction("Login", "Account");
            }
            return View();
        }
        public ActionResult SignOut()
        {
            Session.Abandon();
            return RedirectToAction("Login", "Account");
        }
    }
}