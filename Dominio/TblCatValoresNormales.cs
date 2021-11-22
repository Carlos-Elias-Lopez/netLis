using System;
using System.Collections.Generic;

#nullable disable

namespace Dominio.Model
{
    public partial class TblCatValoresNormales
    {
        public Guid IdValoresNormales { get; set; }
        public Guid IdExamen { get; set; }
        public Guid IdSexo { get; set; }
        public double RangoAlto { get; set; }
        public double RangoBajo { get; set; }
        public int Estado { get; set; }

        public virtual TblExamenes IdExamenNavigation { get; set; }
        public virtual TblCatSexo IdSexoNavigation { get; set; }
    }
}
