using System;
using System.Collections.Generic;

#nullable disable

namespace Dominio.Model
{
    public partial class TblMedico
    {
        public TblMedico()
        {
            TblOrdenes = new HashSet<TblOrdenes>();
        }

        public Guid IdTblMedico { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public Guid IdtblCatSucursales { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public DateTime? FechaEliminacion { get; set; }
        public Guid IdDepartamentoNac { get; set; }
        public Guid IdDepartamentoRes { get; set; }
        public Guid IdPaisNac { get; set; }
        public Guid IdPaisRes { get; set; }
        public Guid IdIdentificacion { get; set; }
        public Guid IdEstadoCivil { get; set; }
        public Guid IdSexo { get; set; }
        public string NumIdentificacion { get; set; }
        public string CodMinsa { get; set; }
        public DateTime FechaNac { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public string UrlFoto { get; set; }
        public int Estado { get; set; }

        public virtual TblCatDepartamento IdDepartamentoNacNavigation { get; set; }
        public virtual TblCatDepartamento IdDepartamentoResNavigation { get; set; }
        public virtual TblCatEstadoCivil IdEstadoCivilNavigation { get; set; }
        public virtual TblCatIdentificacion IdIdentificacionNavigation { get; set; }
        public virtual TblCatPais IdPaisNacNavigation { get; set; }
        public virtual TblCatPais IdPaisResNavigation { get; set; }
        public virtual TblCatSexo IdSexoNavigation { get; set; }
        public virtual TblCatSucursales IdtblCatSucursalesNavigation { get; set; }
        public virtual ICollection<TblOrdenes> TblOrdenes { get; set; }
    }
}
