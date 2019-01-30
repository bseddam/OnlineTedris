using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineTedris.Models.DbModels
{
    public class DerslikTipi
    {
        public int ID { get; set; }
        public string DersTipiAdi { get; set; }
        public List<TedrisFenleri> TedrisFenleris { get; set; }
    }
}