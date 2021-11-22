using System;
using System.Collections.Generic;

#nullable disable

namespace Dominio.Model
{
    public partial class TblCatPerfiles
    {
        public TblCatPerfiles()
        {
            TblCatPerfilesExamenes = new HashSet<TblCatPerfilesExamenes>();
        }

        public Guid IdPerfiles { get; set; }
        public string Descripcion { get; set; }
        public int Estado { get; set; }

        public virtual ICollection<TblCatPerfilesExamenes> TblCatPerfilesExamenes { get; set; }
    }
}
