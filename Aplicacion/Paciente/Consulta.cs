using Dominio.Model;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Aplicacion.Paciente
{
    public class Consulta
    {
        public class Ejecuta : IRequest<List<TblPaciente>> { }

        public class Manejador : IRequestHandler<Ejecuta, List<TblPaciente>>
        {

            private readonly netLisContext _context;
            public Manejador(netLisContext context)
            {
                _context = context;
            }

            public async Task<List<TblPaciente>> Handle(Ejecuta request, CancellationToken cancellationToken)
            {
                var paciente = await _context.TblPacientes.ToListAsync();
                return paciente;
            }
        }
    }
}
