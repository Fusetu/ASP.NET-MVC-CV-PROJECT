using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mvc_Cv.Models.Entity;

namespace Mvc_Cv.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default

        db_CvEntities4 db = new db_CvEntities4();

        public ActionResult Index()
        {
            var values = db.about.ToList();
            return View(values);
        }

        public PartialViewResult Experince()
        {
            var experinces = db.experinces.ToList();
            return PartialView(experinces);
        }

        public PartialViewResult Education()
        {
            var educations = db.educations.ToList();
            return PartialView(educations);
        }

        public PartialViewResult Talent()
        {
            var talent = db.talents.ToList();
            return PartialView(talent);
        }

        public PartialViewResult Hobbies()
        {
            var hobbies = db.hobbies.ToList();
            return PartialView(hobbies);
        }

        public PartialViewResult Sertificates()
        {
            var certificates = db.certificates.ToList();
            return PartialView(certificates);
        }

        public PartialViewResult Communication()
        {
            var communication = db.communication.ToList();
            return PartialView(communication);
        }
    }
}