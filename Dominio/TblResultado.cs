using System;
using System.Collections.Generic;

#nullable disable

namespace Dominio.Model
{
    public partial class TblResultado
    {
        public Guid IdResultados { get; set; }
        public Guid? IdExamen { get; set; }
        public Guid IdOrden { get; set; }
        public string Resultado { get; set; }
        public string Observaciones { get; set; }
        public string Procesado { get; set; }
        public DateTime? FechaProcesa { get; set; }
        public string UsuarioProcesa { get; set; }
        public string Validado { get; set; }
        public DateTime? FechaValida { get; set; }
        public string UsuarioValida { get; set; }
        public int? Impreso { get; set; }
        public DateTime? FechaImprime { get; set; }
        public string UsuarioImprime { get; set; }
        public int Estado { get; set; }

        public virtual TblExamenes IdExamenNavigation { get; set; }
        public virtual TblOrdenes IdOrdenNavigation { get; set; }
    }
}
