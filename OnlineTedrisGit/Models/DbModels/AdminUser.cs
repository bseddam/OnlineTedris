using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineTedris.Models.DbModels
{
    public class AdminUser
    {
        public int ID { get; set; }
        public string FullName { get; set; }
        public string Username { get; set; }
        public string Passvords { get; set; }
    }
}