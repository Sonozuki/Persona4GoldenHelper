using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persona4GoldenHelper.Data.Migrations
{
    public partial class MergeweaponaccesoryarmorobtaintoitemObtain : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AccessoryObtain");

            migrationBuilder.DropTable(
                name: "ArmorObtain");

            migrationBuilder.DropTable(
                name: "WeaponObtain");

            migrationBuilder.CreateTable(
                name: "ItemObtain",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Obtain = table.Column<string>(nullable: true),
                    Price = table.Column<string>(nullable: true),
                    AccessoryId = table.Column<int>(nullable: true),
                    ArmorId = table.Column<int>(nullable: true),
                    WeaponId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemObtain", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemObtain_Accessories_AccessoryId",
                        column: x => x.AccessoryId,
                        principalTable: "Accessories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ItemObtain_Armor_ArmorId",
                        column: x => x.ArmorId,
                        principalTable: "Armor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ItemObtain_Weapons_WeaponId",
                        column: x => x.WeaponId,
                        principalTable: "Weapons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ItemObtain_AccessoryId",
                table: "ItemObtain",
                column: "AccessoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemObtain_ArmorId",
                table: "ItemObtain",
                column: "ArmorId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemObtain_WeaponId",
                table: "ItemObtain",
                column: "WeaponId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ItemObtain");

            migrationBuilder.CreateTable(
                name: "AccessoryObtain",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AccessoryId = table.Column<int>(nullable: true),
                    Obtain = table.Column<string>(nullable: true),
                    Price = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccessoryObtain", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AccessoryObtain_Accessories_AccessoryId",
                        column: x => x.AccessoryId,
                        principalTable: "Accessories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ArmorObtain",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ArmorId = table.Column<int>(nullable: true),
                    Obtain = table.Column<string>(nullable: true),
                    Price = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArmorObtain", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ArmorObtain_Armor_ArmorId",
                        column: x => x.ArmorId,
                        principalTable: "Armor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "WeaponObtain",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Obtain = table.Column<string>(nullable: true),
                    Price = table.Column<string>(nullable: true),
                    WeaponId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeaponObtain", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WeaponObtain_Weapons_WeaponId",
                        column: x => x.WeaponId,
                        principalTable: "Weapons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AccessoryObtain_AccessoryId",
                table: "AccessoryObtain",
                column: "AccessoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ArmorObtain_ArmorId",
                table: "ArmorObtain",
                column: "ArmorId");

            migrationBuilder.CreateIndex(
                name: "IX_WeaponObtain_WeaponId",
                table: "WeaponObtain",
                column: "WeaponId");
        }
    }
}
