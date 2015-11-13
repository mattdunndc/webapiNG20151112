using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using _2015webapi.Models;
using System.Web.OData;


namespace _2015webapi.Controllers
{
    public class FooditemsController : ApiController
    {
        private Fooddb db = new Fooddb();

        // GET: api/Fooditems
        [EnableQuery] //action filter
        public IQueryable<Fooditem> GetFooditems()
        {
            return db.Fooditems.AsQueryable();
        }

        public IEnumerable<Fooditem> GetFooditems(string search)
        {
            var fooditems = db.Fooditems;
            return db.Fooditems.Where(p => p.Display_Name.Contains(search));
        }

        // GET: api/Fooditems/5
        [ResponseType(typeof(Fooditem))]
        public IHttpActionResult GetFooditem(int id)
        {
            Fooditem fooditem = db.Fooditems.Find(id);
            if (fooditem == null)
            {
                return NotFound();
            }

            return Ok(fooditem);
        }

        // PUT: api/Fooditems/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutFooditem(int id, Fooditem fooditem)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != fooditem.ID)
            {
                return BadRequest();
            }

            db.Entry(fooditem).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FooditemExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Fooditems
        [ResponseType(typeof(Fooditem))]
        public IHttpActionResult PostFooditem(Fooditem fooditem)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Fooditems.Add(fooditem);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = fooditem.ID }, fooditem);
        }

        // DELETE: api/Fooditems/5
        [ResponseType(typeof(Fooditem))]
        public IHttpActionResult DeleteFooditem(int id)
        {
            Fooditem fooditem = db.Fooditems.Find(id);
            if (fooditem == null)
            {
                return NotFound();
            }

            db.Fooditems.Remove(fooditem);
            db.SaveChanges();

            return Ok(fooditem);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool FooditemExists(int id)
        {
            return db.Fooditems.Count(e => e.ID == id) > 0;
        }
    }
}