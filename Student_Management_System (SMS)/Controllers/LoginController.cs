using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Student_Management_System__SMS_.Models;

namespace Student_Management_System__SMS_.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login

        public ActionResult Login()
        {
            User_Login userModel = new User_Login();
            return View(userModel);
        }

        [HttpPost]
        public ActionResult Autherize(Student_Management_System__SMS_.Models.User_Login user_model)
        {

            using (SMSEntities db = new SMSEntities())
            {
                var userDetails = db.User_Login.Where(x => x.user_ID == user_model.user_ID && x.password == user_model.password).FirstOrDefault();

                if (userDetails == null)
                {
                    user_model.LoginErrorMassage = "Wrong USER ID OR PASSWORD !! PLEASE TRY AGAIN ...";
                    return View("Login", user_model);
                }

                else
                {
                    Session["user_ID"] = userDetails.user_ID;
                    return RedirectToAction("Index", "Home");
                }
            }
            
        }

        public ActionResult Logout()
        {
            Session.Abandon();
            return RedirectToAction("Login", "Login");
        }
    }
}