using System;
using System.Collections.Generic;

#nullable disable

namespace Dominio.Model
{
    public partial class TblExamenes
    {
        public TblExamenes()
        {
            TblCatIndicacionExaPacientes = new HashSet<TblCatIndicacionExaPaciente>();
            TblCatPerfilesExamenes = new HashSet<TblCatPerfilesExamenes>();
            TblCatValoresNormales = new HashSet<TblCatValoresNormales>();
            TblOrdenesDetalles = new HashSet<TblOrdenesDetalle>();
            TblResultados = new HashSet<TblResultado>();
        }

        public Guid IdExamen { get; set; }
        public Guid IdAreaLabServicio { get; set; }
        public Guid IdCategoriaExamenes { get; set; }
        public Guid IdTipoMuestra { get; set; }
        public Guid IdUnidadMedidas { get; set; }
        public Guid IdTipoResultado { get; set; }
        public string Descripcion { get; set; }
        public string DescripcionCorta { get; set; }
        public string Confidencial { get; set; }
        public int Estado { get; set; }

        public virtual TblCatAreasLabServicio IdAreaLabServicioNavigation { get; set; }
        public virtual TblCatCategoriaExamenes IdCategoriaExamenesNavigation { get; set; }
        public virtual TblCatTipoMuestra IdTipoMuestraNavigation { get; set; }
        public virtual TblCatTipoResultado IdTipoResultadoNavigation { get; set; }
        public virtual TblCatUnidadMedida IdUnidadMedidasNavigation { get; set; }
        public virtual ICollection<TblCatIndicacionExaPaciente> TblCatIndicacionExaPacientes { get; set; }
        public virtual ICollection<TblCatPerfilesExamenes> TblCatPerfilesExamenes { get; set; }
        public virtual ICollection<TblCatValoresNormales> TblCatValoresNormales { get; set; }
        public virtual ICollection<TblOrdenesDetalle> TblOrdenesDetalles { get; set; }
        public virtual ICollection<TblResultado> TblResultados { get; set; }
    }
}
