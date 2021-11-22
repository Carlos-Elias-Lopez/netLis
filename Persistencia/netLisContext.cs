using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

#nullable disable

namespace Dominio.Model
{
    public partial class netLisContext : IdentityDbContext<TblUsuario>
    {
        public netLisContext(DbContextOptions<netLisContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<TblAreaServLabEmpleado>().HasKey(x => x.IdAreaServLabEmpleados);
            modelBuilder.Entity<TblCatAreasLabServicio>().HasKey(x => x.IdAreaLabServicio);
            modelBuilder.Entity<TblCatAreasServ>().HasKey(x => x.IdAreaServ);
            modelBuilder.Entity<TblCatCategoriaExamenes>().HasKey(x => x.IdCategoriaExamenes);
            modelBuilder.Entity<TblCatDepartamento>().HasKey(x => x.IdDepartamento);
            modelBuilder.Entity<TblCatEstadoCivil>().HasKey(x => x.IdEstadoCivil);
            modelBuilder.Entity<TblCatHospital>().HasKey(x => x.IdHospital);
            modelBuilder.Entity<TblCatIdentificacion>().HasKey(x => x.IdIdentificacion);
            modelBuilder.Entity<TblCatIndicacionExaPaciente>().HasKey(x => x.IdIndicacionExaPaciente);
            modelBuilder.Entity<TblCatMetodologia>().HasKey(x => x.IdMetodologia);
            modelBuilder.Entity<TblCatNacionalidad>().HasKey(x => x.IdNacionalidad);
            modelBuilder.Entity<TblCatOcupaciones>().HasKey(x => x.IdOcupaciones);
            modelBuilder.Entity<TblCatPais>().HasKey(x => x.IdPais);
            modelBuilder.Entity<TblCatPerfiles>().HasKey(x => x.IdPerfiles);
            modelBuilder.Entity<TblCatPerfilesExamenes>().HasKey(x => x.IdPerfilesExamenes);
            modelBuilder.Entity<TblCatProfesiones>().HasKey(x => x.IdProfesiones);
            modelBuilder.Entity<TblCatSexo>().HasKey(x => x.IdSexo);
            modelBuilder.Entity<TblCatReligion>().HasKey(x => x.IdReigion);
            modelBuilder.Entity<TblCatSucursales>().HasKey(x => x.IdSucursal);
            modelBuilder.Entity<TblCatTipoMuestra>().HasKey(x => x.IdTipoMuestra);
            modelBuilder.Entity<TblCatTipoOrden>().HasKey(x => x.IdTipoOrden);
            modelBuilder.Entity<TblCatTipoResultado>().HasKey(x => x.IdTipoResultado);
            modelBuilder.Entity<TblCatTipoSangre>().HasKey(x => x.IdTipoSangre);
            modelBuilder.Entity<TblCatTipoServicio>().HasKey(x => x.IdTipoServicio);
            modelBuilder.Entity<TblCatTipoUsuario>().HasKey(x => x.IdTipoUsuario);
            modelBuilder.Entity<TblCatUnidadMedida>().HasKey(x => x.IdUnidadMedidas);
            modelBuilder.Entity<TblCatValoresNormales>().HasKey(x => x.IdValoresNormales);
            modelBuilder.Entity<TblEmpleado>().HasKey(x => x.IdEmpleado);
            modelBuilder.Entity<TblExamenes>().HasKey(x => x.IdExamen);
            modelBuilder.Entity<TblMedico>().HasKey(x => x.IdTblMedico);
            modelBuilder.Entity<TblOrdenes>().HasKey(x => x.IdOrden);
            modelBuilder.Entity<TblOrdenesDetalle>().HasKey(x => x.IdOrdenDetalle);
            modelBuilder.Entity<TblPaciente>().HasKey(x => x.IdPaciente);
            modelBuilder.Entity<TblResultado>().HasKey(x => x.IdResultados);
        }

        public DbSet<TblAreaServLabEmpleado> TblAreaServLabEmpleados { get; set; }
        public DbSet<TblCatAreasLabServicio> TblCatAreasLabServicios { get; set; }
        public DbSet<TblCatAreasServ> TblCatAreasServs { get; set; }
        public DbSet<TblCatCategoriaExamenes> TblCatCategoriaExamenes { get; set; }
        public DbSet<TblCatDepartamento> TblCatDepartamentos { get; set; }
        public DbSet<TblCatEstadoCivil> TblCatEstadoCivils { get; set; }
        public DbSet<TblCatHospital> TblCatHospitals { get; set; }
        public DbSet<TblCatIdentificacion> TblCatIdentificacions { get; set; }
        public DbSet<TblCatIndicacionExaPaciente> TblCatIndicacionExaPacientes { get; set; }
        public DbSet<TblCatMetodologia> TblCatMetodologia { get; set; }
        public DbSet<TblCatNacionalidad> TblCatNacionalidads { get; set; }
        public DbSet<TblCatOcupaciones> TblCatOcupaciones { get; set; }
        public DbSet<TblCatPais> TblCatPais { get; set; }
        public DbSet<TblCatPerfiles> TblCatPerfiles { get; set; }
        public DbSet<TblCatPerfilesExamenes> TblCatPerfilesExamenes { get; set; }
        public DbSet<TblCatProfesiones> TblCatProfesiones { get; set; }
        public DbSet<TblCatSexo> TblCatSexos { get; set; }
        public DbSet<TblCatSucursales> TblCatSucursales { get; set; }
        public DbSet<TblCatTipoMuestra> TblCatTipoMuestras { get; set; }
        public DbSet<TblCatTipoOrden> TblCatTipoOrdens { get; set; }
        public DbSet<TblCatTipoResultado> TblCatTipoResultados { get; set; }
        public DbSet<TblCatTipoSangre> TblCatTipoSangre { get; set; }
        public DbSet<TblCatReligion> TblCatReligion { get; set; }
        public DbSet<TblCatTipoServicio> TblCatTipoServicios { get; set; }
        public DbSet<TblCatTipoUsuario> TblCatTipoUsuarios { get; set; }
        public DbSet<TblCatUnidadMedida> TblCatUnidadMedidas { get; set; }
        public DbSet<TblCatValoresNormales> TblCatValoresNormales { get; set; }
        public DbSet<TblEmpleado> TblEmpleados { get; set; }
        public DbSet<TblExamenes> TblExamenes { get; set; }
        public DbSet<TblMedico> TblMedicos { get; set; }
        public DbSet<TblOrdenes> TblOrdenes { get; set; }
        public DbSet<TblOrdenesDetalle> TblOrdenesDetalles { get; set; }
        public DbSet<TblPaciente> TblPacientes { get; set; }
        public DbSet<TblResultado> TblResultados { get; set; }
    }
}
