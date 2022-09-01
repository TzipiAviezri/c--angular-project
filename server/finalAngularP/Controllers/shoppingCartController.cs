
using System.Web.Http;
using BLL;
using Entity;
using System.Threading.Tasks;


namespace finalAngularP.Controllers
{
    [RoutePrefix("Api/ShoppingCart")]
    public class ShoppingCartController : ApiController
    {
        [Route("AddShopping/{idCustomer}"), HttpPut]
        public async Task<IHttpActionResult> AddShopping(int idCustomer, [FromBody] ShoppingCartEntities shoppingCart)
        {
            await ShoppingDoing.doShopig((short)idCustomer, shoppingCart);
            return Ok(true);
        }

       

        [Route("get")]
        public IHttpActionResult get()
        {
            return Ok(ShoppingBll.GetAll());
        }

        [Route("getById/{id}")]
        public IHttpActionResult getById(int id)
        {
            return Ok(ShoppingBll.GetById(id));
        }
    }
}
