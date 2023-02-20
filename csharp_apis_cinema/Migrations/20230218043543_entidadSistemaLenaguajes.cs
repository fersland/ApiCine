using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace csharp_apis_cinema.Migrations
{
    /// <inheritdoc />
    public partial class entidadSistemaLenaguajes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LenguajeSistema",
                columns: table => new
                {
                    LenguajesId = table.Column<int>(type: "int", nullable: false),
                    SistemasId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LenguajeSistema", x => new { x.LenguajesId, x.SistemasId });
                    table.ForeignKey(
                        name: "FK_LenguajeSistema_Lenguajes_LenguajesId",
                        column: x => x.LenguajesId,
                        principalTable: "Lenguajes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LenguajeSistema_Sistemas_SistemasId",
                        column: x => x.SistemasId,
                        principalTable: "Sistemas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LenguajeSistema_SistemasId",
                table: "LenguajeSistema",
                column: "SistemasId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LenguajeSistema");
        }
    }
}
