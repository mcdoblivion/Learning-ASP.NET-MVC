using FirstWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstWebApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var message = new MessageModel();
            message.Welcome = "Welcome to my home page";
            return View(message);
        }
    }
}