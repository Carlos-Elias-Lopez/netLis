using Dominio.Model;
using FluentValidation;
using MediatR;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            public string NOrden { get; set; }
            public Guid IdtblMedico { get; set; }
            public Guid IdPaciente { get; set; }
            public Guid IdTipoServicio { get; set; }
            public Guid IdTipoOrden { get; set; }
            public string Asistencia { get; set; }
            public string Observaciones { get; set; }
            public DateTime FechaOrden { get; set; }
            public int Estado { get; set; }
            public List<Guid> ListExamen { get; set; }
        }

        public class EjecutaValidacion : AbstractValidator<Ejecuta>
        {
            public EjecutaValidacion()
            {
                RuleFor(o => o.NOrden).NotEmpty();
                RuleFor(o => o.IdtblMedico).NotEmpty();
                RuleFor(o => o.IdPaciente).NotEmpty();
                RuleFor(o => o.IdTipoServicio).NotEmpty();
                RuleFor(o => o.IdTipoOrden).NotEmpty();
                RuleFor(o => o.Asistencia).NotEmpty();
                RuleFor(o => o.Observaciones).NotEmpty();
                RuleFor(o => o.FechaOrden).NotEmpty();
            }

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
                Guid _ordenId = Guid.NewGuid();
                Debug.WriteLine(_ordenId);

                var ordenes = new TblOrdenes
                {
                    IdOrden = _ordenId,
                    NOrden = request.NOrden,
                    IdtblMedico = request.IdtblMedico,
                    IdPaciente = request.IdPaciente,
                    IdTipoServicio = request.IdTipoServicio,
                    IdTipoOrden = request.IdTipoOrden,
                    Asistencia = request.Asistencia,
                    Observaciones = request.Observaciones,
                    FechaOrden = request.FechaOrden,
                    Estado = 1
                };

                _context.TblOrdenes.Add(ordenes);

                //Agregando en tabla Orden Detalle
                if (request.ListExamen != null)
                {
                    foreach (var id in request.ListExamen)
                    {
                        Guid _ordedetalleid = Guid.NewGuid();
                        var ordenDetalle = new TblOrdenesDetalle
                        {
                            IdOrdenDetalle = _ordedetalleid,
                            IdOrden = _ordenId,
                            NOrden = request.NOrden,
                            IdExamen = id
                        };
                        _context.TblOrdenesDetalles.Add(ordenDetalle);
                    }
                }

                var valor = await _context.SaveChangesAsync();

                if (valor > 0)
                {
                    return Unit.Value;
                }
                throw new Exception("No se puede agregar la Orden");

            }
        }
    }
}