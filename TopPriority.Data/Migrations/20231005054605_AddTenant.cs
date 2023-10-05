using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TopPriority.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddTenant : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Tenant",
                table: "Tickets",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Tenant",
                table: "Tickets");
        }
    }
}
