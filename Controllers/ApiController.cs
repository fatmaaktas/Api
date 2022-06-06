using ApiMVC.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ApiMVC.Controllers
{
    public class ApiController : Controller
    {
        // GET: Api
        Model2 db = new Model2();
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GetOgrenciler()
        {
            var jsonList = JsonConvert.SerializeObject(db.TBLOGRENCI.ToList());
            //var jsonList = jsonSerialiser.Serialize(db.TBLOGRENCI.ToList());
            var jsonData = JsonConvert.DeserializeObject<List<TBLOGRENCI>>(jsonList);
            //List<TBLOGRENCI> ogrenciler 

            //var jsonSerialiser = new JavaScriptSerializer();
            //var jsonData = jsonSerialiser.Serialize(ogrenciler);

            //var jsonData = JsonConvert.SerializeObject(ogrenciler);

            return Json(jsonData, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult SetOgrenci(TBLOGRENCI ogrenci)
        {
            TBLOGRENCI ogrenciKayit = new TBLOGRENCI();
            ogrenciKayit.KULLANICIAD = ogrenci.KULLANICIAD;
            ogrenciKayit.SIFRE = ogrenci.SIFRE;
            ogrenciKayit.MAIL = ogrenci.MAIL;
            ogrenciKayit.SEHİR = ogrenci.SEHİR;

            db.TBLOGRENCI.Add(ogrenciKayit);
            db.SaveChanges();

            return Json("Kayıt Olmuştur", JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetOgretmenler()
        {
            var jsonList = JsonConvert.SerializeObject(db.TBLOGRETMEN.ToList());
            //var jsonList = jsonSerialiser.Serialize(db.TBLOGRETMEN.ToList());
            var jsonData = JsonConvert.DeserializeObject<List<TBLOGRETMEN>>(jsonList);
            //List<TBLOGRETMEN> ogretmenler 

            //var jsonSerialiser = new JavaScriptSerializer();
            //var jsonData = jsonSerialiser.Serialize(ogretmenler);

            //var jsonData = JsonConvert.SerializeObject(ogretmenler);

            return Json(jsonData, JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        public JsonResult SetOgretmen(TBLOGRETMEN ogretmen)
        {
            TBLOGRETMEN ogretmenKayit = new TBLOGRETMEN();
            ogretmenKayit.ogr_adi = ogretmen.ogr_adi;
            ogretmenKayit.ogr_soyadi = ogretmen.ogr_soyadi;
            ogretmenKayit.ogr_mail = ogretmen.ogr_mail;
            ogretmenKayit.ogr_tel = ogretmen.ogr_tel;
            ogretmenKayit.ogr_password = ogretmen.ogr_password;

            db.TBLOGRETMEN.Add(ogretmenKayit);
            db.SaveChanges();

            return Json("Kayıt Olmuştur", JsonRequestBehavior.AllowGet);
        }


    }
}