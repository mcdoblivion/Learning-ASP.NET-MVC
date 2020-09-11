using FirstWebApp.Areas.Admin.Model;
using FirstWebApp.Common;
using Model.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstWebApp.Areas.Admin.Controllers
{
    public class LoginController : Controller
    {
        // GET: Admin/Login
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login(LoginModel loginModel)
        {
            if (ModelState.IsValid)
            {
                var dao = new UserDao();
                var result = dao.Login(loginModel.UserName, loginModel.Password);
                if (result)
                {
                    var user = dao.GetByUserName(loginModel.UserName);
                    var userSession = new UserLogin();
                    userSession.UserName = user.UserName;
                    userSession.UserID = user.ID;
                    Session.Add(CommonConst.USER_SESSION, userSession);
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("", "User name or password is incorrect.");
                }
            }
            return View("Index");
        }
    }
}