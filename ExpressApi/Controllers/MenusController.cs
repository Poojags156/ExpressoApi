using ExpressApi.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ExpressApi.Controllers
{
    public class MenusController : ApiController
    {
        ExpressDbContext expressDbContext = new ExpressDbContext();
        
        public IHttpActionResult GetMenus()
        {
            var menus = expressDbContext.menus.Include("Submenus");
            return Ok(menus);
        }
        public IHttpActionResult GetMenu(int id)
        {
            var menu = expressDbContext.menus.Include("Submenus").FirstOrDefault(m => m.Id == id);
            if (menu == null)
            {
                return NotFound();
            }
            return Ok(menu);
        
        
        }
    }
}
