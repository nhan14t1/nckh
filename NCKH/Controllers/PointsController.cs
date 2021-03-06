﻿using NCKH.DAO;
using NCKH.Services;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Cors;

namespace NCKH.Controllers
{
    
    public class PointsController : ApiController
    {
        private PointsService service = new PointsService();

        // GET: api/Points
        public IEnumerable<tblPoint> Get()
        {
            return service.GetAll();
        }

        // GET: api/Points/5
        public tblPoint Get(int id)
        {
            return service.Get(id);
        }

        // POST: api/Points
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Points/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Points/5
        public void Delete(int id)
        {
        }
    }
}
