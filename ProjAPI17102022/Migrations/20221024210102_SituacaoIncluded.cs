using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjAPI17102022.Migrations
{
    public partial class SituacaoIncluded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SituacaoIMC",
                table: "Person",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SituacaoIMC",
                table: "Person");
        }
    }
}
