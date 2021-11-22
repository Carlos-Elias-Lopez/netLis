using System;
using System.Collections.Generic;

#nullable disable

namespace Dominio.Model
{
    public partial class TblCatIdentificacion
    {
        public TblCatIdentificacion()
        {
            TblEmpleados = new HashSet<TblEmpleado>();
            TblMedicos = new HashSet<TblMedico>();
            TblPacientes = new HashSet<TblPaciente>();
        }

        public Guid IdIdentificacion { get; set; }
        public Guid IdNacionalidad { get; set; }
        public string Descripcion { get; set; }
        public int Estado { get; set; }

        public virtual TblCatNacionalidad IdNacionalidadNavigation { get; set; }
        public virtual ICollection<TblEmpleado> TblEmpleados { get; set; }
        public virtual ICollection<TblMedico> TblMedicos { get; set; }
        public virtual ICollection<TblPaciente> TblPacientes { get; set; }
    }
}
