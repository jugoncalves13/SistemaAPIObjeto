using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistemaAPIObjeto.Migrations
{
    /// <inheritdoc />
    public partial class Modificacoes1206 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ObjetoObservacao",
                table: "Objeto",
                newName: "ObjetoObservacoes");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ObjetoObservacoes",
                table: "Objeto",
                newName: "ObjetoObservacao");
        }
    }
}
