using Aplicacion.AreaServicio;
using Dominio.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    public class AreaServicioController : MiControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<List<TblCatAreasLabServicio>>> Get()
        {
            return await Mediator.Send(new Consulta.Ejecuta());
        }

    }
}
