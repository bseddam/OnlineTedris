using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace OnlineTedris.Models.DbModels
{
    public class Muellim
    {
        public int ID { get; set; }
        public string IstifadeciAdi { get; set; }
        public string Shifre { get; set; }
        public string Soyad { get; set; }
        public string Adi { get; set; }
        public string Ata_adi { get; set; }
        public int Cins { get; set; }
        public DateTime Tevellud { get; set; }
        public string Shekil { get; set; }
        public List<TedrisFenleri> TedrisFenleris { get; set; }
    }
}