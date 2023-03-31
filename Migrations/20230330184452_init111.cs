using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Office.Web.Migrations
{
    /// <inheritdoc />
    public partial class init111 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmployeeEntityProjectEntity");

            migrationBuilder.AddColumn<bool>(
                name: "IsDepartamentHead",
                table: "Employees",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "ProjectEntityId",
                table: "Employees",
                type: "integer",
                nullable: true);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Projects_ProjectEntityId",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_ProjectEntityId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "IsDepartamentHead",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "ProjectEntityId",
                table: "Employees");

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

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeEntityProjectEntity_ProjectListId",
                table: "EmployeeEntityProjectEntity",
                column: "ProjectListId");
        }
    }
}
