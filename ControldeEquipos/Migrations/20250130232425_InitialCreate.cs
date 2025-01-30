using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ControldeEquipos.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Departamentos",
                columns: table => new
                {
                    ID_Departamento = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre_Departamento = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departamentos", x => x.ID_Departamento);
                });

            migrationBuilder.CreateTable(
                name: "Equipos",
                columns: table => new
                {
                    ID_Equipo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre_Equipo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Marca = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Modelo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Numero_Serial = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fecha_Adquisicion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Departamento_ID = table.Column<int>(type: "int", nullable: false),
                    DepartamentoID_Departamento = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equipos", x => x.ID_Equipo);
                    table.ForeignKey(
                        name: "FK_Equipos_Departamentos_DepartamentoID_Departamento",
                        column: x => x.DepartamentoID_Departamento,
                        principalTable: "Departamentos",
                        principalColumn: "ID_Departamento",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Mantenimientos",
                columns: table => new
                {
                    ID_Mantenimiento = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Equipo_ID = table.Column<int>(type: "int", nullable: false),
                    Fecha_Mantenimiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tecnico = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EquipoID_Equipo = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mantenimientos", x => x.ID_Mantenimiento);
                    table.ForeignKey(
                        name: "FK_Mantenimientos_Equipos_EquipoID_Equipo",
                        column: x => x.EquipoID_Equipo,
                        principalTable: "Equipos",
                        principalColumn: "ID_Equipo",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Equipos_DepartamentoID_Departamento",
                table: "Equipos",
                column: "DepartamentoID_Departamento");

            migrationBuilder.CreateIndex(
                name: "IX_Mantenimientos_EquipoID_Equipo",
                table: "Mantenimientos",
                column: "EquipoID_Equipo");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Mantenimientos");

            migrationBuilder.DropTable(
                name: "Equipos");

            migrationBuilder.DropTable(
                name: "Departamentos");
        }
    }
}
