using System.Web.Http;

namespace Parcial1_LeonardoArabe.Controllers
{
    [Route("api/[controller]")]
    public class OperationsController : ApiController
    {
        [HttpPost]
        [Route("Add")]
        public int Add([FromHeader] int numa, [FromHeader] int numb)
        {
            return numa + numb;
        }

        [HttpGet]
        [Route("Add")]
        public int Add2(int numa, int numb)
        {
            return numa + numb;
        }
    }
}
