using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Barinak.Odev.Migrations
{
    /// <inheritdoc />
    public partial class deneme6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Kullanici",
                table: "Admins",
                type: "Varchar(40)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "Varchar(20)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Kullanici",
                table: "Admins",
                type: "Varchar(20)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "Varchar(40)");
        }
    }
}
