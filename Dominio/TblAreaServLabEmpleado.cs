using System;
using System.Collections.Generic;

#nullable disable

namespace Dominio.Model
{
    public partial class TblAreaServLabEmpleado
    {
        public Guid IdAreaServLabEmpleados { get; set; }
        public Guid? IdAreaLabServicio { get; set; }
        public Guid IdEmpleado { get; set; }
        public Guid IdSucursal { get; set; }

        public virtual TblCatAreasLabServicio IdAreaLabServicioNavigation { get; set; }
        public virtual TblEmpleado IdEmpleadoNavigation { get; set; }
        public virtual TblCatSucursales IdSucursalNavigation { get; set; }
    }
}
