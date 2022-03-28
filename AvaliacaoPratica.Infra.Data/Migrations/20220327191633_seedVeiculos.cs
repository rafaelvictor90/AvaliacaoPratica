using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AvaliacaoPratica.Infra.Data.Migrations
{
    public partial class seedVeiculos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO [Veiculos]([Renavam], [Modelo], [AnoFabricacao], [AnoModelo], [Quilometragem], [Valor], [StatusId], [MarcaId], [ProprietarioId]) VALUES ( '01232456', 'Camaro', 2022, 2022, 0, 400000.00, 1, 1, 1)");
            migrationBuilder.Sql("INSERT INTO [Veiculos]([Renavam], [Modelo], [AnoFabricacao], [AnoModelo], [Quilometragem], [Valor], [StatusId], [MarcaId], [ProprietarioId]) VALUES ( '00251487', 'Amarok', 2022, 2022, 0, 300000.00, 1, 1, 2)");
            migrationBuilder.Sql("INSERT INTO [Veiculos]([Renavam], [Modelo], [AnoFabricacao], [AnoModelo], [Quilometragem], [Valor], [StatusId], [MarcaId], [ProprietarioId]) VALUES ( '00025478', 'Toro Ultra', 2022, 2022, 0, 200000.00, 1, 1, 3)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM [Veiculos]");
        }
    }
}
