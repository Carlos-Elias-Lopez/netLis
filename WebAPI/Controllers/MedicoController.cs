using Aplicacion.Medico;
using Dominio.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    public class MedicoController : MiControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<List<TblMedico>>> Get()
        {
            return await Mediator.Send(new Consulta.Ejecuta());
        }

    }
}
