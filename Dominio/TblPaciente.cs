using System;
using System.Collections.Generic;

#nullable disable

namespace Dominio.Model
{
    public partial class TblPaciente
    {
        public TblPaciente()
        {
            TblOrdenes = new HashSet<TblOrdenes>();
        }

        public Guid IdPaciente { get; set; }
        public Guid IdIdentificacion { get; set; }
        public string NumIdentificacion { get; set; }
        public string NumInss { get; set; }
        public Guid IdEstadoCivil { get; set; }
        public string Email { get; set; }
        public Guid IdSexo { get; set; }
        public Guid IdPaisNac { get; set; }
        public Guid IdDepartamentoNac { get; set; }
        public Guid IdPaisRes { get; set; }
        public Guid IdDepartamentoRes { get; set; }
        public Guid IdTipoSangre { get; set; }
        public Guid IdProfesiones { get; set; }
        public string PrimerNombre { get; set; }
        public string SegundoNombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public DateTime FechaNac { get; set; }
        public string DireccionDomiciliar { get; set; }
        public string TelefonoDomiciliar { get; set; }
        public string TelefonoMovil { get; set; }
        public Guid Religion { get; set; }
        public string Activo { get; set; }
        public string Emabrazada { get; set; }
        public string Fallecido { get; set; }
        public int Estado { get; set; }

        public virtual TblCatDepartamento IdDepartamentoNacNavigation { get; set; }
        public virtual TblCatDepartamento IdDepartamentoResNavigation { get; set; }
        public virtual TblCatEstadoCivil IdEstadoCivilNavigation { get; set; }
        public virtual TblCatIdentificacion IdIdentificacionNavigation { get; set; }
        public virtual TblCatPais IdPaisNacNavigation { get; set; }
        public virtual TblCatPais IdPaisResNavigation { get; set; }
        public virtual TblCatProfesiones IdProfesionesNavigation { get; set; }
        public virtual TblCatSexo IdSexoNavigation { get; set; }
        public virtual TblCatTipoSangre IdTipoSangreNavigation { get; set; }
        public virtual ICollection<TblOrdenes> TblOrdenes { get; set; }
        public TblCatReligion tblCatReligion { get; set; }
    }
}
