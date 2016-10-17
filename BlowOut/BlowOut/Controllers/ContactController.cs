using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlowOut.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        public string Index()
        {
            
            return "Please call Support at <b><u>801-555-1212.</u></b> Thank you!";
        }

        public ActionResult Email(string name, string email)
        {
            return View();
        }

        public ActionResult Contact()
        {

            return View();
        }
    }
}