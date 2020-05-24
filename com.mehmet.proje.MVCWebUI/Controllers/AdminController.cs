using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Policy;
using com.mehmet.oracle.entities.BaseClasses;
using com.mehmet.proje.Business.Interfaces;
using com.mehmet.proje.MVCWebUI.Models;
using FluentNHibernate.Conventions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using X.PagedList;


namespace com.mehmet.proje.MVCWebUI.Controllers
{      
    [Authorize(Policy = "UserClaimPositionPolicy")]
    public class AdminController : Controller
    {
        public AdminController(IPersonelService personelService,IMusteriService musteriService, IAranacakService aranacakService, ISinyallerService sinyallerService, IIslenmisSinyallerService islenmisSinyallerService)
        {
            _musteriService = musteriService;
            _aranacakService = aranacakService;
            _SinyallerService = sinyallerService;
            _islenmisSinyallerService = islenmisSinyallerService;
            _PersonelService = personelService;
        }

        public IMusteriService _musteriService;
        public IAranacakService _aranacakService;
        public ISinyallerService _SinyallerService;
        public IPersonelService _PersonelService;
        public IIslenmisSinyallerService _islenmisSinyallerService;
      
        public IActionResult Index()
        {
            return RedirectToAction("BekleyenSinyal");
        }
       
        public IActionResult Kayit()
        {   
            
            MusteriAddModel musteriAddModel = new MusteriAddModel
            {
                musteri = new Musteri(),
               Aranacaklars = new List<Aranacaklar>
               {
                   new Aranacaklar(),
                   new Aranacaklar()
               }
               
              };
            ViewBag.baslik = "Kayıt Paneli";
            
            return View(musteriAddModel); //Boş model gönderildi
        }
       
        [HttpPost]
        public IActionResult Kayit(MusteriAddModel musteriAddModel)
        {
            if (ModelState.IsValid) // Gerekli Alanlar Dolduruldu ise
            {
                try
                {
                    // Veri tabanına kayıt işlemleri
                    _musteriService.Add(musteriAddModel.musteri);
                    foreach (var arakisi in musteriAddModel.Aranacaklars)
                    {
                        arakisi.aboneNo = musteriAddModel.musteri.AboneNo;
                        _aranacakService.Add(arakisi);
                    }
                    TempData["sonuc"] = "0";
                }
                catch (Exception e)
                { Console.WriteLine(e);
                    TempData["sonuc"] = "1";
                   
                }
            }
            return View();
        }
        
       
        public IActionResult Aboneler()
        {
            AdminAbonelerModel abonelerModel = new AdminAbonelerModel
            {
                musteriler = _musteriService.GetAll()
            };
            return View(abonelerModel);
        }
        
      
        [HttpPost]
        public IActionResult Aboneler(string aboneNo)
        {
            
            AdminAbonelerModel abonelerModel;
            if (string.IsNullOrEmpty(aboneNo))
            {
                return RedirectToAction("Aboneler");
            }
            else
            {
                Console.WriteLine("Birden fazla Abone --------"+aboneNo);
                abonelerModel = new AdminAbonelerModel
                {
                    tekMusteri = _musteriService.GetAbone(aboneNo)

                };
                
                if (abonelerModel.tekMusteri==null)
                {
                    return RedirectToAction("Aboneler");
                
                }
                List<Musteri> musteris = new List<Musteri>();
                musteris.Add(abonelerModel.tekMusteri);
                //abonelerModel.musteriler.Add(abonelerModel.tekMusteri);
                Console.WriteLine("Birden fazla Abone --------"+abonelerModel.tekMusteri.Kimlik+"boyut   "+musteris.Count);
                abonelerModel.musteriler = musteris;
                //return RedirectToAction("Aboneler", "Admin", abonelerModel);
                return View(abonelerModel);
            }
            

            
            //Console.WriteLine("Birden fazla Abone"+abonelerModel.musteriler.Count);
            //Console.WriteLine("Tek müşteri",abonelerModel.tekMusteri);
            //TempData["mesaj"] =null;
            //
        }
        
        
        public IActionResult AboneGuncelle(int musteriId)
        {
            if (musteriId!=0)
            {
                MusteriAddModel addModel = new MusteriAddModel
                {
                    musteri = _musteriService.GetById(musteriId),
                    Aranacaklars = _aranacakService.GetAll(_musteriService.GetByAboneNo(musteriId))
                };
               
                return View(addModel);
            }
            return View();
        }
        [HttpPost]
        public IActionResult AboneGuncelle(MusteriAddModel model)
        {
            if (ModelState.IsValid) // Gerekli Alanlar Dolduruldu ise
            {
                try
                {
                    // Veri tabanına kayıt işlemleri
                    _musteriService.Update(model.musteri);
                    foreach (var arakisi in model.Aranacaklars)
                    {
                        _aranacakService.Update(arakisi);
                    }
                    TempData["sonuc"] = "0";
                }
                catch (Exception e)
                { Console.WriteLine(e);
                    TempData["sonuc"] = "1";
                }
            }
            return View();
        }

