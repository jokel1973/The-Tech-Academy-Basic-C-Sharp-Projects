using NewsLetterApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NewsLetterApp.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            using (Models.NewsletterEntities db = new Models.NewsletterEntities())
            {
                var signups = db.SignUps;
                var signupVms = new List<SignupVm>();
                foreach (var signup in signups)
                {

                    var signupVm = new SignupVm();
                    signupVm.Id = signup.Id;
                    signupVm.FirstName = signup.FirstName;
                    signupVm.LastName = signup.LastName;
                    signupVm.EmailAddress = signup.EmailAddress;
                    signupVms.Add(signupVm);

                }

                return View(signupVms);
            }
        }
    }
}