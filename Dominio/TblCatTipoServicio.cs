using System;
using System.Collections.Generic;

#nullable disable

namespace Dominio.Model
{
    public partial class TblCatTipoServicio
    {
        public TblCatTipoServicio()
        {
            TblOrdenes = new HashSet<TblOrdenes>();
        }

        public Guid IdTipoServicio { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<TblOrdenes> TblOrdenes { get; set; }
    }
}
