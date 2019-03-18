using NCKH.DAO;
using NCKH.Services;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Cors;

namespace NCKH.Controllers
{
    
    public class DetailsController : ApiController
    {
        private PointDetailsService service = new PointDetailsService();

        // GET: api/Details
        public IEnumerable<tblDetail> Get()
        {
            return service.GetAll();
        }

        // GET: api/Details/5
        public IEnumerable<tblDetail> Get(int id)
        {
            return service.Get(id);
        }

        // POST: api/Details
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Details/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Details/5
        public void Delete(int id)
        {
        }
    }
}
