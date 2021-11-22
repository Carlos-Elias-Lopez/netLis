using System;
using System.Collections.Generic;

#nullable disable

namespace Dominio.Model
{
    public partial class TblCatUnidadMedida
    {
        public TblCatUnidadMedida()
        {
            TblExamenes = new HashSet<TblExamenes>();
        }

        public Guid IdUnidadMedidas { get; set; }
        public string UnidadMedida { get; set; }
        public int? Estado { get; set; }

        public virtual ICollection<TblExamenes> TblExamenes { get; set; }
    }
}
