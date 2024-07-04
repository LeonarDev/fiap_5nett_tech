using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace fiap_5nett_tech.api.Migrations
{
    /// <inheritdoc />
    public partial class v1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contact_Region_Ddd1",
                table: "Contact");

            migrationBuilder.RenameColumn(
                name: "Ddd1",
                table: "Contact",
                newName: "RegionDdd");

            migrationBuilder.RenameIndex(
                name: "IX_Contact_Ddd1",
                table: "Contact",
                newName: "IX_Contact_RegionDdd");

            migrationBuilder.AddForeignKey(
                name: "FK_Contact_Region_RegionDdd",
                table: "Contact",
                column: "RegionDdd",
                principalTable: "Region",
                principalColumn: "Ddd",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contact_Region_RegionDdd",
                table: "Contact");

            migrationBuilder.RenameColumn(
                name: "RegionDdd",
                table: "Contact",
                newName: "Ddd1");

            migrationBuilder.RenameIndex(
                name: "IX_Contact_RegionDdd",
                table: "Contact",
                newName: "IX_Contact_Ddd1");

            migrationBuilder.AddForeignKey(
                name: "FK_Contact_Region_Ddd1",
                table: "Contact",
                column: "Ddd1",
                principalTable: "Region",
                principalColumn: "Ddd",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
