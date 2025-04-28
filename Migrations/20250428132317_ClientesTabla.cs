using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RamirezExamenProgreso1.Migrations
{
    /// <inheritdoc />
    public partial class ClientesTabla : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    ClienteID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreCliente = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ApellidoCliente = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    EmailCliente = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TelefonoCliente = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SaldoCliente = table.Column<float>(type: "real", nullable: false),
                    FechaRegistroCliente = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaSalidaCliente = table.Column<DateTime>(type: "datetime2", nullable: false),
                    VIPCliente = table.Column<bool>(type: "bit", nullable: false),
                    RamirezW = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.ClienteID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clientes");
        }
    }
}
