using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TierZooAPI.Migrations
{
    /// <inheritdoc />
    public partial class Renametable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "speciesName",
                table: "Species",
                newName: "specieName");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "specieName",
                table: "Species",
                newName: "speciesName");
        }
    }
}
