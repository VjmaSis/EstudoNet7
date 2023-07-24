using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EstudoBlazor.Server.Migrations
{
    /// <inheritdoc />
    public partial class AdicionandoImagemEmProduto : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImagemBase64",
                table: "Produtos",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImagemBase64",
                table: "Produtos");
        }
    }
}
