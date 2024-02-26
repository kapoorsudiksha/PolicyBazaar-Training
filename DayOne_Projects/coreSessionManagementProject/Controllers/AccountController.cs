﻿using Microsoft.AspNetCore.Mvc;

namespace coreSessionManagementProject.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string username, string password)
        {
            if(username != null && password != null)
            {
                if(username.Equals("bhawna") && password.Equals("gunwani"))
                {
                    HttpContext.Session.SetString("uname", username);
                    /*return View("Welcome");*/
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ViewBag.Error = "Please Enter Valid Credentials.";
                }
            }
            else
            {
                ViewBag.Error = "Please Enter Your Credentials.";
            }
            return View("Index");
        }

        public IActionResult Logout()
        {
            /*HttpContext.Session.Clear();*/
            HttpContext.Session.Remove("uname");
            return RedirectToAction("Index");
        }
    }
}
