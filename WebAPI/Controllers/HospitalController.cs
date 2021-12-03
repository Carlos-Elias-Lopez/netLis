using Aplicacion.Hospital;
using Dominio.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    public class HospitalController : MiControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<List<TblCatHospital>>> Get()
        {
            return await Mediator.Send(new Consulta.Ejecuta());
        }

    }
}
