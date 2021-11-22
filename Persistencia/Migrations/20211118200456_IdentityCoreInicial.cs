using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistencia.Migrations
{
    public partial class IdentityCoreInicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IdEmpleado = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TblCatAreasLabServicios",
                columns: table => new
                {
                    IdAreaLabServicio = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Estado = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblCatAreasLabServicios", x => x.IdAreaLabServicio);
                });

            migrationBuilder.CreateTable(
                name: "TblCatAreasServs",
                columns: table => new
                {
                    IdAreaServ = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DescripcionCorta = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Estado = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblCatAreasServs", x => x.IdAreaServ);
                });

            migrationBuilder.CreateTable(
                name: "TblCatCategoriaExamenes",
                columns: table => new
                {
                    IdCategoriaExamenes = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Estado = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblCatCategoriaExamenes", x => x.IdCategoriaExamenes);
                });

            migrationBuilder.CreateTable(
                name: "TblCatDepartamentos",
                columns: table => new
                {
                    IdDepartamento = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdPais = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Estado = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblCatDepartamentos", x => x.IdDepartamento);
                });

            migrationBuilder.CreateTable(
                name: "TblCatEstadoCivils",
                columns: table => new
                {
                    IdEstadoCivil = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Estado = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblCatEstadoCivils", x => x.IdEstadoCivil);
                });

            migrationBuilder.CreateTable(
                name: "TblCatHospitals",
                columns: table => new
                {
                    IdHospital = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Estado = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblCatHospitals", x => x.IdHospital);
                });

            migrationBuilder.CreateTable(
                name: "TblCatMetodologia",
                columns: table => new
                {
                    IdMetodologia = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Estado = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblCatMetodologia", x => x.IdMetodologia);
                });

            migrationBuilder.CreateTable(
                name: "TblCatNacionalidads",
                columns: table => new
                {
                    IdNacionalidad = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblCatNacionalidads", x => x.IdNacionalidad);
                });

            migrationBuilder.CreateTable(
                name: "TblCatPais",
                columns: table => new
                {
                    IdPais = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Estado = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblCatPais", x => x.IdPais);
                });

            migrationBuilder.CreateTable(
                name: "TblCatPerfiles",
                columns: table => new
                {
                    IdPerfiles = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Estado = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblCatPerfiles", x => x.IdPerfiles);
                });

            migrationBuilder.CreateTable(
                name: "TblCatProfesiones",
                columns: table => new
                {
                    IdProfesiones = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Estado = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblCatProfesiones", x => x.IdProfesiones);
                });

            migrationBuilder.CreateTable(
                name: "TblCatReligion",
                columns: table => new
                {
                    IdReigion = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblCatReligion", x => x.IdReigion);
                });

            migrationBuilder.CreateTable(
                name: "TblCatSexos",
                columns: table => new
                {
                    IdSexo = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblCatSexos", x => x.IdSexo);
                });

            migrationBuilder.CreateTable(
                name: "TblCatTipoMuestras",
                columns: table => new
                {
                    IdTipoMuestra = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Estado = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblCatTipoMuestras", x => x.IdTipoMuestra);
                });

            migrationBuilder.CreateTable(
                name: "TblCatTipoOrdens",
                columns: table => new
                {
                    IdTipoOrden = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblCatTipoOrdens", x => x.IdTipoOrden);
                });

            migrationBuilder.CreateTable(
                name: "TblCatTipoResultados",
                columns: table => new
                {
                    IdTipoResultado = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblCatTipoResultados", x => x.IdTipoResultado);
                });

            migrationBuilder.CreateTable(
                name: "TblCatTipoSangre",
                columns: table => new
                {
                    IdTipoSangre = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblCatTipoSangre", x => x.IdTipoSangre);
                });

            migrationBuilder.CreateTable(
                name: "TblCatTipoServicios",
                columns: table => new
                {
                    IdTipoServicio = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblCatTipoServicios", x => x.IdTipoServicio);
                });

            migrationBuilder.CreateTable(
                name: "TblCatTipoUsuarios",
                columns: table => new
                {
                    IdTipoUsuario = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblCatTipoUsuarios", x => x.IdTipoUsuario);
                });

            migrationBuilder.CreateTable(
                name: "TblCatUnidadMedidas",
                columns: table => new
                {
                    IdUnidadMedidas = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UnidadMedida = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Estado = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblCatUnidadMedidas", x => x.IdUnidadMedidas);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TblCatIdentificacions",
                columns: table => new
                {
                    IdIdentificacion = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdNacionalidad = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    IdNacionalidadNavigationIdNacionalidad = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblCatIdentificacions", x => x.IdIdentificacion);
                    table.ForeignKey(
                        name: "FK_TblCatIdentificacions_TblCatNacionalidads_IdNacionalidadNavigationIdNacionalidad",
                        column: x => x.IdNacionalidadNavigationIdNacionalidad,
                        principalTable: "TblCatNacionalidads",
                        principalColumn: "IdNacionalidad",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TblCatSucursales",
                columns: table => new
                {
                    IdSucursal = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdHospital = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdDepartamento = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdPais = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefono = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UrlLogo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    IdDepartamentoNavigationIdDepartamento = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdHospitalNavigationIdHospital = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdPaisNavigationIdPais = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblCatSucursales", x => x.IdSucursal);
                    table.ForeignKey(
                        name: "FK_TblCatSucursales_TblCatDepartamentos_IdDepartamentoNavigationIdDepartamento",
                        column: x => x.IdDepartamentoNavigationIdDepartamento,
                        principalTable: "TblCatDepartamentos",
                        principalColumn: "IdDepartamento",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TblCatSucursales_TblCatHospitals_IdHospitalNavigationIdHospital",
                        column: x => x.IdHospitalNavigationIdHospital,
                        principalTable: "TblCatHospitals",
                        principalColumn: "IdHospital",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TblCatSucursales_TblCatPais_IdPaisNavigationIdPais",
                        column: x => x.IdPaisNavigationIdPais,
                        principalTable: "TblCatPais",
                        principalColumn: "IdPais",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TblExamenes",
                columns: table => new
                {
                    IdExamen = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdAreaLabServicio = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdCategoriaExamenes = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdTipoMuestra = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdUnidadMedidas = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdTipoResultado = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DescripcionCorta = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Confidencial = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    IdAreaLabServicioNavigationIdAreaLabServicio = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdCategoriaExamenesNavigationIdCategoriaExamenes = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdTipoMuestraNavigationIdTipoMuestra = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdTipoResultadoNavigationIdTipoResultado = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdUnidadMedidasNavigationIdUnidadMedidas = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblExamenes", x => x.IdExamen);
                    table.ForeignKey(
                        name: "FK_TblExamenes_TblCatAreasLabServicios_IdAreaLabServicioNavigationIdAreaLabServicio",
                        column: x => x.IdAreaLabServicioNavigationIdAreaLabServicio,
                        principalTable: "TblCatAreasLabServicios",
                        principalColumn: "IdAreaLabServicio",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TblExamenes_TblCatCategoriaExamenes_IdCategoriaExamenesNavigationIdCategoriaExamenes",
                        column: x => x.IdCategoriaExamenesNavigationIdCategoriaExamenes,
                        principalTable: "TblCatCategoriaExamenes",
                        principalColumn: "IdCategoriaExamenes",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TblExamenes_TblCatTipoMuestras_IdTipoMuestraNavigationIdTipoMuestra",
                        column: x => x.IdTipoMuestraNavigationIdTipoMuestra,
                        principalTable: "TblCatTipoMuestras",
                        principalColumn: "IdTipoMuestra",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TblExamenes_TblCatTipoResultados_IdTipoResultadoNavigationIdTipoResultado",
                        column: x => x.IdTipoResultadoNavigationIdTipoResultado,
                        principalTable: "TblCatTipoResultados",
                        principalColumn: "IdTipoResultado",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TblExamenes_TblCatUnidadMedidas_IdUnidadMedidasNavigationIdUnidadMedidas",
                        column: x => x.IdUnidadMedidasNavigationIdUnidadMedidas,
                        principalTable: "TblCatUnidadMedidas",
                        principalColumn: "IdUnidadMedidas",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TblEmpleados",
                columns: table => new
                {
                    IdEmpleado = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdProfesiones = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FechaModificacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FechaEliminacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IdDepartamentoNac = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdDepartamentoRes = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdPaisNac = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdPaisRes = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdIdentificacion = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdEstadoCivil = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdSexo = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdNacionalidad = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NumIdentificacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumInss = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CodMinsa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrimerNombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SegundoNombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrimerApellido = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SegundoApellido = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaNac = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EdadIngreso = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DireccionDomiciliar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TelefonoDomiciliar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TelefonoMovil = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaContrato = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UrlFoto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Activo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    UsuarioCrea = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UsuarioModifica = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UsuarioElimina = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdDepartamentoNacNavigationIdDepartamento = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdDepartamentoResNavigationIdDepartamento = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdEstadoCivilNavigationIdEstadoCivil = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdIdentificacionNavigationIdIdentificacion = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdNacionalidadNavigationIdNacionalidad = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdPaisNacNavigationIdPais = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdPaisResNavigationIdPais = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdProfesionesNavigationIdProfesiones = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdSexoNavigationIdSexo = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblEmpleados", x => x.IdEmpleado);
                    table.ForeignKey(
                        name: "FK_TblEmpleados_TblCatDepartamentos_IdDepartamentoNacNavigationIdDepartamento",
                        column: x => x.IdDepartamentoNacNavigationIdDepartamento,
                        principalTable: "TblCatDepartamentos",
                        principalColumn: "IdDepartamento",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TblEmpleados_TblCatDepartamentos_IdDepartamentoResNavigationIdDepartamento",
                        column: x => x.IdDepartamentoResNavigationIdDepartamento,
                        principalTable: "TblCatDepartamentos",
                        principalColumn: "IdDepartamento",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TblEmpleados_TblCatEstadoCivils_IdEstadoCivilNavigationIdEstadoCivil",
                        column: x => x.IdEstadoCivilNavigationIdEstadoCivil,
                        principalTable: "TblCatEstadoCivils",
                        principalColumn: "IdEstadoCivil",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TblEmpleados_TblCatIdentificacions_IdIdentificacionNavigationIdIdentificacion",
                        column: x => x.IdIdentificacionNavigationIdIdentificacion,
                        principalTable: "TblCatIdentificacions",
                        principalColumn: "IdIdentificacion",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TblEmpleados_TblCatNacionalidads_IdNacionalidadNavigationIdNacionalidad",
                        column: x => x.IdNacionalidadNavigationIdNacionalidad,
                        principalTable: "TblCatNacionalidads",
                        principalColumn: "IdNacionalidad",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TblEmpleados_TblCatPais_IdPaisNacNavigationIdPais",
                        column: x => x.IdPaisNacNavigationIdPais,
                        principalTable: "TblCatPais",
                        principalColumn: "IdPais",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TblEmpleados_TblCatPais_IdPaisResNavigationIdPais",
                        column: x => x.IdPaisResNavigationIdPais,
                        principalTable: "TblCatPais",
                        principalColumn: "IdPais",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TblEmpleados_TblCatProfesiones_IdProfesionesNavigationIdProfesiones",
                        column: x => x.IdProfesionesNavigationIdProfesiones,
                        principalTable: "TblCatProfesiones",
                        principalColumn: "IdProfesiones",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TblEmpleados_TblCatSexos_IdSexoNavigationIdSexo",
                        column: x => x.IdSexoNavigationIdSexo,
                        principalTable: "TblCatSexos",
                        principalColumn: "IdSexo",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TblPacientes",
                columns: table => new
                {
                    IdPaciente = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdIdentificacion = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NumIdentificacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumInss = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdEstadoCivil = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdSexo = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdPaisNac = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdDepartamentoNac = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdPaisRes = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdDepartamentoRes = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdTipoSangre = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdProfesiones = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PrimerNombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SegundoNombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrimerApellido = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SegundoApellido = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaNac = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DireccionDomiciliar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TelefonoDomiciliar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TelefonoMovil = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Religion = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Activo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Emabrazada = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fallecido = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    IdDepartamentoNacNavigationIdDepartamento = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdDepartamentoResNavigationIdDepartamento = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdEstadoCivilNavigationIdEstadoCivil = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdIdentificacionNavigationIdIdentificacion = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdPaisNacNavigationIdPais = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdPaisResNavigationIdPais = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdProfesionesNavigationIdProfesiones = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdSexoNavigationIdSexo = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdTipoSangreNavigationIdTipoSangre = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    tblCatReligionIdReigion = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblPacientes", x => x.IdPaciente);
                    table.ForeignKey(
                        name: "FK_TblPacientes_TblCatDepartamentos_IdDepartamentoNacNavigationIdDepartamento",
                        column: x => x.IdDepartamentoNacNavigationIdDepartamento,
                        principalTable: "TblCatDepartamentos",
                        principalColumn: "IdDepartamento",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TblPacientes_TblCatDepartamentos_IdDepartamentoResNavigationIdDepartamento",
                        column: x => x.IdDepartamentoResNavigationIdDepartamento,
                        principalTable: "TblCatDepartamentos",
                        principalColumn: "IdDepartamento",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TblPacientes_TblCatEstadoCivils_IdEstadoCivilNavigationIdEstadoCivil",
                        column: x => x.IdEstadoCivilNavigationIdEstadoCivil,
                        principalTable: "TblCatEstadoCivils",
                        principalColumn: "IdEstadoCivil",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TblPacientes_TblCatIdentificacions_IdIdentificacionNavigationIdIdentificacion",
                        column: x => x.IdIdentificacionNavigationIdIdentificacion,
                        principalTable: "TblCatIdentificacions",
                        principalColumn: "IdIdentificacion",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TblPacientes_TblCatPais_IdPaisNacNavigationIdPais",
                        column: x => x.IdPaisNacNavigationIdPais,
                        principalTable: "TblCatPais",
                        principalColumn: "IdPais",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TblPacientes_TblCatPais_IdPaisResNavigationIdPais",
                        column: x => x.IdPaisResNavigationIdPais,
                        principalTable: "TblCatPais",
                        principalColumn: "IdPais",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TblPacientes_TblCatProfesiones_IdProfesionesNavigationIdProfesiones",
                        column: x => x.IdProfesionesNavigationIdProfesiones,
                        principalTable: "TblCatProfesiones",
                        principalColumn: "IdProfesiones",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TblPacientes_TblCatReligion_tblCatReligionIdReigion",
                        column: x => x.tblCatReligionIdReigion,
                        principalTable: "TblCatReligion",
                        principalColumn: "IdReigion",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TblPacientes_TblCatSexos_IdSexoNavigationIdSexo",
                        column: x => x.IdSexoNavigationIdSexo,
                        principalTable: "TblCatSexos",
                        principalColumn: "IdSexo",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TblPacientes_TblCatTipoSangre_IdTipoSangreNavigationIdTipoSangre",
                        column: x => x.IdTipoSangreNavigationIdTipoSangre,
                        principalTable: "TblCatTipoSangre",
                        principalColumn: "IdTipoSangre",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TblMedicos",
                columns: table => new
                {
                    IdTblMedico = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nombres = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Apellidos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdtblCatSucursales = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FechaEliminacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IdDepartamentoNac = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdDepartamentoRes = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdPaisNac = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdPaisRes = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdIdentificacion = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdEstadoCivil = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdSexo = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NumIdentificacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CodMinsa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaNac = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefono = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UrlFoto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    IdDepartamentoNacNavigationIdDepartamento = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdDepartamentoResNavigationIdDepartamento = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdEstadoCivilNavigationIdEstadoCivil = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdIdentificacionNavigationIdIdentificacion = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdPaisNacNavigationIdPais = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdPaisResNavigationIdPais = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdSexoNavigationIdSexo = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdtblCatSucursalesNavigationIdSucursal = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblMedicos", x => x.IdTblMedico);
                    table.ForeignKey(
                        name: "FK_TblMedicos_TblCatDepartamentos_IdDepartamentoNacNavigationIdDepartamento",
                        column: x => x.IdDepartamentoNacNavigationIdDepartamento,
                        principalTable: "TblCatDepartamentos",
                        principalColumn: "IdDepartamento",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TblMedicos_TblCatDepartamentos_IdDepartamentoResNavigationIdDepartamento",
                        column: x => x.IdDepartamentoResNavigationIdDepartamento,
                        principalTable: "TblCatDepartamentos",
                        principalColumn: "IdDepartamento",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TblMedicos_TblCatEstadoCivils_IdEstadoCivilNavigationIdEstadoCivil",
                        column: x => x.IdEstadoCivilNavigationIdEstadoCivil,
                        principalTable: "TblCatEstadoCivils",
                        principalColumn: "IdEstadoCivil",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TblMedicos_TblCatIdentificacions_IdIdentificacionNavigationIdIdentificacion",
                        column: x => x.IdIdentificacionNavigationIdIdentificacion,
                        principalTable: "TblCatIdentificacions",
                        principalColumn: "IdIdentificacion",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TblMedicos_TblCatPais_IdPaisNacNavigationIdPais",
                        column: x => x.IdPaisNacNavigationIdPais,
                        principalTable: "TblCatPais",
                        principalColumn: "IdPais",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TblMedicos_TblCatPais_IdPaisResNavigationIdPais",
                        column: x => x.IdPaisResNavigationIdPais,
                        principalTable: "TblCatPais",
                        principalColumn: "IdPais",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TblMedicos_TblCatSexos_IdSexoNavigationIdSexo",
                        column: x => x.IdSexoNavigationIdSexo,
                        principalTable: "TblCatSexos",
                        principalColumn: "IdSexo",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TblMedicos_TblCatSucursales_IdtblCatSucursalesNavigationIdSucursal",
                        column: x => x.IdtblCatSucursalesNavigationIdSucursal,
                        principalTable: "TblCatSucursales",
                        principalColumn: "IdSucursal",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TblCatIndicacionExaPacientes",
                columns: table => new
                {
                    IdIndicacionExaPaciente = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdExamen = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Indicacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdExamenNavigationIdExamen = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblCatIndicacionExaPacientes", x => x.IdIndicacionExaPaciente);
                    table.ForeignKey(
                        name: "FK_TblCatIndicacionExaPacientes_TblExamenes_IdExamenNavigationIdExamen",
                        column: x => x.IdExamenNavigationIdExamen,
                        principalTable: "TblExamenes",
                        principalColumn: "IdExamen",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TblCatPerfilesExamenes",
                columns: table => new
                {
                    IdPerfilesExamenes = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdExamen = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdPerfiles = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdExamenNavigationIdExamen = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdPerfilesNavigationIdPerfiles = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblCatPerfilesExamenes", x => x.IdPerfilesExamenes);
                    table.ForeignKey(
                        name: "FK_TblCatPerfilesExamenes_TblCatPerfiles_IdPerfilesNavigationIdPerfiles",
                        column: x => x.IdPerfilesNavigationIdPerfiles,
                        principalTable: "TblCatPerfiles",
                        principalColumn: "IdPerfiles",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TblCatPerfilesExamenes_TblExamenes_IdExamenNavigationIdExamen",
                        column: x => x.IdExamenNavigationIdExamen,
                        principalTable: "TblExamenes",
                        principalColumn: "IdExamen",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TblCatValoresNormales",
                columns: table => new
                {
                    IdValoresNormales = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdExamen = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdSexo = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RangoAlto = table.Column<double>(type: "float", nullable: false),
                    RangoBajo = table.Column<double>(type: "float", nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    IdExamenNavigationIdExamen = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdSexoNavigationIdSexo = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblCatValoresNormales", x => x.IdValoresNormales);
                    table.ForeignKey(
                        name: "FK_TblCatValoresNormales_TblCatSexos_IdSexoNavigationIdSexo",
                        column: x => x.IdSexoNavigationIdSexo,
                        principalTable: "TblCatSexos",
                        principalColumn: "IdSexo",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TblCatValoresNormales_TblExamenes_IdExamenNavigationIdExamen",
                        column: x => x.IdExamenNavigationIdExamen,
                        principalTable: "TblExamenes",
                        principalColumn: "IdExamen",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TblAreaServLabEmpleados",
                columns: table => new
                {
                    IdAreaServLabEmpleados = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdAreaLabServicio = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdEmpleado = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdSucursal = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdAreaLabServicioNavigationIdAreaLabServicio = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdEmpleadoNavigationIdEmpleado = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdSucursalNavigationIdSucursal = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblAreaServLabEmpleados", x => x.IdAreaServLabEmpleados);
                    table.ForeignKey(
                        name: "FK_TblAreaServLabEmpleados_TblCatAreasLabServicios_IdAreaLabServicioNavigationIdAreaLabServicio",
                        column: x => x.IdAreaLabServicioNavigationIdAreaLabServicio,
                        principalTable: "TblCatAreasLabServicios",
                        principalColumn: "IdAreaLabServicio",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TblAreaServLabEmpleados_TblCatSucursales_IdSucursalNavigationIdSucursal",
                        column: x => x.IdSucursalNavigationIdSucursal,
                        principalTable: "TblCatSucursales",
                        principalColumn: "IdSucursal",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TblAreaServLabEmpleados_TblEmpleados_IdEmpleadoNavigationIdEmpleado",
                        column: x => x.IdEmpleadoNavigationIdEmpleado,
                        principalTable: "TblEmpleados",
                        principalColumn: "IdEmpleado",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TblCatOcupaciones",
                columns: table => new
                {
                    IdOcupaciones = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdEmpleado = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdProfesiones = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdEmpleadoNavigationIdEmpleado = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdProfesionesNavigationIdProfesiones = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblCatOcupaciones", x => x.IdOcupaciones);
                    table.ForeignKey(
                        name: "FK_TblCatOcupaciones_TblCatProfesiones_IdProfesionesNavigationIdProfesiones",
                        column: x => x.IdProfesionesNavigationIdProfesiones,
                        principalTable: "TblCatProfesiones",
                        principalColumn: "IdProfesiones",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TblCatOcupaciones_TblEmpleados_IdEmpleadoNavigationIdEmpleado",
                        column: x => x.IdEmpleadoNavigationIdEmpleado,
                        principalTable: "TblEmpleados",
                        principalColumn: "IdEmpleado",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TblOrdenes",
                columns: table => new
                {
                    IdOrden = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NOrden = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdtblMedico = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdPaciente = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdTipoServicio = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdTipoOrden = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Asistencia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Observaciones = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaOrden = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Activo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaImprime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UsuarioImprime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    Finalizado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaCita = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FechaPreporte = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdPacienteNavigationIdPaciente = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdTipoOrdenNavigationIdTipoOrden = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdTipoServicioNavigationIdTipoServicio = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdtblMedicoNavigationIdTblMedico = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblOrdenes", x => x.IdOrden);
                    table.ForeignKey(
                        name: "FK_TblOrdenes_TblCatTipoOrdens_IdTipoOrdenNavigationIdTipoOrden",
                        column: x => x.IdTipoOrdenNavigationIdTipoOrden,
                        principalTable: "TblCatTipoOrdens",
                        principalColumn: "IdTipoOrden",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TblOrdenes_TblCatTipoServicios_IdTipoServicioNavigationIdTipoServicio",
                        column: x => x.IdTipoServicioNavigationIdTipoServicio,
                        principalTable: "TblCatTipoServicios",
                        principalColumn: "IdTipoServicio",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TblOrdenes_TblMedicos_IdtblMedicoNavigationIdTblMedico",
                        column: x => x.IdtblMedicoNavigationIdTblMedico,
                        principalTable: "TblMedicos",
                        principalColumn: "IdTblMedico",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TblOrdenes_TblPacientes_IdPacienteNavigationIdPaciente",
                        column: x => x.IdPacienteNavigationIdPaciente,
                        principalTable: "TblPacientes",
                        principalColumn: "IdPaciente",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TblOrdenesDetalles",
                columns: table => new
                {
                    IdOrdenDetalle = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdOrden = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NOrden = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdExamen = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Activo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdExamenNavigationIdExamen = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdOrdenNavigationIdOrden = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblOrdenesDetalles", x => x.IdOrdenDetalle);
                    table.ForeignKey(
                        name: "FK_TblOrdenesDetalles_TblExamenes_IdExamenNavigationIdExamen",
                        column: x => x.IdExamenNavigationIdExamen,
                        principalTable: "TblExamenes",
                        principalColumn: "IdExamen",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TblOrdenesDetalles_TblOrdenes_IdOrdenNavigationIdOrden",
                        column: x => x.IdOrdenNavigationIdOrden,
                        principalTable: "TblOrdenes",
                        principalColumn: "IdOrden",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TblResultados",
                columns: table => new
                {
                    IdResultados = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdExamen = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdOrden = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Resultado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Observaciones = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Procesado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaProcesa = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UsuarioProcesa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Validado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaValida = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UsuarioValida = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Impreso = table.Column<int>(type: "int", nullable: true),
                    FechaImprime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UsuarioImprime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    IdExamenNavigationIdExamen = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdOrdenNavigationIdOrden = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblResultados", x => x.IdResultados);
                    table.ForeignKey(
                        name: "FK_TblResultados_TblExamenes_IdExamenNavigationIdExamen",
                        column: x => x.IdExamenNavigationIdExamen,
                        principalTable: "TblExamenes",
                        principalColumn: "IdExamen",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TblResultados_TblOrdenes_IdOrdenNavigationIdOrden",
                        column: x => x.IdOrdenNavigationIdOrden,
                        principalTable: "TblOrdenes",
                        principalColumn: "IdOrden",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_TblAreaServLabEmpleados_IdAreaLabServicioNavigationIdAreaLabServicio",
                table: "TblAreaServLabEmpleados",
                column: "IdAreaLabServicioNavigationIdAreaLabServicio");

            migrationBuilder.CreateIndex(
                name: "IX_TblAreaServLabEmpleados_IdEmpleadoNavigationIdEmpleado",
                table: "TblAreaServLabEmpleados",
                column: "IdEmpleadoNavigationIdEmpleado");

            migrationBuilder.CreateIndex(
                name: "IX_TblAreaServLabEmpleados_IdSucursalNavigationIdSucursal",
                table: "TblAreaServLabEmpleados",
                column: "IdSucursalNavigationIdSucursal");

            migrationBuilder.CreateIndex(
                name: "IX_TblCatIdentificacions_IdNacionalidadNavigationIdNacionalidad",
                table: "TblCatIdentificacions",
                column: "IdNacionalidadNavigationIdNacionalidad");

            migrationBuilder.CreateIndex(
                name: "IX_TblCatIndicacionExaPacientes_IdExamenNavigationIdExamen",
                table: "TblCatIndicacionExaPacientes",
                column: "IdExamenNavigationIdExamen");

            migrationBuilder.CreateIndex(
                name: "IX_TblCatOcupaciones_IdEmpleadoNavigationIdEmpleado",
                table: "TblCatOcupaciones",
                column: "IdEmpleadoNavigationIdEmpleado");

            migrationBuilder.CreateIndex(
                name: "IX_TblCatOcupaciones_IdProfesionesNavigationIdProfesiones",
                table: "TblCatOcupaciones",
                column: "IdProfesionesNavigationIdProfesiones");

            migrationBuilder.CreateIndex(
                name: "IX_TblCatPerfilesExamenes_IdExamenNavigationIdExamen",
                table: "TblCatPerfilesExamenes",
                column: "IdExamenNavigationIdExamen");

            migrationBuilder.CreateIndex(
                name: "IX_TblCatPerfilesExamenes_IdPerfilesNavigationIdPerfiles",
                table: "TblCatPerfilesExamenes",
                column: "IdPerfilesNavigationIdPerfiles");

            migrationBuilder.CreateIndex(
                name: "IX_TblCatSucursales_IdDepartamentoNavigationIdDepartamento",
                table: "TblCatSucursales",
                column: "IdDepartamentoNavigationIdDepartamento");

            migrationBuilder.CreateIndex(
                name: "IX_TblCatSucursales_IdHospitalNavigationIdHospital",
                table: "TblCatSucursales",
                column: "IdHospitalNavigationIdHospital");

            migrationBuilder.CreateIndex(
                name: "IX_TblCatSucursales_IdPaisNavigationIdPais",
                table: "TblCatSucursales",
                column: "IdPaisNavigationIdPais");

            migrationBuilder.CreateIndex(
                name: "IX_TblCatValoresNormales_IdExamenNavigationIdExamen",
                table: "TblCatValoresNormales",
                column: "IdExamenNavigationIdExamen");

            migrationBuilder.CreateIndex(
                name: "IX_TblCatValoresNormales_IdSexoNavigationIdSexo",
                table: "TblCatValoresNormales",
                column: "IdSexoNavigationIdSexo");

            migrationBuilder.CreateIndex(
                name: "IX_TblEmpleados_IdDepartamentoNacNavigationIdDepartamento",
                table: "TblEmpleados",
                column: "IdDepartamentoNacNavigationIdDepartamento");

            migrationBuilder.CreateIndex(
                name: "IX_TblEmpleados_IdDepartamentoResNavigationIdDepartamento",
                table: "TblEmpleados",
                column: "IdDepartamentoResNavigationIdDepartamento");

            migrationBuilder.CreateIndex(
                name: "IX_TblEmpleados_IdEstadoCivilNavigationIdEstadoCivil",
                table: "TblEmpleados",
                column: "IdEstadoCivilNavigationIdEstadoCivil");

            migrationBuilder.CreateIndex(
                name: "IX_TblEmpleados_IdIdentificacionNavigationIdIdentificacion",
                table: "TblEmpleados",
                column: "IdIdentificacionNavigationIdIdentificacion");

            migrationBuilder.CreateIndex(
                name: "IX_TblEmpleados_IdNacionalidadNavigationIdNacionalidad",
                table: "TblEmpleados",
                column: "IdNacionalidadNavigationIdNacionalidad");

            migrationBuilder.CreateIndex(
                name: "IX_TblEmpleados_IdPaisNacNavigationIdPais",
                table: "TblEmpleados",
                column: "IdPaisNacNavigationIdPais");

            migrationBuilder.CreateIndex(
                name: "IX_TblEmpleados_IdPaisResNavigationIdPais",
                table: "TblEmpleados",
                column: "IdPaisResNavigationIdPais");

            migrationBuilder.CreateIndex(
                name: "IX_TblEmpleados_IdProfesionesNavigationIdProfesiones",
                table: "TblEmpleados",
                column: "IdProfesionesNavigationIdProfesiones");

            migrationBuilder.CreateIndex(
                name: "IX_TblEmpleados_IdSexoNavigationIdSexo",
                table: "TblEmpleados",
                column: "IdSexoNavigationIdSexo");

            migrationBuilder.CreateIndex(
                name: "IX_TblExamenes_IdAreaLabServicioNavigationIdAreaLabServicio",
                table: "TblExamenes",
                column: "IdAreaLabServicioNavigationIdAreaLabServicio");

            migrationBuilder.CreateIndex(
                name: "IX_TblExamenes_IdCategoriaExamenesNavigationIdCategoriaExamenes",
                table: "TblExamenes",
                column: "IdCategoriaExamenesNavigationIdCategoriaExamenes");

            migrationBuilder.CreateIndex(
                name: "IX_TblExamenes_IdTipoMuestraNavigationIdTipoMuestra",
                table: "TblExamenes",
                column: "IdTipoMuestraNavigationIdTipoMuestra");

            migrationBuilder.CreateIndex(
                name: "IX_TblExamenes_IdTipoResultadoNavigationIdTipoResultado",
                table: "TblExamenes",
                column: "IdTipoResultadoNavigationIdTipoResultado");

            migrationBuilder.CreateIndex(
                name: "IX_TblExamenes_IdUnidadMedidasNavigationIdUnidadMedidas",
                table: "TblExamenes",
                column: "IdUnidadMedidasNavigationIdUnidadMedidas");

            migrationBuilder.CreateIndex(
                name: "IX_TblMedicos_IdDepartamentoNacNavigationIdDepartamento",
                table: "TblMedicos",
                column: "IdDepartamentoNacNavigationIdDepartamento");

            migrationBuilder.CreateIndex(
                name: "IX_TblMedicos_IdDepartamentoResNavigationIdDepartamento",
                table: "TblMedicos",
                column: "IdDepartamentoResNavigationIdDepartamento");

            migrationBuilder.CreateIndex(
                name: "IX_TblMedicos_IdEstadoCivilNavigationIdEstadoCivil",
                table: "TblMedicos",
                column: "IdEstadoCivilNavigationIdEstadoCivil");

            migrationBuilder.CreateIndex(
                name: "IX_TblMedicos_IdIdentificacionNavigationIdIdentificacion",
                table: "TblMedicos",
                column: "IdIdentificacionNavigationIdIdentificacion");

            migrationBuilder.CreateIndex(
                name: "IX_TblMedicos_IdPaisNacNavigationIdPais",
                table: "TblMedicos",
                column: "IdPaisNacNavigationIdPais");

            migrationBuilder.CreateIndex(
                name: "IX_TblMedicos_IdPaisResNavigationIdPais",
                table: "TblMedicos",
                column: "IdPaisResNavigationIdPais");

            migrationBuilder.CreateIndex(
                name: "IX_TblMedicos_IdSexoNavigationIdSexo",
                table: "TblMedicos",
                column: "IdSexoNavigationIdSexo");

            migrationBuilder.CreateIndex(
                name: "IX_TblMedicos_IdtblCatSucursalesNavigationIdSucursal",
                table: "TblMedicos",
                column: "IdtblCatSucursalesNavigationIdSucursal");

            migrationBuilder.CreateIndex(
                name: "IX_TblOrdenes_IdPacienteNavigationIdPaciente",
                table: "TblOrdenes",
                column: "IdPacienteNavigationIdPaciente");

            migrationBuilder.CreateIndex(
                name: "IX_TblOrdenes_IdtblMedicoNavigationIdTblMedico",
                table: "TblOrdenes",
                column: "IdtblMedicoNavigationIdTblMedico");

            migrationBuilder.CreateIndex(
                name: "IX_TblOrdenes_IdTipoOrdenNavigationIdTipoOrden",
                table: "TblOrdenes",
                column: "IdTipoOrdenNavigationIdTipoOrden");

            migrationBuilder.CreateIndex(
                name: "IX_TblOrdenes_IdTipoServicioNavigationIdTipoServicio",
                table: "TblOrdenes",
                column: "IdTipoServicioNavigationIdTipoServicio");

            migrationBuilder.CreateIndex(
                name: "IX_TblOrdenesDetalles_IdExamenNavigationIdExamen",
                table: "TblOrdenesDetalles",
                column: "IdExamenNavigationIdExamen");

            migrationBuilder.CreateIndex(
                name: "IX_TblOrdenesDetalles_IdOrdenNavigationIdOrden",
                table: "TblOrdenesDetalles",
                column: "IdOrdenNavigationIdOrden");

            migrationBuilder.CreateIndex(
                name: "IX_TblPacientes_IdDepartamentoNacNavigationIdDepartamento",
                table: "TblPacientes",
                column: "IdDepartamentoNacNavigationIdDepartamento");

            migrationBuilder.CreateIndex(
                name: "IX_TblPacientes_IdDepartamentoResNavigationIdDepartamento",
                table: "TblPacientes",
                column: "IdDepartamentoResNavigationIdDepartamento");

            migrationBuilder.CreateIndex(
                name: "IX_TblPacientes_IdEstadoCivilNavigationIdEstadoCivil",
                table: "TblPacientes",
                column: "IdEstadoCivilNavigationIdEstadoCivil");

            migrationBuilder.CreateIndex(
                name: "IX_TblPacientes_IdIdentificacionNavigationIdIdentificacion",
                table: "TblPacientes",
                column: "IdIdentificacionNavigationIdIdentificacion");

            migrationBuilder.CreateIndex(
                name: "IX_TblPacientes_IdPaisNacNavigationIdPais",
                table: "TblPacientes",
                column: "IdPaisNacNavigationIdPais");

            migrationBuilder.CreateIndex(
                name: "IX_TblPacientes_IdPaisResNavigationIdPais",
                table: "TblPacientes",
                column: "IdPaisResNavigationIdPais");

            migrationBuilder.CreateIndex(
                name: "IX_TblPacientes_IdProfesionesNavigationIdProfesiones",
                table: "TblPacientes",
                column: "IdProfesionesNavigationIdProfesiones");

            migrationBuilder.CreateIndex(
                name: "IX_TblPacientes_IdSexoNavigationIdSexo",
                table: "TblPacientes",
                column: "IdSexoNavigationIdSexo");

            migrationBuilder.CreateIndex(
                name: "IX_TblPacientes_IdTipoSangreNavigationIdTipoSangre",
                table: "TblPacientes",
                column: "IdTipoSangreNavigationIdTipoSangre");

            migrationBuilder.CreateIndex(
                name: "IX_TblPacientes_tblCatReligionIdReigion",
                table: "TblPacientes",
                column: "tblCatReligionIdReigion");

            migrationBuilder.CreateIndex(
                name: "IX_TblResultados_IdExamenNavigationIdExamen",
                table: "TblResultados",
                column: "IdExamenNavigationIdExamen");

            migrationBuilder.CreateIndex(
                name: "IX_TblResultados_IdOrdenNavigationIdOrden",
                table: "TblResultados",
                column: "IdOrdenNavigationIdOrden");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "TblAreaServLabEmpleados");

            migrationBuilder.DropTable(
                name: "TblCatAreasServs");

            migrationBuilder.DropTable(
                name: "TblCatIndicacionExaPacientes");

            migrationBuilder.DropTable(
                name: "TblCatMetodologia");

            migrationBuilder.DropTable(
                name: "TblCatOcupaciones");

            migrationBuilder.DropTable(
                name: "TblCatPerfilesExamenes");

            migrationBuilder.DropTable(
                name: "TblCatTipoUsuarios");

            migrationBuilder.DropTable(
                name: "TblCatValoresNormales");

            migrationBuilder.DropTable(
                name: "TblOrdenesDetalles");

            migrationBuilder.DropTable(
                name: "TblResultados");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "TblEmpleados");

            migrationBuilder.DropTable(
                name: "TblCatPerfiles");

            migrationBuilder.DropTable(
                name: "TblExamenes");

            migrationBuilder.DropTable(
                name: "TblOrdenes");

            migrationBuilder.DropTable(
                name: "TblCatAreasLabServicios");

            migrationBuilder.DropTable(
                name: "TblCatCategoriaExamenes");

            migrationBuilder.DropTable(
                name: "TblCatTipoMuestras");

            migrationBuilder.DropTable(
                name: "TblCatTipoResultados");

            migrationBuilder.DropTable(
                name: "TblCatUnidadMedidas");

            migrationBuilder.DropTable(
                name: "TblCatTipoOrdens");

            migrationBuilder.DropTable(
                name: "TblCatTipoServicios");

            migrationBuilder.DropTable(
                name: "TblMedicos");

            migrationBuilder.DropTable(
                name: "TblPacientes");

            migrationBuilder.DropTable(
                name: "TblCatSucursales");

            migrationBuilder.DropTable(
                name: "TblCatEstadoCivils");

            migrationBuilder.DropTable(
                name: "TblCatIdentificacions");

            migrationBuilder.DropTable(
                name: "TblCatProfesiones");

            migrationBuilder.DropTable(
                name: "TblCatReligion");

            migrationBuilder.DropTable(
                name: "TblCatSexos");

            migrationBuilder.DropTable(
                name: "TblCatTipoSangre");

            migrationBuilder.DropTable(
                name: "TblCatDepartamentos");

            migrationBuilder.DropTable(
                name: "TblCatHospitals");

            migrationBuilder.DropTable(
                name: "TblCatPais");

            migrationBuilder.DropTable(
                name: "TblCatNacionalidads");
        }
    }
}
