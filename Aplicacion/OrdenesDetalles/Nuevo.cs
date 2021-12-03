using Dominio.Model;
using FluentValidation;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Aplicacion.OrdenesDetalles
{
    public class Nuevo
    {
        public class Ejecuta : IRequest
        {
            //public Guid IdOrdenDetalle { get; set; }
            public Guid IdOrden { get; set; }
            public string NOrden { get; set; }
            public Guid IdExamen { get; set; }
            public string Activo { get; set; }

        };

        public class EjecutaValidacion : AbstractValidator<Ejecuta>
        {
            public EjecutaValidacion()
            {
                RuleFor(od => od.IdOrden).NotEmpty();
                RuleFor(od => od.NOrden).NotEmpty();
                RuleFor(od => od.IdExamen).NotEmpty();
                RuleFor(od => od.Activo).NotEmpty();
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
                var ordenesDetalles = new TblOrdenesDetalle
                {
                    //IdOrdenDetalle = request.IdOrdenDetalle,
                    IdOrden = request.IdOrden,
                    NOrden = request.NOrden,
                    IdExamen = request.IdExamen,
                    Activo = request.Activo
                };
                _context.TblOrdenesDetalles.Add(ordenesDetalles);
                var valor = await _context.SaveChangesAsync();
                if (valor > 0)
                {
                    return Unit.Value;
                }
                throw new Exception("No se puede ingresar un detalle de orden");
            }
        }


    }
}
