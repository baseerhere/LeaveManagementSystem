using LeaveManagementSystem.Models.Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;


namespace LeaveManagementSystem.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(Register register)
        {

            return View();
        }


        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(Login login)
        {
            if (ModelState.IsValid)
            {
                if (IsUserExist(login.EmailAddress, login.Password))
                {
                    //ViewBag.UserName = login.EmailAddress;
                    //FormsAuthentication.RedirectFromLoginPage(login.EmailAddress, false);
                    Session["UserName"] = login.EmailAddress;
                    FormsAuthentication.SetAuthCookie(login.EmailAddress, false);

                    //var authTicket = new FormsAuthenticationTicket(1, login.EmailAddress, DateTime.Now, DateTime.Now.AddMinutes(20), false, login.Role);
                    //string encryptedTicket = FormsAuthentication.Encrypt(authTicket);
                    //var authCookie = new HttpCookie(FormsAuthentication.FormsCookieName, encryptedTicket);
                    //HttpContext.Response.Cookies.Add(authCookie);
                    return RedirectToAction("AfterLogin");
                }
                else
                {
                    ModelState.AddModelError("", "Email or Password Incorrect.");
                }
            }
            return View(login);
        }


        //Function to validate user exists or not with the given credentials
        public bool IsUserExist(string emailid, string password)
        {
            bool flag = false;
            //DB code to validate
            if (emailid == "Farooq@test.com" && password == "Pwd@123")
            {
                flag = true;
            }
            return flag;
        }

        //Function to navigate to the next screen after successful login
        [Authorize]
        public ActionResult AfterLogin()
        {
            return View();
        }

        public ActionResult ForgotPassword()
        {
            return View();
        }
    }
}