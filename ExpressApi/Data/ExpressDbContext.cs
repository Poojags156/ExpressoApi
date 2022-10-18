using ExpressApi.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;


namespace ExpressApi.Data
{
    public class ExpressDbContext:DbContext
    {
        public DbSet<Menu> menus { get; set; }
        public DbSet<Reservation> reservations { get; set; }
    }
}