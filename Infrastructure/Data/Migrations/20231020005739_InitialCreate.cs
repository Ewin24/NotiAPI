using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Auditoria",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FechaCreacion = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DescAccion = table.Column<long>(type: "bigint", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    NombreUsuario = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Auditoria", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "estadonotificacion",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FechaCreacion = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Nombreestado = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_estadonotificacion", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "formatos",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FechaCreacion = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    NombreFormato = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_formatos", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "HiloRespuestaNotificacion",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FechaCreacion = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    NombreTipo = table.Column<string>(type: "varchar(80)", maxLength: 80, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HiloRespuestaNotificacion", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "modulosmaestros",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FechaCreacion = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    NombreModulo = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_modulosmaestros", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "permisosgenericos",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FechaCreacion = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    nombrePermiso = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_permisosgenericos", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "radicados",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FechaCreacion = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_radicados", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "rol",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FechaCreacion = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Nombre = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_rol", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "submodulos",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FechaCreacion = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    NombreSubmodulo = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_submodulos", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TipoNotificaciones",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FechaCreacion = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    NombreTipo = table.Column<string>(type: "varchar(80)", maxLength: 80, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoNotificaciones", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "tiporequerimiento",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FechaCreacion = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Nombre = table.Column<string>(type: "varchar(80)", maxLength: 80, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tiporequerimiento", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "rolvsmaestro",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IdRol = table.Column<long>(type: "bigint", nullable: false),
                    IdMaestro = table.Column<long>(type: "bigint", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_rolvsmaestro", x => x.Id);
                    table.ForeignKey(
                        name: "FK_rolvsmaestro_modulosmaestros_IdMaestro",
                        column: x => x.IdMaestro,
                        principalTable: "modulosmaestros",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_rolvsmaestro_rol_IdRol",
                        column: x => x.IdRol,
                        principalTable: "rol",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "maestrosvssubmodulos",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IdMaestro = table.Column<long>(type: "bigint", nullable: false),
                    IdSubmodulo = table.Column<long>(type: "bigint", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_maestrosvssubmodulos", x => x.id);
                    table.ForeignKey(
                        name: "FK_maestrosvssubmodulos_modulosmaestros_IdMaestro",
                        column: x => x.IdMaestro,
                        principalTable: "modulosmaestros",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_maestrosvssubmodulos_submodulos_IdSubmodulo",
                        column: x => x.IdSubmodulo,
                        principalTable: "submodulos",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Blockchain",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FechaCreacion = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    HashGenerado = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdAuditoria = table.Column<long>(type: "bigint", nullable: false),
                    IdHiloRespuesta = table.Column<long>(type: "bigint", nullable: false),
                    IdTipoNotificaciones = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blockchain", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Blockchain_Auditoria_IdAuditoria",
                        column: x => x.IdAuditoria,
                        principalTable: "Auditoria",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Blockchain_HiloRespuestaNotificacion_IdHiloRespuesta",
                        column: x => x.IdHiloRespuesta,
                        principalTable: "HiloRespuestaNotificacion",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Blockchain_TipoNotificaciones_IdTipoNotificaciones",
                        column: x => x.IdTipoNotificaciones,
                        principalTable: "TipoNotificaciones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ModuloNotificaciones",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IdRadicado = table.Column<long>(type: "bigint", nullable: false),
                    IdEstadoNotificacion = table.Column<long>(type: "bigint", nullable: false),
                    IdhiloRespuesta = table.Column<long>(type: "bigint", nullable: false),
                    IdFormato = table.Column<long>(type: "bigint", nullable: false),
                    IdRequerimiento = table.Column<long>(type: "bigint", nullable: false),
                    AsuntoNotificacion = table.Column<string>(type: "varchar(80)", maxLength: 80, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FechaCreacion = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    IdTipoNotificacion = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModuloNotificaciones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ModuloNotificaciones_HiloRespuestaNotificacion_IdhiloRespues~",
                        column: x => x.IdhiloRespuesta,
                        principalTable: "HiloRespuestaNotificacion",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ModuloNotificaciones_TipoNotificaciones_IdTipoNotificacion",
                        column: x => x.IdTipoNotificacion,
                        principalTable: "TipoNotificaciones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ModuloNotificaciones_estadonotificacion_IdEstadoNotificacion",
                        column: x => x.IdEstadoNotificacion,
                        principalTable: "estadonotificacion",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ModuloNotificaciones_formatos_IdFormato",
                        column: x => x.IdFormato,
                        principalTable: "formatos",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ModuloNotificaciones_radicados_IdRadicado",
                        column: x => x.IdRadicado,
                        principalTable: "radicados",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ModuloNotificaciones_tiporequerimiento_IdRequerimiento",
                        column: x => x.IdRequerimiento,
                        principalTable: "tiporequerimiento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "genericosvssubmodulos",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    idGenericos = table.Column<long>(type: "bigint", nullable: false),
                    idSubmodulos = table.Column<long>(type: "bigint", nullable: false),
                    idRol = table.Column<long>(type: "bigint", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_genericosvssubmodulos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_genericosvssubmodulos_maestrosvssubmodulos_idSubmodulos",
                        column: x => x.idSubmodulos,
                        principalTable: "maestrosvssubmodulos",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_genericosvssubmodulos_permisosgenericos_idGenericos",
                        column: x => x.idGenericos,
                        principalTable: "permisosgenericos",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_genericosvssubmodulos_rol_idRol",
                        column: x => x.idRol,
                        principalTable: "rol",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Blockchain_IdAuditoria",
                table: "Blockchain",
                column: "IdAuditoria");

            migrationBuilder.CreateIndex(
                name: "IX_Blockchain_IdHiloRespuesta",
                table: "Blockchain",
                column: "IdHiloRespuesta");

            migrationBuilder.CreateIndex(
                name: "IX_Blockchain_IdTipoNotificaciones",
                table: "Blockchain",
                column: "IdTipoNotificaciones");

            migrationBuilder.CreateIndex(
                name: "IX_genericosvssubmodulos_idGenericos",
                table: "genericosvssubmodulos",
                column: "idGenericos");

            migrationBuilder.CreateIndex(
                name: "IX_genericosvssubmodulos_idRol",
                table: "genericosvssubmodulos",
                column: "idRol");

            migrationBuilder.CreateIndex(
                name: "IX_genericosvssubmodulos_idSubmodulos",
                table: "genericosvssubmodulos",
                column: "idSubmodulos");

            migrationBuilder.CreateIndex(
                name: "IX_maestrosvssubmodulos_IdMaestro",
                table: "maestrosvssubmodulos",
                column: "IdMaestro");

            migrationBuilder.CreateIndex(
                name: "IX_maestrosvssubmodulos_IdSubmodulo",
                table: "maestrosvssubmodulos",
                column: "IdSubmodulo");

            migrationBuilder.CreateIndex(
                name: "IX_ModuloNotificaciones_IdEstadoNotificacion",
                table: "ModuloNotificaciones",
                column: "IdEstadoNotificacion");

            migrationBuilder.CreateIndex(
                name: "IX_ModuloNotificaciones_IdFormato",
                table: "ModuloNotificaciones",
                column: "IdFormato");

            migrationBuilder.CreateIndex(
                name: "IX_ModuloNotificaciones_IdhiloRespuesta",
                table: "ModuloNotificaciones",
                column: "IdhiloRespuesta");

            migrationBuilder.CreateIndex(
                name: "IX_ModuloNotificaciones_IdRadicado",
                table: "ModuloNotificaciones",
                column: "IdRadicado");

            migrationBuilder.CreateIndex(
                name: "IX_ModuloNotificaciones_IdRequerimiento",
                table: "ModuloNotificaciones",
                column: "IdRequerimiento");

            migrationBuilder.CreateIndex(
                name: "IX_ModuloNotificaciones_IdTipoNotificacion",
                table: "ModuloNotificaciones",
                column: "IdTipoNotificacion");

            migrationBuilder.CreateIndex(
                name: "IX_rolvsmaestro_IdMaestro",
                table: "rolvsmaestro",
                column: "IdMaestro");

            migrationBuilder.CreateIndex(
                name: "IX_rolvsmaestro_IdRol",
                table: "rolvsmaestro",
                column: "IdRol");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Blockchain");

            migrationBuilder.DropTable(
                name: "genericosvssubmodulos");

            migrationBuilder.DropTable(
                name: "ModuloNotificaciones");

            migrationBuilder.DropTable(
                name: "rolvsmaestro");

            migrationBuilder.DropTable(
                name: "Auditoria");

            migrationBuilder.DropTable(
                name: "maestrosvssubmodulos");

            migrationBuilder.DropTable(
                name: "permisosgenericos");

            migrationBuilder.DropTable(
                name: "HiloRespuestaNotificacion");

            migrationBuilder.DropTable(
                name: "TipoNotificaciones");

            migrationBuilder.DropTable(
                name: "estadonotificacion");

            migrationBuilder.DropTable(
                name: "formatos");

            migrationBuilder.DropTable(
                name: "radicados");

            migrationBuilder.DropTable(
                name: "tiporequerimiento");

            migrationBuilder.DropTable(
                name: "rol");

            migrationBuilder.DropTable(
                name: "modulosmaestros");

            migrationBuilder.DropTable(
                name: "submodulos");
        }
    }
}
