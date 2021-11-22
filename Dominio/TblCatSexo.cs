using System;
using System.Collections.Generic;

#nullable disable

namespace Dominio.Model
{
    public partial class TblCatSexo
    {
        public TblCatSexo()
        {
            TblCatValoresNormales = new HashSet<TblCatValoresNormales>();
            TblEmpleados = new HashSet<TblEmpleado>();
            TblMedicos = new HashSet<TblMedico>();
            TblPacientes = new HashSet<TblPaciente>();
        }

        public Guid IdSexo { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<TblCatValoresNormales> TblCatValoresNormales { get; set; }
        public virtual ICollection<TblEmpleado> TblEmpleados { get; set; }
        public virtual ICollection<TblMedico> TblMedicos { get; set; }
        public virtual ICollection<TblPaciente> TblPacientes { get; set; }
    }
}
