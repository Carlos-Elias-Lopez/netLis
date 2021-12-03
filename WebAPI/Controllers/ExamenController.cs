using Aplicacion.Examen;
using Dominio.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    public class ExamenController : MiControllerBase
    {
         [HttpGet]
        public async Task<ActionResult<List<TblExamenes>>> Get()
        {
            return await Mediator.Send(new Consulta.Ejecuta());
        }

    }
}
