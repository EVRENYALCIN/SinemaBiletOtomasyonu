﻿using SinemaBiletOtomasyonu.Enum;
using SinemaBiletOtomasyonu.FormModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinemaBiletOtomasyonu.Model
{
    public class Bilet
    {
        public Musteri SatinAlanMusteri { get; set; }
        public Koltuk Koltuk { get; set; }
        public Film Film { get; set; }
        public Seans Seans { get; set; }
        public Salon Salon { get; set; }
        public DateTime Tarih { get; set; }
    }
}
