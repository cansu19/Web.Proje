using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Barinak.Odev.Migrations
{
    /// <inheritdoc />
    public partial class yeni : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Hayvanlars_Turlers_Turlerturid",
                table: "Hayvanlars");

            migrationBuilder.DropIndex(
                name: "IX_Hayvanlars_Turlerturid",
                table: "Hayvanlars");

            migrationBuilder.DropColumn(
                name: "Turlerturid",
                table: "Hayvanlars");

            migrationBuilder.RenameColumn(
                name: "turler",
                table: "Turlers",
                newName: "TurAd");

            migrationBuilder.RenameColumn(
                name: "turid",
                table: "Hayvanlars",
                newName: "Turid");

            migrationBuilder.AddColumn<string>(
                name: "Cinsiyet",
                table: "Hayvanlars",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FotoUrl",
                table: "Hayvanlars",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Hayvanlars_Turid",
                table: "Hayvanlars",
                column: "Turid");

            migrationBuilder.AddForeignKey(
                name: "FK_Hayvanlars_Turlers_Turid",
                table: "Hayvanlars",
                column: "Turid",
                principalTable: "Turlers",
                principalColumn: "turid",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Hayvanlars_Turlers_Turid",
                table: "Hayvanlars");

            migrationBuilder.DropIndex(
                name: "IX_Hayvanlars_Turid",
                table: "Hayvanlars");

            migrationBuilder.DropColumn(
                name: "Cinsiyet",
                table: "Hayvanlars");

            migrationBuilder.DropColumn(
                name: "FotoUrl",
                table: "Hayvanlars");

            migrationBuilder.RenameColumn(
                name: "TurAd",
                table: "Turlers",
                newName: "turler");

            migrationBuilder.RenameColumn(
                name: "Turid",
                table: "Hayvanlars",
                newName: "turid");

            migrationBuilder.AddColumn<int>(
                name: "Turlerturid",
                table: "Hayvanlars",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Hayvanlars_Turlerturid",
                table: "Hayvanlars",
                column: "Turlerturid");

            migrationBuilder.AddForeignKey(
                name: "FK_Hayvanlars_Turlers_Turlerturid",
                table: "Hayvanlars",
                column: "Turlerturid",
                principalTable: "Turlers",
                principalColumn: "turid",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
