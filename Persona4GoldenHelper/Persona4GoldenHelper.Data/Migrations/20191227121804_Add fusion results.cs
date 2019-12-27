using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persona4GoldenHelper.Data.Migrations
{
    public partial class Addfusionresults : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ArcanaFusionResults",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FusionType = table.Column<int>(nullable: false),
                    ResultArcana = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArcanaFusionResults", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SpecialFusionResults",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ResultPersona = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpecialFusionResults", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FusionArcana",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ArcanaName = table.Column<string>(nullable: true),
                    ArcanaFusionResultId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FusionArcana", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FusionArcana_ArcanaFusionResults_ArcanaFusionResultId",
                        column: x => x.ArcanaFusionResultId,
                        principalTable: "ArcanaFusionResults",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FusionPersona",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PersonaName = table.Column<string>(nullable: true),
                    SpecialFusionResultId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FusionPersona", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FusionPersona_SpecialFusionResults_SpecialFusionResultId",
                        column: x => x.SpecialFusionResultId,
                        principalTable: "SpecialFusionResults",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FusionArcana_ArcanaFusionResultId",
                table: "FusionArcana",
                column: "ArcanaFusionResultId");

            migrationBuilder.CreateIndex(
                name: "IX_FusionPersona_SpecialFusionResultId",
                table: "FusionPersona",
                column: "SpecialFusionResultId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FusionArcana");

            migrationBuilder.DropTable(
                name: "FusionPersona");

            migrationBuilder.DropTable(
                name: "ArcanaFusionResults");

            migrationBuilder.DropTable(
                name: "SpecialFusionResults");
        }
    }
}
