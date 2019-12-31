using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persona4GoldenHelper.Data.Migrations
{
    public partial class Addshadows : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ShadowElements",
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
                    table.PrimaryKey("PK_ShadowElements", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ShadowStats",
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
                    table.PrimaryKey("PK_ShadowStats", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Shadows",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Level = table.Column<int>(nullable: false),
                    HP = table.Column<int>(nullable: false),
                    SP = table.Column<int>(nullable: false),
                    Exp = table.Column<int>(nullable: false),
                    Yen = table.Column<string>(nullable: true),
                    StatsId = table.Column<int>(nullable: true),
                    ElementsId = table.Column<int>(nullable: true),
                    Type = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shadows", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Shadows_ShadowElements_ElementsId",
                        column: x => x.ElementsId,
                        principalTable: "ShadowElements",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Shadows_ShadowStats_StatsId",
                        column: x => x.StatsId,
                        principalTable: "ShadowStats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ShadowSkill",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    ShadowId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShadowSkill", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShadowSkill_Shadows_ShadowId",
                        column: x => x.ShadowId,
                        principalTable: "Shadows",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Shadows_ElementsId",
                table: "Shadows",
                column: "ElementsId");

            migrationBuilder.CreateIndex(
                name: "IX_Shadows_StatsId",
                table: "Shadows",
                column: "StatsId");

            migrationBuilder.CreateIndex(
                name: "IX_ShadowSkill_ShadowId",
                table: "ShadowSkill",
                column: "ShadowId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ShadowSkill");

            migrationBuilder.DropTable(
                name: "Shadows");

            migrationBuilder.DropTable(
                name: "ShadowElements");

            migrationBuilder.DropTable(
                name: "ShadowStats");
        }
    }
}
