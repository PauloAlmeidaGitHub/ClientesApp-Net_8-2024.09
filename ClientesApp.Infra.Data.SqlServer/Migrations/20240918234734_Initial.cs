using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClientesApp.Infra.Data.SqlServer.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TB_CLIENTE",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NOME = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    EMAIL = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CPF = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_CLIENTE", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TB_CLIENTE_CPF",
                table: "TB_CLIENTE",
                column: "CPF",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TB_CLIENTE_EMAIL",
                table: "TB_CLIENTE",
                column: "EMAIL",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TB_CLIENTE");
        }
    }
}
