using ExpressApi.Data;
using ExpressApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;



namespace ExpressApi.Controllers
{
    public class ReservationsController : ApiController
    {
        ExpressDbContext expressdbContext = new ExpressDbContext();

        public IHttpActionResult Post(Reservation reservation)
        {
         if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);

            }
            expressdbContext.reservations.Add(reservation);
            expressdbContext.SaveChanges();
            return StatusCode(HttpStatusCode.Created);
        }
    }
}
