using FirmaMitarbeiter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirmaMitarbeiter.Controllers
{
    public class FirmaController : Controller
    {
        private static MitarbeiterListeViewModel mitarbeiterListe = new MitarbeiterListeViewModel();

        public ActionResult Firma()
        {
            return View();
        }

        public ActionResult NeuerMitarbeiter()
        {
            return View(new MitarbeiterViewModel());
        }
        public ActionResult MitarbeiterListe()
        {
            return View("MitarbeiterListe", mitarbeiterListe);
        }
        public ActionResult MitarbeiterStatistik()
        {
            double totalWage = 0;
            foreach (var mitarbeiter in mitarbeiterListe.MitarbeiterListe) {
                totalWage += mitarbeiter.BruttoGehalt;
            }

            double averageWage = totalWage / mitarbeiterListe.MitarbeiterListe.Count;

            ViewBag.AverageWage = averageWage;
            return View();
        }

        [HttpPost]
        public ActionResult AddEmployee(MitarbeiterViewModel model)
        {
            mitarbeiterListe.MitarbeiterListe.Add(model);

            return View("MitarbeiterListe", mitarbeiterListe);
        }
    }
}