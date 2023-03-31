using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Office.Web.Migrations
{
    /// <inheritdoc />
    public partial class init112 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Projects_ProjectEntityId",
                table: "Employees");

            migrationBuilder.DropTable(
                name: "UserModel");

            migrationBuilder.DropIndex(
                name: "IX_Employees_ProjectEntityId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "ProjectEntityId",
                table: "Employees");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProjectEntityId",
                table: "Employees",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "UserModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Email = table.Column<string>(type: "text", nullable: false),
                    NameUser = table.Column<string>(type: "text", nullable: false),
                    Password = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserModel", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employees_ProjectEntityId",
                table: "Employees",
                column: "ProjectEntityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Projects_ProjectEntityId",
                table: "Employees",
                column: "ProjectEntityId",
                principalTable: "Projects",
                principalColumn: "Id");
        }
    }
}
