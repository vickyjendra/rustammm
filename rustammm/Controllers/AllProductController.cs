using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using rustammm.Models;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Dynamic;
using System.IO;
using Microsoft.Ajax.Utilities;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using System.Web.UI;
using System.Web.Helpers;
using System.Net.Mail;
namespace rustammm.Controllers
{
    public class AllProductController : Controller
    {
        // GET: AllProduct
        proddevEntities entity = new proddevEntities();
        public ActionResult AllProductt()
        {
			List<AllProduct> jc = new List<AllProduct>();
			string mainconn = ConfigurationManager.ConnectionStrings["Koneksi"].ConnectionString;
			SqlConnection sqlconn = new SqlConnection(mainconn);
			string query = "SELECT DISTINCT pd_projnum, pd_asstnum, pd_toynum, pd_toydesc, sch_date, count(MTL_toolnum) as 'TotalTool' " +
				"FROM pd_MECTL JOIN pd_alltoy ON MTL_toynum = pd_toynum JOIN pd_schedule ON pd_projnum = sch_projnum " +
				"WHERE sch_attr = 'TL' AND MTL_actTS IS NULL " +
				"GROUP BY pd_projnum, pd_asstnum, pd_toynum, pd_toydesc, sch_date" +
				" ORDER BY sch_date";
			
			SqlCommand sqlcomm = new SqlCommand(query, sqlconn);
			SqlDataAdapter sda = new SqlDataAdapter(sqlcomm);
			DataTable dt = new DataTable();
			sda.Fill(dt);
			foreach (DataRow dr in dt.Rows)
			{
				AllProduct allProduct = new AllProduct();
				allProduct.pd_projnum = dr["pd_projnum"].ToString();
				allProduct.pd_toynum = dr["pd_toynum"].ToString();
				allProduct.pd_asstnum = dr["pd_asstnum"].ToString();
				allProduct.pd_toydesc = dr["pd_toydesc"].ToString();
				allProduct.sch_date = (DateTime)dr["sch_date"];
				allProduct.TotalTool = dr["TotalTool"].ToString();
				jc.Add(allProduct);
			}

			if (Session["us_usrname"] == null)
			{
				return RedirectToAction("Login", "Account");
			}
			return View(jc);
        }
        public ActionResult Detail()
        {

            return View();
        }
		[HttpGet]
		public ActionResult Detail(detailallproduct detailallproductt, FormCollection form, string Subject)
		{
			if (Session["us_usrname"] == null)
			{
				return RedirectToAction("Login", "Account");
			}
			var toynum = Request.QueryString["pd_toynum"];
			var projnum = Request.QueryString["pd_projnum"];
			return View();
		}
	}
}