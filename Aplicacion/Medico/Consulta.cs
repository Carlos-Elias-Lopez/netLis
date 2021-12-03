using Dominio.Model;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Aplicacion.Medico
{
    public class Consulta
    {
        public class Ejecuta : IRequest<List<TblMedico>> { }

        public class Manejador : IRequestHandler<Ejecuta, List<TblMedico>>
        {
            private readonly netLisContext _context;
            public Manejador(netLisContext context)
            {
                _context = context;
            }

          

            public async Task<List<TblMedico>> Handle(Ejecuta request, CancellationToken cancellationToken)
            {
                var medico = await _context.TblMedicos.ToListAsync();
                return medico;
            }
        }
    }
}