        public IActionResult AboneBilgi(int musteriId, int? page)
        {
            var pageNumber = page ?? 1; 
            int pageSize = 2; 
            if (musteriId!=0)
            {
                MusteriModel addModel = new MusteriModel()
                {
                    MusteriBilgiler = _musteriService.GetById(musteriId),
                    Aranacaklars = _aranacakService.GetAll(_musteriService.GetByAboneNo(musteriId)),
                    MusteriSinyaller = _SinyallerService.GetAboneSinyal(_musteriService.GetByAboneNo(musteriId)).OrderByDescending(x=>x.SinyalId).ToList().ToPagedList(pageNumber, pageSize),
                    IslenmisSinyallers = _islenmisSinyallerService.GetAboneSinyal(_musteriService.GetByAboneNo(musteriId)).OrderByDescending(x=>x.SinyalId).ToList().ToPagedList(pageNumber, pageSize)
                    
                };
               
                return View(addModel);
            }
            return View();
        }

        public IActionResult AboneSil(int musteriId)
        {
            Musteri musteri = _musteriService.GetById(musteriId);
            List<Aranacaklar> aranacaklars = _aranacakService.GetAll(musteri.AboneNo);
            List<Sinyaller> sinyallers = _SinyallerService.GetAboneSinyal(musteri.AboneNo);
            try
            {
                _musteriService.Delete(musteri);
                foreach (var aranacak in aranacaklars)
                {
                    _aranacakService.Delete(aranacak);
                }

                foreach (var sinyal in sinyallers)
                {
                    _SinyallerService.Delete(sinyal);
                }

                TempData["mesaj"] = "0";
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                TempData["mesaj"] = "1";
                
            }


            return RedirectToAction("Aboneler", "Admin");
        }


        public IActionResult Personeller()
        {
            AdminPersonelModel personelModel = new AdminPersonelModel
            {
                _personels = _PersonelService.GetAll()
            };
            return View(personelModel);
        }

        public IActionResult personelEkle()
        {
            
            return View();
        }
        [HttpPost]
        public IActionResult personelEkle(PersonelEkleModel model)
        {
            model._personel.CalismaDurumu = "Aktif";
            model._personel.Parola = "0000";
            _PersonelService.Add(model._personel);
            //ViewData["sonuc"] = "Personel Kayıt Edildi";
            ModelState.AddModelError("Sonuc","Personel Başarı İle Kayıt Edildi.");
            return View();
        }
        [HttpPost]
        public IActionResult personelUpdate(PersonelEkleModel model)
        { _PersonelService.Update(model._personel);
            ModelState.AddModelError("Sonuc","Personel Başarı İle Güncellendi.");
            return View("personelEkle");
        }

        public IActionResult PersonelBilgi(int id)
        
        {    Console.WriteLine("Personel id"+id);
             PersonelEkleModel model = new PersonelEkleModel
            {
                _personel = _PersonelService.GetById(id)
            };
            return View(model);
        }

        [HttpPost]
        public IActionResult PersonelSil(int perid)
        {    Console.WriteLine("test----"+perid);
            Personel per = _PersonelService.GetById(perid);
            Console.WriteLine("test----"+per.Kimlik);
           _PersonelService.Delete(per);
           return View("Index");
        }

        public IActionResult IslenmisSinyal(int? page)
        {
            var pageNumber = page ?? 1; 
            int pageSize = 2; 
            TumSinyaller model = new TumSinyaller
            {
                _islenmisSinyal = _islenmisSinyallerService.GetAll().ToPagedList(pageNumber,pageSize)
            };
            return View(model);
        }

        public IActionResult BekleyenSinyal(int? page)
        {
            var pageNumber = page ?? 1; 
            int pageSize = 2; 
            //var bekleyenSinyal = _SinyallerService.GetAll().ToPagedList(pageNumber, pageSize);
                
            
            BekleyenSinyalModel model = new BekleyenSinyalModel
            {
                _sinyaller = _SinyallerService.GetAll().ToPagedList(pageNumber, pageSize)
            };
            return View(model);
        }

        
        public IActionResult PersonelSinyal(String Kimlik)
        {
            Console.WriteLine(Kimlik);
            PersonelSinyalIslemModel model = new PersonelSinyalIslemModel
            {
                IslenmisSinyallers = _islenmisSinyallerService.GetOperatorSinyal(Kimlik)
            };
            Console.WriteLine("VERİ SAYISI ",model.IslenmisSinyallers.Count());
            ViewBag.kimlik = Kimlik;
            return View(model);
        }
    }
}