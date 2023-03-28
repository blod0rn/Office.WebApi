using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Office.Web.Migrations
{
    /// <inheritdoc />
    public partial class Change : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Departaments_departamentId",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Workloads_workloadId",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeesProjects_Employees_employeeId",
                table: "EmployeesProjects");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeesProjects_Projects_projectId",
                table: "EmployeesProjects");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "EmployeesProjects");

            migrationBuilder.DropColumn(
                name: "ProjectId",
                table: "EmployeesProjects");

            migrationBuilder.DropColumn(
                name: "DepartamentId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "WorkloadId",
                table: "Employees");

            migrationBuilder.RenameColumn(
                name: "projectId",
                table: "EmployeesProjects",
                newName: "ProjectId");

            migrationBuilder.RenameColumn(
                name: "employeeId",
                table: "EmployeesProjects",
                newName: "EmployeeId");

            migrationBuilder.RenameIndex(
                name: "IX_EmployeesProjects_projectId",
                table: "EmployeesProjects",
                newName: "IX_EmployeesProjects_ProjectId");

            migrationBuilder.RenameIndex(
                name: "IX_EmployeesProjects_employeeId",
                table: "EmployeesProjects",
                newName: "IX_EmployeesProjects_EmployeeId");

            migrationBuilder.RenameColumn(
                name: "workloadId",
                table: "Employees",
                newName: "WorkloadId");

            migrationBuilder.RenameColumn(
                name: "departamentId",
                table: "Employees",
                newName: "DepartamentId");

            migrationBuilder.RenameColumn(
                name: "Skills",
                table: "Employees",
                newName: "skills");

            migrationBuilder.RenameColumn(
                name: "IsDepartamentHead",
                table: "Employees",
                newName: "isDepartamentHead");

            migrationBuilder.RenameIndex(
                name: "IX_Employees_workloadId",
                table: "Employees",
                newName: "IX_Employees_WorkloadId");

            migrationBuilder.RenameIndex(
                name: "IX_Employees_departamentId",
                table: "Employees",
                newName: "IX_Employees_DepartamentId");

            migrationBuilder.AlterColumn<int>(
                name: "WorkloadId",
                table: "Employees",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Departaments_DepartamentId",
                table: "Employees",
                column: "DepartamentId",
                principalTable: "Departaments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Workloads_WorkloadId",
                table: "Employees",
                column: "WorkloadId",
                principalTable: "Workloads",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeesProjects_Employees_EmployeeId",
                table: "EmployeesProjects",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeesProjects_Projects_ProjectId",
                table: "EmployeesProjects",
                column: "ProjectId",
                principalTable: "Projects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Departaments_DepartamentId",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Workloads_WorkloadId",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeesProjects_Employees_EmployeeId",
                table: "EmployeesProjects");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeesProjects_Projects_ProjectId",
                table: "EmployeesProjects");

            migrationBuilder.RenameColumn(
                name: "ProjectId",
                table: "EmployeesProjects",
                newName: "projectId");

            migrationBuilder.RenameColumn(
                name: "EmployeeId",
                table: "EmployeesProjects",
                newName: "employeeId");

            migrationBuilder.RenameIndex(
                name: "IX_EmployeesProjects_ProjectId",
                table: "EmployeesProjects",
                newName: "IX_EmployeesProjects_projectId");

            migrationBuilder.RenameIndex(
                name: "IX_EmployeesProjects_EmployeeId",
                table: "EmployeesProjects",
                newName: "IX_EmployeesProjects_employeeId");

            migrationBuilder.RenameColumn(
                name: "skills",
                table: "Employees",
                newName: "Skills");

            migrationBuilder.RenameColumn(
                name: "isDepartamentHead",
                table: "Employees",
                newName: "IsDepartamentHead");

            migrationBuilder.RenameColumn(
                name: "WorkloadId",
                table: "Employees",
                newName: "workloadId");

            migrationBuilder.RenameColumn(
                name: "DepartamentId",
                table: "Employees",
                newName: "departamentId");

            migrationBuilder.RenameIndex(
                name: "IX_Employees_WorkloadId",
                table: "Employees",
                newName: "IX_Employees_workloadId");

            migrationBuilder.RenameIndex(
                name: "IX_Employees_DepartamentId",
                table: "Employees",
                newName: "IX_Employees_departamentId");

            migrationBuilder.AddColumn<int>(
                name: "EmployeeId",
                table: "EmployeesProjects",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ProjectId",
                table: "EmployeesProjects",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "workloadId",
                table: "Employees",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddColumn<int>(
                name: "DepartamentId",
                table: "Employees",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "WorkloadId",
                table: "Employees",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Departaments_departamentId",
                table: "Employees",
                column: "departamentId",
                principalTable: "Departaments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Workloads_workloadId",
                table: "Employees",
                column: "workloadId",
                principalTable: "Workloads",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeesProjects_Employees_employeeId",
                table: "EmployeesProjects",
                column: "employeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeesProjects_Projects_projectId",
                table: "EmployeesProjects",
                column: "projectId",
                principalTable: "Projects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
