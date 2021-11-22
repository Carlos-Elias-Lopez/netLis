using Aplicacion.Pais;
using Dominio.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaisController : MiControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<List<TblCatPais>>> Get()
        {
            return await Mediator.Send(new Consulta.Ejecuta());
        }
    }
}
