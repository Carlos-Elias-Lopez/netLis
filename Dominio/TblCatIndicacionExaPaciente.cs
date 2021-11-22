using System;
using System.Collections.Generic;

#nullable disable

namespace Dominio.Model
{
    public partial class TblCatIndicacionExaPaciente
    {
        public Guid IdIndicacionExaPaciente { get; set; }
        public Guid IdExamen { get; set; }
        public string Indicacion { get; set; }

        public virtual TblExamenes IdExamenNavigation { get; set; }
    }
}
