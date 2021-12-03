using Aplicacion.ManejadorError;
using Dominio.Model;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Aplicacion.Ordenes
{
    public class ConsultaId
    {
        public class ConsultaUnica : IRequest<TblOrdenes>
        {
            public Guid Id { get; set; }
        }
        public class Manejador : IRequestHandler<ConsultaUnica, TblOrdenes>
        {
            private readonly netLisContext _context;
            public Manejador(netLisContext context)
            {
                _context = context;
            }
            public async Task<TblOrdenes> Handle(ConsultaUnica request, CancellationToken cancellationToken)
            {
                var ordenes = await _context.TblOrdenes.FindAsync(request.Id);
                if (ordenes == null)
                {
                    throw new ManejadorExcepcion(HttpStatusCode.NotFound, new { mensaje = "La orden no existe" });
                }
                return ordenes;
            }
        }
    }
}
