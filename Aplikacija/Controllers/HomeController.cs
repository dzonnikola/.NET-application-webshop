using Aplikacija.Database;
using Aplikacija.Models;
using Aplikacija.Models.Home;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Aplikacija.Controllers
{
    public class HomeController : Controller
    {
        ProdajaKamionaEntities ent = new ProdajaKamionaEntities();
        public ActionResult Index(string search)
        {
            HomeIndexViewModel model = new HomeIndexViewModel();
            return View(model.KreirajModel(search));
        }

        public ActionResult DodajUKorpu(int productId)
        {
            if (Session["cart"] == null)
            {
                List<Item> korpa = new List<Item>();
                var product = ent.Voziloes.Find(productId);
                korpa.Add(new Item()
                {
                    Vozilo = product,
                    Kolicina = 1
                });
                Session["cart"] = korpa;
            }
            else
            {
                List<Item> korpa = (List<Item>)Session["cart"];
                var product = ent.Voziloes.Find(productId);
                foreach (var item in korpa)
                {
                    if (item.Vozilo.VoziloId == productId)
                    {
                        int prevQty = item.Kolicina;
                        korpa.Remove(item);
                        korpa.Add(new Item()
                        {
                            Vozilo = product,
                            Kolicina = prevQty + 1
                        });
                        break;
                    }
                    else
                    {
                        korpa.Add(new Item()
                        {
                            Vozilo = product,
                            Kolicina = 1
                        });
                    }
                }
                Session["cart"] = korpa;
            }
            return Redirect("Index");
        }
        public ActionResult IzbaciIzKorpe(int productId)
        {
            List<Item> korpa = (List<Item>)Session["cart"];
            foreach (var item in korpa)
            {
                if (item.Vozilo.VoziloId == productId)
                {
                    korpa.RemoveAt(0);
                    break;
                }
            }
            Session["cart"] = korpa;
            return Redirect("Index");
        }

        public ActionResult Chechout()
        {
            return View();
        }
        
        public ActionResult CheckoutDetails()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}