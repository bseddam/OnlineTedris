using OnlineTedris.Models.DbModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace OnlineTedris.Context
{
    public class DbTraining: DbContext
    {
        public DbSet<Dersliknovu> Dersliknovus { get; set; }
        public DbSet<DerslikTipi> DerslikTipis { get; set; }
        public DbSet<Muellim> Muellims { get; set; }
        public DbSet<Odenisfenn> Odenisfenns { get; set; }
        public DbSet<TedrisFenleri> TedrisFenleris { get; set; }
        public DbSet<TedrisMovzulari> TedrisMovzularis { get; set; }
        public DbSet<TedrisSaheleri> TedrisSaheleris { get; set; }
        public DbSet<TehsilKateqoriya> TehsilKateqoriyas { get; set; }
        public DbSet<Telebe> Telebes { get; set; }
        public DbSet<TelebeHesab> TelebeHesabs { get; set; }
        public DbSet<TelebeninKursu> TelebeninKursus { get; set; }
        public DbSet<TelebeSebet> TelebeSebets { get; set; }
        public DbSet<Teyinati> Teyinatis { get; set; }
        public DbSet<AdminUser> AdminUsers { get; set; }
                
    }
}