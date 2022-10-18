using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExpressApi.Models
{
    public class Submenu
    {
        public int SubMenuId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Price { get; set; }
        public string Image { get; set; }
    }
}