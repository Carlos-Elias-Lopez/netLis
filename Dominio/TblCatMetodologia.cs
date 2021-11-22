using System;
using System.Collections.Generic;

#nullable disable

namespace Dominio.Model
{
    public partial class TblCatMetodologia
    {
        public Guid IdMetodologia { get; set; }
        public string Descripcion { get; set; }
        public int Estado { get; set; }
    }
}
