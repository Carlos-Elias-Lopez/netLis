using Dominio.Model;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Aplicacion.Hospital
{
    public class Consulta
    {
        public class Ejecuta : IRequest<List<TblCatHospital>> { }

        public class Manejador : IRequestHandler<Ejecuta, List<TblCatHospital>>
        {
            private readonly netLisContext _context;
            public Manejador(netLisContext context)
            {
                _context = context;
            }

            public async Task<List<TblCatHospital>> Handle(Ejecuta request, CancellationToken cancellationToken)
            {
                var hospital = await _context.TblCatHospitals.ToListAsync();
                return hospital;
            }
        }
    }
}
