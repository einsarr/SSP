using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ServerSideProcessing.Models;

namespace ServerSideProcessing.Controllers
{
    public class EtudiantController : Controller
    {
        DBEcoleEntities db = new DBEcoleEntities();
        // GET: Etudiant
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult GetList()
        {
            List<Etudiants> etudiants = new List<Etudiants>();
            etudiants = db.Etudiants.ToList();
            return Json(new { data = etudiants }, JsonRequestBehavior.AllowGet);
        }
    }
}