using System;
using System.Collections.Generic;

#nullable disable

namespace Dominio.Model
{
    public partial class TblCatSucursales
    {
        public TblCatSucursales()
        {
            TblAreaServLabEmpleados = new HashSet<TblAreaServLabEmpleado>();
            TblMedicos = new HashSet<TblMedico>();
        }

        public Guid IdSucursal { get; set; }
        public Guid IdHospital { get; set; }
        public Guid IdDepartamento { get; set; }
        public Guid IdPais { get; set; }
        public string Descripcion { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string UrlLogo { get; set; }
        public int Estado { get; set; }

        public virtual TblCatDepartamento IdDepartamentoNavigation { get; set; }
        public virtual TblCatHospital IdHospitalNavigation { get; set; }
        public virtual TblCatPais IdPaisNavigation { get; set; }
        public virtual ICollection<TblAreaServLabEmpleado> TblAreaServLabEmpleados { get; set; }
        public virtual ICollection<TblMedico> TblMedicos { get; set; }
    }
}
