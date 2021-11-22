using System;
using System.Collections.Generic;

#nullable disable

namespace Dominio.Model
{
    public partial class TblCatTipoResultado
    {
        public TblCatTipoResultado()
        {
            TblExamenes = new HashSet<TblExamenes>();
        }

        public Guid IdTipoResultado { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<TblExamenes> TblExamenes { get; set; }
    }
}
