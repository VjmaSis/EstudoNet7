using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EstudoBlazor.Server.Migrations
{
    /// <inheritdoc />
    public partial class IncluidoColunaDetalhe : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Detalhe",
                table: "Produtos",
                type: "nvarchar(300)",
                maxLength: 300,
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Detalhe",
                table: "Produtos");
        }
    }
}
