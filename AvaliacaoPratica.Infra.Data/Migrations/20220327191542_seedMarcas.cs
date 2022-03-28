using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AvaliacaoPratica.Infra.Data.Migrations
{
    public partial class seedMarcas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Marcas([Nome], [Status]) VALUES ('Chevrolet', 1)");
            migrationBuilder.Sql("INSERT INTO Marcas([Nome], [Status]) VALUES ('Volkswagen', 1)");
            migrationBuilder.Sql("INSERT INTO Marcas([Nome], [Status]) VALUES ('Fiat', 1)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Marcas");
        }
    }
}
