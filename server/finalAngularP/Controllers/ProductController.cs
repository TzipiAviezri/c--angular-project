using System.Web.Http;
using Entity;
using BLL;
using System.Threading.Tasks;

namespace finalAngularP.Controllers
{
    [RoutePrefix("Api/Product")]
    public class ProductController : ApiController
    {
        [Route("GetAll")]
        public IHttpActionResult GetAll() => Ok(ProductBll.GetAll());

        [Route("AddOrEdit")]
        public async Task<IHttpActionResult> PostAsync([FromBody]ProductsEntities c) {
            if (ProductBll.GetById(c.id) == null)
                await ProductBll.Add(c);
            else await ProductBll.Edit(c);
             return Ok(true); 
        }
        [Route("DecAmount/{id}"), HttpPost]
        public async Task<IHttpActionResult> DecAmount(int id)
        {
            await ProductBll.DecAmount(id);
            return Ok(true);
        }
        [Route("IncAmount/{id}") , HttpPost]
        public async Task<IHttpActionResult> IncAmount(int id)
        {
            await ProductBll.IncAmount(id);
            return Ok(true);
        }
        [Route("Delete/{id}") , HttpDelete]
        public async Task<IHttpActionResult> Delete(int id)
        {
            await ProductBll.DeleteById(id);
            return Ok(true);
        }
    }
}