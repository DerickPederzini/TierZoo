using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TierZooAPI.Migrations
{
    /// <inheritdoc />
    public partial class RebuildTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "hermaphrodite",
                table: "Species",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "SpecieId",
                table: "Genre",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "hermaphrodite",
                table: "Species");

            migrationBuilder.DropColumn(
                name: "SpecieId",
                table: "Genre");
        }
    }
}
