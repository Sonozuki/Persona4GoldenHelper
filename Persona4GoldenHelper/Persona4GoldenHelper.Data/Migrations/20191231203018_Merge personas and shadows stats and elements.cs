using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persona4GoldenHelper.Data.Migrations
{
    public partial class Mergepersonasandshadowsstatsandelements : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Personas_PersonaElements_ElementsId",
                table: "Personas");

            migrationBuilder.DropForeignKey(
                name: "FK_Personas_PersonaStats_StatsId",
                table: "Personas");

            migrationBuilder.DropForeignKey(
                name: "FK_Shadows_ShadowElements_ElementsId",
                table: "Shadows");

            migrationBuilder.DropForeignKey(
                name: "FK_Shadows_ShadowStats_StatsId",
                table: "Shadows");

            migrationBuilder.DropTable(
                name: "PersonaElements");

            migrationBuilder.DropTable(
                name: "PersonaStats");

            migrationBuilder.DropTable(
                name: "ShadowElements");

            migrationBuilder.DropTable(
                name: "ShadowStats");

            migrationBuilder.CreateTable(
                name: "Elements",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Physical = table.Column<int>(nullable: false),
                    Fire = table.Column<int>(nullable: false),
                    Ice = table.Column<int>(nullable: false),
                    Electricity = table.Column<int>(nullable: false),
                    Wind = table.Column<int>(nullable: false),
                    Light = table.Column<int>(nullable: false),
                    Darkness = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Elements", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Stats",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Strength = table.Column<int>(nullable: false),
                    Magic = table.Column<int>(nullable: false),
                    Endurance = table.Column<int>(nullable: false),
                    Agility = table.Column<int>(nullable: false),
                    Luck = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stats", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Personas_Elements_ElementsId",
                table: "Personas",
                column: "ElementsId",
                principalTable: "Elements",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Personas_Stats_StatsId",
                table: "Personas",
                column: "StatsId",
                principalTable: "Stats",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Shadows_Elements_ElementsId",
                table: "Shadows",
                column: "ElementsId",
                principalTable: "Elements",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Shadows_Stats_StatsId",
                table: "Shadows",
                column: "StatsId",
                principalTable: "Stats",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Personas_Elements_ElementsId",
                table: "Personas");

            migrationBuilder.DropForeignKey(
                name: "FK_Personas_Stats_StatsId",
                table: "Personas");

            migrationBuilder.DropForeignKey(
                name: "FK_Shadows_Elements_ElementsId",
                table: "Shadows");

            migrationBuilder.DropForeignKey(
                name: "FK_Shadows_Stats_StatsId",
                table: "Shadows");

            migrationBuilder.DropTable(
                name: "Elements");

            migrationBuilder.DropTable(
                name: "Stats");

            migrationBuilder.CreateTable(
                name: "PersonaElements",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Darkness = table.Column<int>(nullable: false),
                    Electricity = table.Column<int>(nullable: false),
                    Fire = table.Column<int>(nullable: false),
                    Ice = table.Column<int>(nullable: false),
                    Light = table.Column<int>(nullable: false),
                    Physical = table.Column<int>(nullable: false),
                    Wind = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonaElements", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PersonaStats",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Agility = table.Column<int>(nullable: false),
                    Endurance = table.Column<int>(nullable: false),
                    Luck = table.Column<int>(nullable: false),
                    Magic = table.Column<int>(nullable: false),
                    Strength = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonaStats", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ShadowElements",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Darkness = table.Column<int>(nullable: false),
                    Electricity = table.Column<int>(nullable: false),
                    Fire = table.Column<int>(nullable: false),
                    Ice = table.Column<int>(nullable: false),
                    Light = table.Column<int>(nullable: false),
                    Physical = table.Column<int>(nullable: false),
                    Wind = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShadowElements", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ShadowStats",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Agility = table.Column<int>(nullable: false),
                    Endurance = table.Column<int>(nullable: false),
                    Luck = table.Column<int>(nullable: false),
                    Magic = table.Column<int>(nullable: false),
                    Strength = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShadowStats", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Personas_PersonaElements_ElementsId",
                table: "Personas",
                column: "ElementsId",
                principalTable: "PersonaElements",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Personas_PersonaStats_StatsId",
                table: "Personas",
                column: "StatsId",
                principalTable: "PersonaStats",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Shadows_ShadowElements_ElementsId",
                table: "Shadows",
                column: "ElementsId",
                principalTable: "ShadowElements",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Shadows_ShadowStats_StatsId",
                table: "Shadows",
                column: "StatsId",
                principalTable: "ShadowStats",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
