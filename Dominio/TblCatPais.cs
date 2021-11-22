using System;
using System.Collections.Generic;

#nullable disable

namespace Dominio.Model
{
    public partial class TblCatPais
    {
       
        public Guid IdPais { get; set; }
        public string Descripcion { get; set; }
        public int Estado { get; set; }

        public virtual ICollection<TblCatSucursales> TblCatSucursales { get; set; }
      
    }
}
