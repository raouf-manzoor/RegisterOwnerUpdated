using ContactManagementSystem26_10_17.RegisterOwnerDataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ContactManagementSystem26_10_17.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }
        [HttpGet]
        public ActionResult EmailVerification(int id)
        {
            RegistrationController regController = new RegistrationController();
            if (regController.VerifyEmail(id))
                return View("VerifiedSuccess");
            else
                return View("VerifiedError");

        }

        [HttpGet]
        public ActionResult ForgotPassword(int id)
        {
            var dbcontext = new RegisterOwnersContext();
            var user = dbcontext.Users.Single(e => e.Id == id);
            return View("ForgotPassword", user);

        }
        [HttpPost]
        public ActionResult ChangePassword(User input)
        {
            RegistrationController regController = new RegistrationController();
            if (regController.ChangePassword(input))
                return View("VerifiedSuccess");
            else
                return View("VerifiedError");

        }
    }
}
