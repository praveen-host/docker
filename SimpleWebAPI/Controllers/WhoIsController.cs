using Microsoft.AspNetCore.Mvc;

namespace SimpleWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WhoIsController : ControllerBase
    {

        [HttpGet]
        public string Get()
        {
            return Environment.MachineName+" "+ System.DateTime.UtcNow;
        }
    }
}
