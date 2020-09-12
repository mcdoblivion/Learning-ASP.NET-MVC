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
                var result = dao.Login(loginModel.UserName, Encryptor.MD5Hash(loginModel.Password));
                if (result == 1)
                {
                    var user = dao.GetByUserName(loginModel.UserName);
                    var userSession = new UserLogin();
                    userSession.UserName = user.UserName;
                    userSession.UserID = user.ID;
                    Session.Add(CommonConst.USER_SESSION, userSession);
                    return RedirectToAction("Index", "Home");
                }
                if (result == 0)
                {
                    ModelState.AddModelError("", "User name doesn't exist!");
                }
                if (result == -1)
                {
                    ModelState.AddModelError("", "Password isn't incorrect!");
                }
            }
            return View("Index");
        }
    }
}