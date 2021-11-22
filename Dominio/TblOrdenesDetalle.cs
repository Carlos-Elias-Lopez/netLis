using System;
using System.Collections.Generic;

#nullable disable

namespace Dominio.Model
{
    public partial class TblOrdenesDetalle
    {
        public Guid IdOrdenDetalle { get; set; }
        public Guid IdOrden { get; set; }
        public string NOrden { get; set; }
        public Guid IdExamen { get; set; }
        public string Activo { get; set; }

        public virtual TblExamenes IdExamenNavigation { get; set; }
        public virtual TblOrdenes IdOrdenNavigation { get; set; }
    }
}
