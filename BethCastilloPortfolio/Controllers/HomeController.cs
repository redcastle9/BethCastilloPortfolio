using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net.Mail;
using BethCastilloPortfolio.Models;

namespace BethCastilloPortfolio.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Top()
        {
            return View();
        }

        public ActionResult Work()
        {
            return View();
        }

        public ActionResult Portfolio()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Contact(ContactModel c)
        {
            if (ModelState.IsValid)
            {

            }
            return View();
        }
    }
}