using System;
using System.Collections.Generic;

#nullable disable

namespace Dominio.Model
{
    public partial class TblCatCategoriaExamenes
    {
        public TblCatCategoriaExamenes()
        {
            TblExamenes = new HashSet<TblExamenes>();
        }

        public Guid IdCategoriaExamenes { get; set; }
        public string Descripcion { get; set; }
        public int Estado { get; set; }

        public virtual ICollection<TblExamenes> TblExamenes { get; set; }
    }
}
