using System;
using System.Collections.Generic;

#nullable disable

namespace Dominio.Model
{
    public partial class TblCatAreasServ
    {
        public Guid IdAreaServ { get; set; }
        public string Descripcion { get; set; }
        public string DescripcionCorta { get; set; }
        public int Estado { get; set; }
    }
}
