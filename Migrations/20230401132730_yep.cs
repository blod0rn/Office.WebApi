using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Office.Web.Migrations
{
    /// <inheritdoc />
    public partial class yep : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DepartamentEntityId",
                table: "Projects",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Projects_DepartamentEntityId",
                table: "Projects",
                column: "DepartamentEntityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_Departaments_DepartamentEntityId",
                table: "Projects",
                column: "DepartamentEntityId",
                principalTable: "Departaments",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Projects_Departaments_DepartamentEntityId",
                table: "Projects");

            migrationBuilder.DropIndex(
                name: "IX_Projects_DepartamentEntityId",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "DepartamentEntityId",
                table: "Projects");
        }
    }
}
