using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineTedris.Models.DbModels
{
    public class TelebeHesab
    {
        public int ID { get; set; }
        public DateTime Tarix { get; set; }
        public decimal Mebleg { get; set; }
    }
}