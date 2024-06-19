using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistemaAPIObjeto.Migrations
{
    /// <inheritdoc />
    public partial class NovasModificacoes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ObjetoObservacao",
                table: "Objeto",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ObjetoObservacao",
                table: "Objeto");
        }
    }
}
