using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    [Route("")]
    public class Routes : ControllerBase
    {
        [HttpGet]
        public void GetBasePath()
        {

        }
    }
}
