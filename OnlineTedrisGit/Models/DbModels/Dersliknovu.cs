using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineTedris.Models.DbModels
{
    public class Dersliknovu
    {
        public int ID{ get; set; }
        public string DerslikAdi { get; set; }
        public List<TedrisMovzulari> TedrisMovzularis { get; set; }
    }
}