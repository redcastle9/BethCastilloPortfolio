using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net.Mail;
using BethCastilloPortfolio.Models;
using reCaptcha;
using System.Text;
using System.Configuration;
using System.Net;

namespace BethCastilloPortfolio.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.Title = "Beth Castillo";
            ViewBag.Recaptcha = ReCaptcha.GetHtml(ConfigurationManager.AppSettings["ReCaptcha:SiteKey"], theme: "blackglass");

            return View();
        }


        [HttpPost]
        public ActionResult Index(ContactModel c)
        {

            if (ModelState.IsValid && ReCaptcha.Validate(ConfigurationManager.AppSettings["ReCaptcha:SecretKey"]))
            {
                try
                {
                    MailMessage msg = new MailMessage();
                    SmtpClient smtp = new SmtpClient();
                    MailAddress from = new MailAddress(c.Email.ToString());
                    StringBuilder sb = new StringBuilder();
                    msg.To.Add("bethc@redcastle9.com");
                    msg.Subject = c.Subject;
                    msg.IsBodyHtml = false;
                    sb.Append("Name: " + c.Name);
                    sb.Append(Environment.NewLine);
                    sb.Append("Email: " + c.Email);
                    sb.Append(Environment.NewLine);
                    sb.Append(Environment.NewLine);
                    sb.Append("Comments: " + c.Message);
                    msg.Body = sb.ToString();
                    smtp.Send(msg);
                    msg.Dispose();
                    return View(c);
                }
                catch (Exception ex)
                {
                    string msg = ex.ToString();
                    return new HttpStatusCodeResult(HttpStatusCode.InternalServerError);
                }
            }
            return View(c);
        }
    }
}