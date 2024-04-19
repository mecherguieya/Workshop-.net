using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Examen.Infra.Migrations
{
    /// <inheritdoc />
    public partial class discriminator : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Locataires");

            migrationBuilder.AddColumn<int>(
                name: "TypeLocataire",
                table: "Locataires",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TypeLocataire",
                table: "Locataires");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Locataires",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
