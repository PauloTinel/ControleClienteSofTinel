using Microsoft.EntityFrameworkCore.Migrations;

namespace ControleClienteSofTinel.Data.Migrations
{
    public partial class _bv23 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Ativo",
                table: "Empresa",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AddColumn<string>(
                name: "Codigo",
                table: "Empresa",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Codigo",
                table: "Empresa");

            migrationBuilder.AlterColumn<bool>(
                name: "Ativo",
                table: "Empresa",
                type: "bit",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
