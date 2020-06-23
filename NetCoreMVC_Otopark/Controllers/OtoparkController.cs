using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NetCoreMVC_Otopark.Models;

namespace NetCoreMVC_Otopark.Controllers
{
    public class OtoparkController : Controller
    {
        Context ctx = new Context();
        public IActionResult Index()
        {
            var araclar = ctx.aracs.Where(x=>x.Aktiflik==true).ToList();
            return View(araclar);
        }

        public  IActionResult TumListe()
        {
            var tumliste = ctx.aracs.ToList();
            return View(tumliste);
        }
        [HttpGet]
        public IActionResult AracGiris()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AracGiris(Arac arac)
        {
            var aracSayisi = ctx.aracs.Where(x => x.Aktiflik == true).Count();
            if (aracSayisi<5)
            {
                ctx.aracs.Add(arac);
                arac.Aktiflik = true;
                arac.GirisTarihi = DateTime.Now;
                ctx.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.HataMesaj = "Otoparkımız Doludur..";
            return View();
           
        }
        public IActionResult AracCikis(int id)
        {
            var arac = ctx.aracs.Where(x => x.AracID == id).SingleOrDefault();
            arac.Aktiflik = false;
            arac.CikisTarihi = DateTime.Now;
            ctx.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}