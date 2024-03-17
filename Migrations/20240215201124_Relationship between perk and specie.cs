using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TierZooAPI.Migrations
{
    /// <inheritdoc />
    public partial class Relationshipbetweenperkandspecie : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SpecieId",
                table: "Genre");

            migrationBuilder.AddColumn<int>(
                name: "SpeciesId",
                table: "Perk",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Perk_SpeciesId",
                table: "Perk",
                column: "SpeciesId");

            migrationBuilder.AddForeignKey(
                name: "FK_Perk_Species_SpeciesId",
                table: "Perk",
                column: "SpeciesId",
                principalTable: "Species",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Perk_Species_SpeciesId",
                table: "Perk");

            migrationBuilder.DropIndex(
                name: "IX_Perk_SpeciesId",
                table: "Perk");

            migrationBuilder.DropColumn(
                name: "SpeciesId",
                table: "Perk");

            migrationBuilder.AddColumn<int>(
                name: "SpecieId",
                table: "Genre",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
