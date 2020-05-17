using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace MyBib.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ValuesController : ControllerBase
    {
        public string Get()
        {
            return string.Empty;
        }
    }
}