using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Entity;
using BLL;
using System.Threading.Tasks;

namespace finalAngularP.Controllers
{
    public class CategoryController : ApiController
    {
        public IHttpActionResult GetAll() => Ok(CategoryBll.GetAll());
      

        [Route("AddOrEdit")]
        public async Task<IHttpActionResult> PostAsync(CategoryEntities c)
        {
            if (ProductBll.GetById(c.id) == null)
                await CategoryBll.Add(c);
            else await CategoryBll.Edit(c);
            return Ok(true);

        }
    }
}