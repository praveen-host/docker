using Microsoft.AspNetCore.Mvc;

namespace SimpleWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WhoIsController : ControllerBase
    {
          

        [HttpGet(Name = "GetWeatherForecast")]
        public string Get()
        {
            return Environment.MachineName;
        }
    }
}
