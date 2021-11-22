using System;
using System.Collections.Generic;

#nullable disable

namespace Dominio.Model
{
    public partial class TblCatEstadoCivil
    {
        public TblCatEstadoCivil()
        {
            TblEmpleados = new HashSet<TblEmpleado>();
            TblMedicos = new HashSet<TblMedico>();
            TblPacientes = new HashSet<TblPaciente>();
        }

        public Guid IdEstadoCivil { get; set; }
        public string Descripcion { get; set; }
        public int Estado { get; set; }

        public virtual ICollection<TblEmpleado> TblEmpleados { get; set; }
        public virtual ICollection<TblMedico> TblMedicos { get; set; }
        public virtual ICollection<TblPaciente> TblPacientes { get; set; }
    }
}
