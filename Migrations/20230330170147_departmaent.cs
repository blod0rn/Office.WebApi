using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Office.Web.Migrations
{
    /// <inheritdoc />
    public partial class departmaent : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FullName",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "isDepartamentHead",
                table: "Employees");

            migrationBuilder.RenameColumn(
                name: "skills",
                table: "Employees",
                newName: "Skills");

            migrationBuilder.CreateTable(
                name: "EmployeeEntityProjectEntity",
                columns: table => new
                {
                    EmployeesListId = table.Column<int>(type: "integer", nullable: false),
                    ProjectListId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeEntityProjectEntity", x => new { x.EmployeesListId, x.ProjectListId });
                    table.ForeignKey(
                        name: "FK_EmployeeEntityProjectEntity_Employees_EmployeesListId",
                        column: x => x.EmployeesListId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeeEntityProjectEntity_Projects_ProjectListId",
                        column: x => x.ProjectListId,
                        principalTable: "Projects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NameUser = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    Password = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserModel", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeEntityProjectEntity_ProjectListId",
                table: "EmployeeEntityProjectEntity",
                column: "ProjectListId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmployeeEntityProjectEntity");

            migrationBuilder.DropTable(
                name: "UserModel");

            migrationBuilder.RenameColumn(
                name: "Skills",
                table: "Employees",
                newName: "skills");

            migrationBuilder.AddColumn<string>(
                name: "FullName",
                table: "Employees",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "isDepartamentHead",
                table: "Employees",
                type: "boolean",
                nullable: false,
                defaultValue: false);
        }
    }
}
