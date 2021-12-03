using Dominio.Model;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Aplicacion.AreaServicio
{
    public class Consulta
    {
        public class Ejecuta : IRequest<List<TblCatAreasLabServicio>> { }

        public class Manejador : IRequestHandler<Ejecuta, List<TblCatAreasLabServicio>>
        {
            private readonly netLisContext _context;
            public Manejador(netLisContext context)
            {
                _context = context;
            }

            public async Task<List<TblCatAreasLabServicio>> Handle(Ejecuta request, CancellationToken cancellationToken)
            {
                var areaLabServicios = await _context.TblCatAreasLabServicios.ToListAsync();
                return areaLabServicios;
            }
        }
    }
}
