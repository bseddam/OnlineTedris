using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
namespace OnlineTedris.Models.DbModels
{
    public class TedrisFenleri
    {
        public int ID { get; set; }
        public string FennAdi { get; set; }
        public float Qiymet { get; set; }
        public string KursHaqqinda { get; set; }
        public List<TedrisMovzulari> TedrisMovzularis { get; set; }
        public List<TelebeSebet> telebeSebets { get; set; }
        public List<Odenisfenn> Odenisfenns { get; set; }
        public List<TelebeninKursu> telebeninKursus { get; set; }
    }
}