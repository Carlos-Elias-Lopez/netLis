using Dominio.Model;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Aplicacion.OrdenesDetalles
{
    public class Consulta
    {
        public class Ejecuta : IRequest<List<TblOrdenesDetalle>> { }

        public class Manejador : IRequestHandler<Ejecuta, List<TblOrdenesDetalle>>
        {
            private readonly netLisContext _context;
            public Manejador(netLisContext context)
            {
                _context = context;
            }
         
            public async Task<List<TblOrdenesDetalle>> Handle(Ejecuta request, CancellationToken cancellationToken)
            {
                var ordenDetalle = await _context.TblOrdenesDetalles.ToListAsync();
                return ordenDetalle;
            }
        }
    }
}
