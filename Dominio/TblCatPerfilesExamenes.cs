using System;
using System.Collections.Generic;

#nullable disable

namespace Dominio.Model
{
    public partial class TblCatPerfilesExamenes
    {
        public Guid IdPerfilesExamenes { get; set; }
        public Guid IdExamen { get; set; }
        public Guid IdPerfiles { get; set; }

        public virtual TblExamenes IdExamenNavigation { get; set; }
        public virtual TblCatPerfiles IdPerfilesNavigation { get; set; }
    }
}
