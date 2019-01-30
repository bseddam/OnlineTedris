using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineTedris.Models.DbModels
{
    public class Odenisfenn
    {
        public int Id { get; set; }
        public decimal Mebleg { get; set; }
        public DateTime BaslamaTarixi { get; set; }
        public DateTime BitmeTarixi { get; set; }
    }
}