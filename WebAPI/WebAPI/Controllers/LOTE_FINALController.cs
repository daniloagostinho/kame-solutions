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
using WebAPI.Models;

namespace WebAPI.Controllers
{
    public class LOTE_FINALController : ApiController
    {
        private UserDBLocalEntities db = new UserDBLocalEntities();

        // GET: api/LOTE_FINAL
        public IQueryable<LOTE_FINAL> GetLOTE_FINAL()
        {
            return db.LOTE_FINAL;
        }

        // GET: api/LOTE_FINAL/5
        [ResponseType(typeof(LOTE_FINAL))]
        public IHttpActionResult GetLOTE_FINAL(string id)
        {
            LOTE_FINAL lOTE_FINAL = db.LOTE_FINAL.Find(id);
            if (lOTE_FINAL == null)
            {
                return NotFound();
            }

            return Ok(lOTE_FINAL);
        }

        // PUT: api/LOTE_FINAL/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutLOTE_FINAL(string id, LOTE_FINAL lOTE_FINAL)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != lOTE_FINAL.CPF)
            {
                return BadRequest();
            }

            db.Entry(lOTE_FINAL).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LOTE_FINALExists(id))
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

        // POST: api/LOTE_FINAL
        [ResponseType(typeof(LOTE_FINAL))]
        public IHttpActionResult PostLOTE_FINAL(LOTE_FINAL lOTE_FINAL)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.LOTE_FINAL.Add(lOTE_FINAL);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (LOTE_FINALExists(lOTE_FINAL.CPF))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = lOTE_FINAL.CPF }, lOTE_FINAL);
        }

        // DELETE: api/LOTE_FINAL/5
        [ResponseType(typeof(LOTE_FINAL))]
        public IHttpActionResult DeleteLOTE_FINAL(string id)
        {
            LOTE_FINAL lOTE_FINAL = db.LOTE_FINAL.Find(id);
            if (lOTE_FINAL == null)
            {
                return NotFound();
            }

            db.LOTE_FINAL.Remove(lOTE_FINAL);
            db.SaveChanges();

            return Ok(lOTE_FINAL);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool LOTE_FINALExists(string id)
        {
            return db.LOTE_FINAL.Count(e => e.CPF == id) > 0;
        }
    }
}