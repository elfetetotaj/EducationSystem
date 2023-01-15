using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ES.WebUI.Migrations
{
    public partial class BirthPlaceTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BirthplaceId",
                table: "Students",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Birthplaces",
                columns: table => new
                {
                    BirthplaceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BirthplaceName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Birthplaces", x => x.BirthplaceId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Students_BirthplaceId",
                table: "Students",
                column: "BirthplaceId");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Birthplaces_BirthplaceId",
                table: "Students",
                column: "BirthplaceId",
                principalTable: "Birthplaces",
                principalColumn: "BirthplaceId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Birthplaces_BirthplaceId",
                table: "Students");

            migrationBuilder.DropTable(
                name: "Birthplaces");

            migrationBuilder.DropIndex(
                name: "IX_Students_BirthplaceId",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "BirthplaceId",
                table: "Students");
        }
    }
}
