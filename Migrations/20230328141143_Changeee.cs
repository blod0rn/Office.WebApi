using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Office.Web.Migrations
{
    /// <inheritdoc />
    public partial class Changeee : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_EmployeesProjects",
                table: "EmployeesProjects");

            migrationBuilder.DropIndex(
                name: "IX_EmployeesProjects_EmployeeId",
                table: "EmployeesProjects");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "EmployeesProjects");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "EmployeesProjects");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EmployeesProjects",
                table: "EmployeesProjects",
                columns: new[] { "EmployeeId", "ProjectId" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_EmployeesProjects",
                table: "EmployeesProjects");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "EmployeesProjects",
                type: "integer",
                nullable: false,
                defaultValue: 0)
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "EmployeesProjects",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddPrimaryKey(
                name: "PK_EmployeesProjects",
                table: "EmployeesProjects",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeesProjects_EmployeeId",
                table: "EmployeesProjects",
                column: "EmployeeId");
        }
    }
}
