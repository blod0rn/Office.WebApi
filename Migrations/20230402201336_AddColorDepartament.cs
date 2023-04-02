using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Office.Web.Migrations
{
    /// <inheritdoc />
    public partial class AddColorDepartament : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ColorDepartamemnt",
                table: "Departaments",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ColorDepartamemnt",
                table: "Departaments");
        }
    }
}
