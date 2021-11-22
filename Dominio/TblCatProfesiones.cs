using System;
using System.Collections.Generic;

#nullable disable

namespace Dominio.Model
{
    public partial class TblCatProfesiones
    {
        public TblCatProfesiones()
        {
            TblCatOcupaciones = new HashSet<TblCatOcupaciones>();
            TblEmpleados = new HashSet<TblEmpleado>();
            TblPacientes = new HashSet<TblPaciente>();
        }

        public Guid IdProfesiones { get; set; }
        public string Descripcion { get; set; }
        public int Estado { get; set; }

        public virtual ICollection<TblCatOcupaciones> TblCatOcupaciones { get; set; }
        public virtual ICollection<TblEmpleado> TblEmpleados { get; set; }
        public virtual ICollection<TblPaciente> TblPacientes { get; set; }
    }
}
