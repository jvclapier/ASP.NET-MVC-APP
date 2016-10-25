using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net.Mail;
using BlowOut.Models;
using System.Text;

namespace BlowOut.Controllers
{
    public class ContactController : Controller
    {

        public string Index()
        {
            
            return "Please call Support at <b><u>801-555-1212.</u></b> Thank you!";
        }

        public string Email(string name, string email)
        {
            return "Thank you " + name + ". We will send an email to " + email + ".com";
      
        }

        public ActionResult EmailRequest()
        {
            return View();
        }

        public ActionResult ProcessRequest()
        {
            return View();
        }

        public ActionResult Contact()
        {
    }
}