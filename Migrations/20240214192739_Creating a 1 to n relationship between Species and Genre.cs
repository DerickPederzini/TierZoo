using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TierZooAPI.Migrations
{
    /// <inheritdoc />
    public partial class Creatinga1tonrelationshipbetweenSpeciesandGenre : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SpeciesId",
                table: "Genre",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Genre_SpeciesId",
                table: "Genre",
                column: "SpeciesId");

            migrationBuilder.AddForeignKey(
                name: "FK_Genre_Specie_SpeciesId",
                table: "Genre",
                column: "SpeciesId",
                principalTable: "Specie",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Genre_Specie_SpeciesId",
                table: "Genre");

            migrationBuilder.DropIndex(
                name: "IX_Genre_SpeciesId",
                table: "Genre");

            migrationBuilder.DropColumn(
                name: "SpeciesId",
                table: "Genre");
        }
    }
}
