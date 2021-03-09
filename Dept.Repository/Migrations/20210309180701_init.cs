using Microsoft.EntityFrameworkCore.Migrations;

namespace Dept.Repository.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Departamentos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: true),
                    Telefone = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departamentos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Funcionarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: true),
                    Sobrenome = table.Column<string>(type: "TEXT", nullable: true),
                    Telefone = table.Column<string>(type: "TEXT", nullable: true),
                    DepartamentoId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Funcionarios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Funcionarios_Departamentos_DepartamentoId",
                        column: x => x.DepartamentoId,
                        principalTable: "Departamentos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Departamentos",
                columns: new[] { "Id", "Nome", "Telefone" },
                values: new object[] { 10, "Recursos Humanos", "222-3535" });

            migrationBuilder.InsertData(
                table: "Departamentos",
                columns: new[] { "Id", "Nome", "Telefone" },
                values: new object[] { 11, "Financeiro", "222-3535" });

            migrationBuilder.InsertData(
                table: "Departamentos",
                columns: new[] { "Id", "Nome", "Telefone" },
                values: new object[] { 12, "Administrativo", "222-3535" });

            migrationBuilder.InsertData(
                table: "Departamentos",
                columns: new[] { "Id", "Nome", "Telefone" },
                values: new object[] { 13, "Comercial", "222-3535" });

            migrationBuilder.InsertData(
                table: "Departamentos",
                columns: new[] { "Id", "Nome", "Telefone" },
                values: new object[] { 14, "Manutenção", "222-3535" });

            migrationBuilder.InsertData(
                table: "Departamentos",
                columns: new[] { "Id", "Nome", "Telefone" },
                values: new object[] { 15, "Operacional", "222-3535" });

            migrationBuilder.InsertData(
                table: "Departamentos",
                columns: new[] { "Id", "Nome", "Telefone" },
                values: new object[] { 16, "TI", "99704-6172" });

            migrationBuilder.InsertData(
                table: "Funcionarios",
                columns: new[] { "Id", "DepartamentoId", "Nome", "Sobrenome", "Telefone" },
                values: new object[] { 1, 16, "Fabio", "Fernandes", "555-3626" });

            migrationBuilder.InsertData(
                table: "Funcionarios",
                columns: new[] { "Id", "DepartamentoId", "Nome", "Sobrenome", "Telefone" },
                values: new object[] { 2, 16, "José", "da Silva", "888-9899" });

            migrationBuilder.InsertData(
                table: "Funcionarios",
                columns: new[] { "Id", "DepartamentoId", "Nome", "Sobrenome", "Telefone" },
                values: new object[] { 3, 16, "Thiago", "Oliveira", "964-5896" });

            migrationBuilder.InsertData(
                table: "Funcionarios",
                columns: new[] { "Id", "DepartamentoId", "Nome", "Sobrenome", "Telefone" },
                values: new object[] { 4, 16, "Paloma", "Machado", "562-5233" });

            migrationBuilder.InsertData(
                table: "Funcionarios",
                columns: new[] { "Id", "DepartamentoId", "Nome", "Sobrenome", "Telefone" },
                values: new object[] { 5, 16, "Laura", "Ferreira", "548-8986" });

            migrationBuilder.InsertData(
                table: "Funcionarios",
                columns: new[] { "Id", "DepartamentoId", "Nome", "Sobrenome", "Telefone" },
                values: new object[] { 6, 16, "Lucas", "Paula", "111-2350" });

            migrationBuilder.InsertData(
                table: "Funcionarios",
                columns: new[] { "Id", "DepartamentoId", "Nome", "Sobrenome", "Telefone" },
                values: new object[] { 7, 16, "Edite", "Fernandes", "225-6583" });

            migrationBuilder.CreateIndex(
                name: "IX_Funcionarios_DepartamentoId",
                table: "Funcionarios",
                column: "DepartamentoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Funcionarios");

            migrationBuilder.DropTable(
                name: "Departamentos");
        }
    }
}
