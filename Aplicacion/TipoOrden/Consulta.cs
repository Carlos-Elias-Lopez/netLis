using Dominio.Model;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Aplicacion.TipoOrden
{
    public class Consulta
    {
        public class Ejecuta : IRequest<List<TblCatTipoOrden>> { }
        public class Manejador : IRequestHandler<Ejecuta, List<TblCatTipoOrden>>
        {
            private readonly netLisContext _context;
            public Manejador(netLisContext context)
            {
                _context = context;
            }

            public async Task<List<TblCatTipoOrden>> Handle(Ejecuta request, CancellationToken cancellationToken)
            {
                var tipoOrden = await _context.TblCatTipoOrdens.ToListAsync();
                return tipoOrden;
            }
        }
    }
}
