using System;
using System.Collections.Generic;

#nullable disable

namespace Dominio.Model
{
    public partial class TblCatTipoOrden
    {
        public TblCatTipoOrden()
        {
            TblOrdenes = new HashSet<TblOrdenes>();
        }

        public Guid IdTipoOrden { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<TblOrdenes> TblOrdenes { get; set; }
    }
}
