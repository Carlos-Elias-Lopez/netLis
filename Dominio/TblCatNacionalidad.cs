using System;
using System.Collections.Generic;

#nullable disable

namespace Dominio.Model
{
    public partial class TblCatNacionalidad
    {
        public TblCatNacionalidad()
        {
            TblCatIdentificacions = new HashSet<TblCatIdentificacion>();
            TblEmpleados = new HashSet<TblEmpleado>();
        }

        public Guid IdNacionalidad { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<TblCatIdentificacion> TblCatIdentificacions { get; set; }
        public virtual ICollection<TblEmpleado> TblEmpleados { get; set; }
    }
}
