using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
namespace OnlineTedris.Models.DbModels
{
    public class TedrisSaheleri
    {
        public int ID { get; set; }
        public string SaheAdi { get; set; }
        public string Haqqinda { get; set; }
        public List<TedrisFenleri> TedrisFenleris { get; set; }
    }
}