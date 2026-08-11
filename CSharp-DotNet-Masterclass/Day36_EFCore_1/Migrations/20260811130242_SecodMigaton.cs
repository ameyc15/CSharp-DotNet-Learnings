using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Day36_EFCore_1.Migrations
{
    /// <inheritdoc />
    public partial class SecodMigaton : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Emp_Address",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Emp_Address",
                table: "Employees");
        }
    }
}
