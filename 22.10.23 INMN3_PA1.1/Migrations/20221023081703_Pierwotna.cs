using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _22._10._23_INMN3_PA1._1.Migrations
{
    public partial class Pierwotna : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Państwa",
                columns: table => new
                {
                    Id = table.Column<int>(
                        type: "int",
                        nullable: false
                        )
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nazwa = table.Column<string>(
                        type: "nvarchar(max)",
                        nullable: true
                        ),
                    Populacja = table.Column<long>(
                        type: "bigint",
                        nullable: true
                        ),
                    Powierzchnia = table.Column<decimal>(
                        type: "decimal(18,2)",
                        nullable: false
                        ),
                    DataZałożenia = table.Column<DateTime>(
                        type: "datetime2",
                        nullable: false
                        ),
                    Stolica = table.Column<string>(
                        type: "nvarchar(max)",
                        nullable: true
                        )
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Państwa", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Państwa");
        }
    }
}
