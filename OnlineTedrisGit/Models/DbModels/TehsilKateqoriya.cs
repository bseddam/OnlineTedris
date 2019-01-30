using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineTedris.Models.DbModels
{
    public class TehsilKateqoriya
    {
        public int ID { get; set; }
        public string KateqoriyaAdi { get; set; }
        public List<TedrisSaheleri> TedrisSaheleris { get; set; }
    }
}