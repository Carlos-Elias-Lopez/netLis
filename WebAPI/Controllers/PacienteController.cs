using Aplicacion.Paciente;
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
    public class PacienteController : MiControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<List<TblPaciente>>> Get()
        {
            return await Mediator.Send(new Consulta.Ejecuta());
        }
    }
}
