using Aplikacija.Database;
using Aplikacija.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Aplikacija.Controllers
{
    public class AdminController : Controller
    {
        public GenericUnitOfWork genericUnitOfWork = new GenericUnitOfWork();
        // GET: Admin
        public ActionResult Dashboard()
        {
            return View();
        }
        public ActionResult Vozila()
        {
            return View(genericUnitOfWork.GetRepositoryInstance<Vozilo>().GetProduct());
        }
        public ActionResult EditVozila(int productId)
        {
            return View(genericUnitOfWork.GetRepositoryInstance<Vozilo>().GetFirstorDefault(productId));
        }
        [HttpPost]
        public ActionResult EditVozila(Vozilo v, HttpPostedFileBase file)
        {
            string pic = null;
            if (file != null)
            {
                pic = System.IO.Path.GetFileName(file.FileName);
                string path = System.IO.Path.Combine(Server.MapPath("~/VozilaSlike/"), pic);
                // file is uploaded
                file.SaveAs(path);
            }
            v.Slika = pic;

            genericUnitOfWork.GetRepositoryInstance<Vozilo>().Update(v);
            return RedirectToAction("Vozila");
        }
        public ActionResult DodajVozila()
        {
            return View();
        }
        [HttpPost]
        public ActionResult DodajVozila(Vozilo v, HttpPostedFileBase file)
        {
            string pic = null;
            if (file != null)
            {
                pic = System.IO.Path.GetFileName(file.FileName);
                string path = System.IO.Path.Combine(Server.MapPath("~/VozilaSlike/"), pic);
                // file is uploaded
                file.SaveAs(path);
            }
            v.Slika = pic;
            genericUnitOfWork.GetRepositoryInstance<Vozilo>().Add(v);
            return RedirectToAction("Vozila");
        }

        public ActionResult ObrisiVozilo(int productId)
        {
            return View(genericUnitOfWork.GetRepositoryInstance<Vozilo>().GetFirstorDefault(productId));
        }
        [HttpPost]
        public ActionResult ObrisiVozilo(Vozilo v)
        {
            genericUnitOfWork.GetRepositoryInstance<Vozilo>().Remove(v);
            
            return RedirectToAction("Vozila");
        }

    }
}