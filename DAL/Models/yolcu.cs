﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class yolcu
    {
        public yolcu()
        {
            bilet_yolcu_iliskisi = new HashSet<bilet_yolcu_iliskisi>();
        }

        public Guid id { get; set; }
        public string ad { get; set; }
        public string soyad { get; set; }
        public string tc { get; set; }
        public string kullaniciAdi { get; set; }
        public string sifre { get; set; }

        public virtual ICollection<bilet_yolcu_iliskisi> bilet_yolcu_iliskisi { get; set; }
    }
}