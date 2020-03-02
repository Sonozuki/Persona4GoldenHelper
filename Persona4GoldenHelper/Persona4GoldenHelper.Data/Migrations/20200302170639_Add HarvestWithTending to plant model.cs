using Microsoft.EntityFrameworkCore.Migrations;

namespace Persona4GoldenHelper.Data.Migrations
{
    public partial class AddHarvestWithTendingtoplantmodel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "HarvestWithTending",
                table: "Plants",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HarvestWithTending",
                table: "Plants");
        }
    }
}
