using Dominio.Model;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Aplicacion.OrdenesDetalles
{
    public class ConsultaId
    {
        public class ConsultaUnica : IRequest<TblOrdenesDetalle>
        {
            public Guid Id { get; set; }
        }
        public class Manejador : IRequestHandler<ConsultaUnica, TblOrdenesDetalle>
        {
            private readonly netLisContext _context;
            public Manejador(netLisContext context)
            {
                _context = context;
            }
            public async Task<TblOrdenesDetalle> Handle(ConsultaUnica request, CancellationToken cancellationToken)
            {
                var ordenDetalle = await _context.TblOrdenesDetalles.FindAsync(request.Id);
                return ordenDetalle;
            }
        }
    }
}
