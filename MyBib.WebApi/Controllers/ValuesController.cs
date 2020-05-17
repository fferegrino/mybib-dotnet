using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

using MyBib.WebApi.Services;

namespace MyBib.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ValuesController : ControllerBase
    {
        IPaymentService paymentService;

        public ValuesController(IPaymentService paymentService)
        {
            this.paymentService = paymentService;
        }

        public string Get()
        {
            return paymentService.GetMessage();
        }
    }
}