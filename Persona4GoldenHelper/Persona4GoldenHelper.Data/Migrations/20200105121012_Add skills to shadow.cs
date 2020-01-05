using Microsoft.EntityFrameworkCore.Migrations;

namespace Persona4GoldenHelper.Data.Migrations
{
    public partial class Addskillstoshadow : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ShadowId",
                table: "Skills",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Skills_ShadowId",
                table: "Skills",
                column: "ShadowId");

            migrationBuilder.AddForeignKey(
                name: "FK_Skills_Shadows_ShadowId",
                table: "Skills",
                column: "ShadowId",
                principalTable: "Shadows",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Skills_Shadows_ShadowId",
                table: "Skills");

            migrationBuilder.DropIndex(
                name: "IX_Skills_ShadowId",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "ShadowId",
                table: "Skills");
        }
    }
}
