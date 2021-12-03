using Dominio.Model;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Aplicacion.Examen
{
    public class Consulta
    {
        public class Ejecuta : IRequest<List<TblExamenes>> { }

        public class Manejador : IRequestHandler<Ejecuta, List<TblExamenes>>
        {
            private readonly netLisContext _context;
            public Manejador(netLisContext context)
            {
                _context = context;
            }

            public async Task<List<TblExamenes>> Handle(Ejecuta request, CancellationToken cancellationToken)
            {
                var examenes = await _context.TblExamenes.ToListAsync();
                return examenes;
            }
        }
    }
}
