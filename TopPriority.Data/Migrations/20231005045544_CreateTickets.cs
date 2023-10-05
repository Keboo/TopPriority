using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TopPriority.Data.Migrations
{
    /// <inheritdoc />
    public partial class CreateTickets : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tickets",
                columns: table => new
                {
                    TicketId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RequestorName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Request = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StartDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CompletedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tickets", x => x.TicketId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tickets");
        }
    }
}
