using System;
using System.Collections.Generic;

#nullable disable

namespace Dominio.Model
{
    public partial class TblCatAreasLabServicio
    {
        public TblCatAreasLabServicio()
        {
            TblAreaServLabEmpleados = new HashSet<TblAreaServLabEmpleado>();
            TblExamenes = new HashSet<TblExamenes>();
        }

        public Guid IdAreaLabServicio { get; set; }
        public string Descripcion { get; set; }
        public Guid Estado { get; set; }

        public virtual ICollection<TblAreaServLabEmpleado> TblAreaServLabEmpleados { get; set; }
        public virtual ICollection<TblExamenes> TblExamenes { get; set; }
    }
}
