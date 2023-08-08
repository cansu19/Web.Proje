using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Barinak.Odev.Migrations
{
    /// <inheritdoc />
    public partial class deneme : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Turlers",
                columns: table => new
                {
                    turid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    turler = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    sahiplenmeDurum = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Turlers", x => x.turid);
                });

            migrationBuilder.CreateTable(
                name: "Hayvanlars",
                columns: table => new
                {
                    hayid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    yas = table.Column<int>(type: "int", nullable: false),
                    sehir = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    turId = table.Column<int>(type: "int", nullable: false),
                    Turlerturid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hayvanlars", x => x.hayid);
                    table.ForeignKey(
                        name: "FK_Hayvanlars_Turlers_Turlerturid",
                        column: x => x.Turlerturid,
                        principalTable: "Turlers",
                        principalColumn: "turid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Hayvanlars_Turlerturid",
                table: "Hayvanlars",
                column: "Turlerturid");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Hayvanlars");

            migrationBuilder.DropTable(
                name: "Turlers");
        }
    }
}
