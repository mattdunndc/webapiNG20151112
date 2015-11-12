using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using _2015webapi.Models;

namespace _2015webapi.Controllers
{
    public class foodapedia03Controller : ApiController
    {
        private govdataModel1 db = new govdataModel1();

        // GET: api/foodapedia03
        public IQueryable<foodapedia03> Getfoodapedia03()
        {
            return db.foodapedia03;
        }

        // GET: api/foodapedia03/5
        [ResponseType(typeof(foodapedia03))]
        public async Task<IHttpActionResult> Getfoodapedia03(int id)
        {
            foodapedia03 foodapedia03 = await db.foodapedia03.FindAsync(id);
            if (foodapedia03 == null)
            {
                return NotFound();
            }

            return Ok(foodapedia03);
        }

        // PUT: api/foodapedia03/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> Putfoodapedia03(int id, foodapedia03 foodapedia03)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != foodapedia03.ID)
            {
                return BadRequest();
            }

            db.Entry(foodapedia03).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!foodapedia03Exists(id))
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

        // POST: api/foodapedia03
        [ResponseType(typeof(foodapedia03))]
        public async Task<IHttpActionResult> Postfoodapedia03(foodapedia03 foodapedia03)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.foodapedia03.Add(foodapedia03);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = foodapedia03.ID }, foodapedia03);
        }

        // DELETE: api/foodapedia03/5
        [ResponseType(typeof(foodapedia03))]
        public async Task<IHttpActionResult> Deletefoodapedia03(int id)
        {
            foodapedia03 foodapedia03 = await db.foodapedia03.FindAsync(id);
            if (foodapedia03 == null)
            {
                return NotFound();
            }

            db.foodapedia03.Remove(foodapedia03);
            await db.SaveChangesAsync();

            return Ok(foodapedia03);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool foodapedia03Exists(int id)
        {
            return db.foodapedia03.Count(e => e.ID == id) > 0;
        }
    }
}