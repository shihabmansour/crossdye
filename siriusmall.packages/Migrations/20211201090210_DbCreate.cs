using Microsoft.EntityFrameworkCore.Migrations;

namespace siriusmall.app.Migrations
{
    public partial class DbCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    email = table.Column<string>(nullable: true),
                    password = table.Column<string>(nullable: true),
                    firstname = table.Column<string>(nullable: true),
                    lastname = table.Column<string>(nullable: true),
                    username = table.Column<string>(nullable: true),
                    contact = table.Column<string>(nullable: true),
                    address = table.Column<string>(nullable: true),
                    accountStatus = table.Column<string>(nullable: true),
                    notification = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customer");
        }
    }
}
