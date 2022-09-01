using System.Web.Http;
using Entity;
using BLL;
using System.Threading.Tasks;

namespace finalAngularP.Controllers
{        [RoutePrefix("Api/Customer")]

    public class CustomerController : ApiController
    {           [Route("GetAll")]
    
            public IHttpActionResult GetAll() => Ok(CustomerBll.GetAll());

            [Route("CheckIfExist/{name}/{pin}") , HttpGet]
            public IHttpActionResult CheckIfExist(string name, short pin) => Ok(CustomerBll.CheckIfExist(name,pin));
            [Route("Add") ]
           public async Task<IHttpActionResult> Put(CustomersEntities c) { await CustomerBll.Add(c); return Ok(true); }



    }
    }




