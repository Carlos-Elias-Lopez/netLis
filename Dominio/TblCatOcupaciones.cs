using System;
using System.Collections.Generic;

#nullable disable

namespace Dominio.Model
{
    public partial class TblCatOcupaciones
    {
        public Guid IdOcupaciones { get; set; }
        public Guid IdEmpleado { get; set; }
        public Guid IdProfesiones { get; set; }
        public string Descripcion { get; set; }

        public virtual TblEmpleado IdEmpleadoNavigation { get; set; }
        public virtual TblCatProfesiones IdProfesionesNavigation { get; set; }
    }
}
