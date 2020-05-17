using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

using MyBib.WebApi.Services;

namespace MyBib.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ValuesController : ControllerBase
    {
        public string Get([FromServices]IPaymentService paymentService)
        {
            return paymentService.GetMessage();
        }
    }
}