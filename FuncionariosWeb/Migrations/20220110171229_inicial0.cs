using Microsoft.EntityFrameworkCore.Migrations;

namespace FuncionariosWeb.Migrations
{
    public partial class inicial0 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Funcionarios",
                columns: new[] { "FuncionarioID", "Departamento", "Email", "Nome" },
                values: new object[] { 1, 0, "danni.haag91@gmail.com", "Haag" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Funcionarios",
                keyColumn: "FuncionarioID",
                keyValue: 1);
        }
    }
}
