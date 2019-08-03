using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace TchSite.Migrations
{
    public partial class AddedPhoto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Documents_Events_EventID",
                table: "Documents");

            migrationBuilder.DropIndex(
                name: "IX_Documents_EventID",
                table: "Documents");

            migrationBuilder.DropColumn(
                name: "EventID",
                table: "Documents");

            migrationBuilder.AddColumn<int>(
                name: "HostCardId",
                table: "Cards",
                nullable: true)
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.None);

            migrationBuilder.CreateTable(
                name: "Photos",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Name = table.Column<string>(nullable: true)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.None),
                    Image = table.Column<string>(nullable: true)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.None),
                    EventID = table.Column<int>(nullable: true)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.None)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Photos", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Photos_Events_EventID",
                        column: x => x.EventID,
                        principalTable: "Events",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Photos_EventID",
                table: "Photos",
                column: "EventID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Photos");

            migrationBuilder.DropColumn(
                name: "HostCardId",
                table: "Cards");

            migrationBuilder.AddColumn<int>(
                name: "EventID",
                table: "Documents",
                nullable: true)
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.None);

            migrationBuilder.CreateIndex(
                name: "IX_Documents_EventID",
                table: "Documents",
                column: "EventID");

            migrationBuilder.AddForeignKey(
                name: "FK_Documents_Events_EventID",
                table: "Documents",
                column: "EventID",
                principalTable: "Events",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
