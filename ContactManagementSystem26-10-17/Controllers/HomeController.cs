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
    }
}
