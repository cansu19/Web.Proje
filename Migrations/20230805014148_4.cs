using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Barinak.Odev.Migrations
{
    /// <inheritdoc />
    public partial class _4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "sahiplenmeDurum",
                table: "Turlers");

            migrationBuilder.AddColumn<string>(
                name: "sahiplenmeDurum",
                table: "Hayvanlars",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "sahiplenmeDurum",
                table: "Hayvanlars");

            migrationBuilder.AddColumn<string>(
                name: "sahiplenmeDurum",
                table: "Turlers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
