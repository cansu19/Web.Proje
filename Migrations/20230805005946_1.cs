using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Barinak.Odev.Migrations
{
    /// <inheritdoc />
    public partial class _1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "turId",
                table: "Hayvanlars",
                newName: "turid");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "turid",
                table: "Hayvanlars",
                newName: "turId");
        }
    }
}
