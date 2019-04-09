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

        public ActionResult adminLogin()
        {
            Admin_Login adminModel = new Admin_Login();
            return View(adminModel);
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
                    return RedirectToAction("Index", "Home");  // Index is the Action name & Home is the Controller name
                }

            }
            
        }

        public ActionResult Autherize1(Student_Management_System__SMS_.Models.Admin_Login admin_model)
        {

            using (SMSEntities db = new SMSEntities())
            {
                var adminDetails = db.Admin_Login.Where(x => x.admin_ID == admin_model.admin_ID && x.password == admin_model.password).FirstOrDefault();

                if (adminDetails == null)
                {
                    admin_model.LoginErrorMassage1 = "Wrong ADMIN ID OR NAME !! PLEASE TRY AGAIN ...";
                    return View("adminLogin", admin_model);
                }

                else
                {
                    Session["admin_ID"] = adminDetails.admin_ID;
                     //return RedirectToAction("Admin", "Admin");
                     return Redirect("~/WebForm2.aspx");
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