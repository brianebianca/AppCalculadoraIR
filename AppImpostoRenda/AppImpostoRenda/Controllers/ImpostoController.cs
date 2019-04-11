using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AppImpostoRenda.Models;

namespace AppImpostoRenda.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImpostoController : ControllerBase
    {
        [HttpGet("{salario}")]
        public ActionResult<Imposto> Get(decimal salario)
        {
            return new CalculadoraImposto().CalcularImposto(salario);
        }
    }
}