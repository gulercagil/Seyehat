
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using Models;
using BLL;
using DAL;
using DAL.Models;
using AutoMapper;
using Net5.JWT.Models;

namespace Net5.JWT.Controllers
{


    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("EAPolicy")]
    public class YolcuController : ControllerBase
    {

        [HttpGet]
        public string kullanicigetir()
        {
            return "Güler Çağıl";
        }










        [HttpPost]
        [Route("login")]
        [AllowAnonymous]
        public ActionResult login(yolcu kullaniciAdi, yolcu sifre)
        {
            yolcu kullanici = Mapper.Map<yolcu>(kullaniciAdi, sifre);




            var cevap = _kk.KullaniciEkle(kullanici);




            if (!cevap)
            {

                return BadRequest("Kullanıcı eklenemedi");
            }
            else
            {
                return Ok("Kullanıcı Eklendi");

            }
        }
        private readonly YolcuYonetimi _yy = new YolcuYonetimi();

        private IMapper Mapper
        {
            get;
        }
        public YolcuController(IMapper mapper)
        {
            this.Mapper = mapper;
        }


        [HttpDelete]
        [Route("YolcuSilById")]
        [AllowAnonymous]
        public ActionResult yolcuSilById(Guid id)
        {

            var cevap = _yy.yolcuSilByID(id);


            if (!cevap)
            {

                return BadRequest("Silinemedi");
            }
            else { 
      return     Ok("Silindi");

            }



        }

        //[HttpPost]
        //[Route("Yolcukle")]
        //[AllowAnonymous]
        //public ActionResult Yolcukle(YolcuEklemeYK ylc)
        //{
        // yolcu eklenecekYolcu =   Mapper.Map<yolcu>(ylc);

         


        //    var cevap = _yy.yolcuEkle(eklenecekYolcu);




        //    if (!cevap)
        //    {

        //        return BadRequest("Yolcu eklenemedi");
        //    }
        //    else
        //    {
        //        return Ok("olcu Eklendi");

        //    }
        //    }


            //    [HttpGet]
            //  [Route("GetTumKitaplar")]
            //  [AllowAnonymous]
            //  public ActionResult GetTumKitaplar()
            //  {

            //      var cevap = ky.getTumKitaplar();


            //      if (cevap == null)
            //      {

            //          return BadRequest("Veri alınamadı");
            //      }
            //      else { 
            //return     Ok(cevap);

            //      }



            //  } 


            //  [HttpGet]
            //  [Route("KitapAdiDegistir")]
            //  [AllowAnonymous]
            //  public ActionResult KitapAdiDegistir(string id,string kitapAdi)
            //  {

            //      var cevap = ky.kitapAdiDegistir(Guid.Parse(id),kitapAdi);


            //      if (!cevap)
            //      {

            //          return BadRequest("Ad değiştirilemedi");
            //      }
            //      else { 
            //return     Ok("Ad değişti");

            //      }



            //  }



            //  [HttpPost]
            //  [Route("KitapEkle")]
            //  [AllowAnonymous]
            //  public ActionResult KitapEkle(KitapEklemeSinifi ktp)
            //  {

            //      kitap k = new kitap();
            //      k.kitapAdi = ktp.kitapAdi;
            //      k.sayfaSayisi = ktp.sayfaSayisi;


            //      var cevap = ky.kitapEkle(k);


            //      if (!cevap)
            //      {

            //          return BadRequest("Kitap eklenemedi");
            //      }
            //      else { 
            //return     Ok("Kitap Eklendi");

            //      }



        }



}

