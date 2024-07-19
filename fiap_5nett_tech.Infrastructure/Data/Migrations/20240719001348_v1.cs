using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace fiap_5nett_tech.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class v1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Region",
                columns: table => new
                {
                    Ddd = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "NVARCHAR(80)", maxLength: 80, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Region", x => x.Ddd);
                });

            migrationBuilder.CreateTable(
                name: "Contact",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "NVARCHAR(80)", maxLength: 80, nullable: false),
                    Email = table.Column<string>(type: "NVARCHAR(255)", maxLength: 255, nullable: false),
                    Phone = table.Column<string>(type: "VARCHAR(9)", maxLength: 9, nullable: false),
                    DDD = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contact", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CONTACT_REGION",
                        column: x => x.DDD,
                        principalTable: "Region",
                        principalColumn: "Ddd",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Contact_DDD",
                table: "Contact",
                column: "DDD");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contact");

            migrationBuilder.DropTable(
                name: "Region");
        }
    }
}
