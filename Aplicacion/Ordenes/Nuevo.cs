using Dominio.Model;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Aplicacion.Ordenes
{
     public class Nuevo
    {
        public class Ejecuta : IRequest
        {
            //public Guid IdOrden { get; set; }
            public string NOrden { get; set; }
            public Guid IdtblMedico { get; set; }
            public Guid IdPaciente { get; set; }
            public Guid IdTipoServicio { get; set; }
            public Guid IdTipoOrden { get; set; }
            public string Asistencia { get; set; }
            public string Observaciones { get; set; }
            public DateTime FechaOrden { get; set; }
            public string Activo { get; set; }
            public DateTime? FechaImprime { get; set; }
            public string UsuarioImprime { get; set; }
            public int Estado { get; set; }
            public string Finalizado { get; set; }
            public DateTime? FechaCita { get; set; }
            public DateTime FechaPreporte { get; set; }
        }

        public class Manejador : IRequestHandler<Ejecuta>
        {
            private readonly netLisContext _context;
            public Manejador(netLisContext context)
            {
                _context = context;
            }
            public async Task<Unit> Handle(Ejecuta request, CancellationToken cancellationToken)
            {

                var ordenes = new TblOrdenes
                {

                    NOrden = request.NOrden,
                    IdtblMedico = request.IdtblMedico,
                    IdPaciente = request.IdPaciente,
                    IdTipoServicio = request.IdTipoServicio,
                    IdTipoOrden = request.IdTipoOrden,
                    Asistencia = request.Asistencia,
                    Observaciones = request.Observaciones,
                    FechaOrden = request.FechaOrden,
                    Activo = request.Activo,
                    FechaImprime = request.FechaImprime,
                    UsuarioImprime = request.UsuarioImprime,
                    Estado = request.Estado,
                    Finalizado = request.Finalizado,
                    FechaCita = request.FechaCita,
                    FechaPreporte = request.FechaPreporte
                };
                _context.TblOrdenes.Add(ordenes);
                var valor = await _context.SaveChangesAsync();
                if (valor > 0)
                {
                    return Unit.Value;
                }
                throw new Exception("No se puede agregar la orden");


            }
        }

    }
}
