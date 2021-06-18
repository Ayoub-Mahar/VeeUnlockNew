using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VeeUnlock.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
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
        public ActionResult Blog()
        {
            return View();
        }
        public ActionResult Carrier()
        {
            return View();
        }
        public ActionResult Payment()
        {
            return View();
        }
        public ActionResult Payment1()
        {
            return View();
        }
        public ActionResult PaymentSuccessfull()
        {
            return View();
        }
        public ActionResult PhoneCheck()
        {
            return View();
        }
        public ActionResult Tracking()
        {
            return View();
        }
        public ActionResult UnlockPhone()
        {
            return View();
        }
        public ActionResult UnlockingService()
        {
            return View();
        }
        public ActionResult RefundPolicy()
        {
            return View();
        }
        public ActionResult PrivacyPolicy()
        {
            return View();
        }
        public ActionResult TermsAndConditions()
        {
            return View();
        }
        public ActionResult AdminDashboard()
        {
            return View();
        }
        public ActionResult AdminForms()
        {
            return View();
        }
        public ActionResult AdminTables()
        {
            return View();
        }
    }
}