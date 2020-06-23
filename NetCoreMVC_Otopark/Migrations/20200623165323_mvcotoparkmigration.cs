using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NetCoreMVC_Otopark.Migrations
{
    public partial class mvcotoparkmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "aracs",
                columns: table => new
                {
                    AracID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AracPlaka = table.Column<string>(nullable: true),
                    GirisTarihi = table.Column<DateTime>(nullable: false),
                    CikisTarihi = table.Column<DateTime>(nullable: false),
                    Aktiflik = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_aracs", x => x.AracID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "aracs");
        }
    }
}
