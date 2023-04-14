using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Office.Web.Migrations
{
    /// <inheritdoc />
    public partial class Remove_workload_connectionDepartamentProject : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Workloads_WorkloadId",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_Projects_Departaments_DepartamentEntityId",
                table: "Projects");

            migrationBuilder.DropTable(
                name: "Workloads");

            migrationBuilder.DropIndex(
                name: "IX_Projects_DepartamentEntityId",
                table: "Projects");

            migrationBuilder.DropIndex(
                name: "IX_Employees_WorkloadId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "DepartamentEntityId",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "WorkloadId",
                table: "Employees");

            migrationBuilder.AddColumn<string>(
                name: "Info",
                table: "Employees",
                type: "text",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Info",
                table: "Employees");

            migrationBuilder.AddColumn<int>(
                name: "DepartamentEntityId",
                table: "Projects",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "WorkloadId",
                table: "Employees",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Workloads",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DegreeWorkload = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Workloads", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Projects_DepartamentEntityId",
                table: "Projects",
                column: "DepartamentEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_WorkloadId",
                table: "Employees",
                column: "WorkloadId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Workloads_WorkloadId",
                table: "Employees",
                column: "WorkloadId",
                principalTable: "Workloads",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_Departaments_DepartamentEntityId",
                table: "Projects",
                column: "DepartamentEntityId",
                principalTable: "Departaments",
                principalColumn: "Id");
        }
    }
}
