using System;
using System.Collections.Generic;

#nullable disable

namespace Dominio.Model
{
    public partial class TblCatTipoMuestra
    {
        public TblCatTipoMuestra()
        {
            TblExamenes = new HashSet<TblExamenes>();
        }

        public Guid IdTipoMuestra { get; set; }
        public string Descripcion { get; set; }
        public int Estado { get; set; }

        public virtual ICollection<TblExamenes> TblExamenes { get; set; }
    }
}
