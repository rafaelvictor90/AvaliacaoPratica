using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AvaliacaoPratica.Infra.Data.Migrations
{
    public partial class seedProprietario : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Proprietarios([Nome], [Documento], [Email], [Cep], [Status]) VALUES ( 'Ronaldo', '12312312-12', 'teste1@teste.com', '01310-200', 1)");
            migrationBuilder.Sql("INSERT INTO Proprietarios([Nome], [Documento], [Email], [Cep], [Status]) VALUES ( 'Junior', '32132132-21', 'teste2@teste.com', '08010-300', 1)");
            migrationBuilder.Sql("INSERT INTO Proprietarios([Nome], [Documento], [Email], [Cep], [Status]) VALUES ( 'Kassio', '13213233-2', 'teste3@teste.com', '08010-330', 1)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Proprietarios");
        }
    }
}
