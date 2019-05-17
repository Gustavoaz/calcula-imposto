using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CalculaJuros.Domain.Contract.Dto;
using CalculaJuros.Domain.Contract.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CalculaJuros.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JurosCompostoController : ControllerBase
    {
        private readonly IJurosCompostoService service;

        public JurosCompostoController(IJurosCompostoService Service)
        {
            service = Service;
        }

        [HttpGet("calculajuros")]
        public async Task<ActionResult> CalculaJuro([FromQuery] decimal valorinicial, int meses)
        {
            var response = 0M;
            try
            {
                response = await service.CalculaJuros(new DtoJurosCompostoCalculaJurosRequest()
                {
                    ValorInicial = valorinicial,
                    Meses = meses
                });
            }
            catch (ArgumentNullException e)
            {
                return BadRequest(e.Message);
            }

            return Ok(response);
        }
    }
}