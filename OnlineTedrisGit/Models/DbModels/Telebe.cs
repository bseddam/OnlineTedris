using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace OnlineTedris.Models.DbModels
{
    public class Telebe
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "Email doldurulmalıdır")]
        [EmailAddress(ErrorMessage = "Email Address Səhvdir")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Şifrə doldurulmalıdır")]
        public string Shifre { get; set; }
        [Required(ErrorMessage = "Soyadi doldurulmalıdır")]
        public string Soyadi { get; set; }
        [Required(ErrorMessage = "Adi doldurulmalıdır")]
        public string Adi { get; set; }
        public string Ata_adi { get; set; }
        public bool? Cins { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? Tevellud { get; set; }
        public string Shekil { get; set; }
        public string TelebeKodu { get; set; }
        public List<TelebeSebet> telebeSebets { get; set; }
        public List<TelebeHesab> telebeHesabs { get; set; }
        public List<Odenisfenn> odenisfenns { get; set; }
        public List<TelebeninKursu> telebeninKursus { get; set; }
    }
}