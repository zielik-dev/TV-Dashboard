using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TV_Dashboard.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MainLogsTable",
                columns: table => new
                {
                    LogId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LogDate = table.Column<string>(type: "varchar(10)", nullable: false),
                    LogTime = table.Column<string>(type: "varchar(8)", nullable: false),
                    ApplicationName = table.Column<string>(type: "varchar(250)", nullable: false),
                    ProcessName = table.Column<string>(type: "varchar(250)", nullable: false),
                    Status = table.Column<string>(type: "varchar(250)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MainLogsTable", x => x.LogId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MainLogsTable");
        }
    }
}
