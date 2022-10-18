using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExpressApi.Models
{
    public class Menu
    {
        public int Id { get; set; }
        
        public string Name { get; set; }
        public string image { get; set; }
        public ICollection<Submenu> Submenus { get; set; }
    }
}