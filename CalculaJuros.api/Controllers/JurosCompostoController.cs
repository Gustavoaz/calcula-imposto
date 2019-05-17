using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CalculaJuros.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JurosCompostoController : ControllerBase
    {
        [HttpGet()]
        public ActionResult<string> CalculaJuro()
        {
            return "teste 3";
        }
    }
}