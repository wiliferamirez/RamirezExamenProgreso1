using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RamirezExamenProgreso1.Migrations
{
    /// <inheritdoc />
    public partial class PlanrecompensasTabla : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Planrecompensa",
                columns: table => new
                {
                    RecompensasId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreRecompensa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PuntosRecompensa = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Planrecompensa", x => x.RecompensasId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Planrecompensa");
        }
    }
}
