using Microsoft.EntityFrameworkCore.Migrations;

namespace Persona4GoldenHelper.Data.Migrations
{
    public partial class RenameArcanaNamePersonaNametoName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PersonaName",
                table: "FusionPersona",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "ArcanaName",
                table: "FusionArcana",
                newName: "Name");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "FusionPersona",
                newName: "PersonaName");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "FusionArcana",
                newName: "ArcanaName");
        }
    }
}
