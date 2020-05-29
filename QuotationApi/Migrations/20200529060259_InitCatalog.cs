using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace QuotationApi.Migrations
{
    public partial class InitCatalog : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Quotations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    QuotationText = table.Column<string>(nullable: false),
                    Author = table.Column<string>(nullable: true),
                    PubDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quotations", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Quotations",
                columns: new[] { "Id", "Author", "PubDate", "QuotationText" },
                values: new object[] { 1, "Aziz", new DateTime(2020, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Да прибудет с тобой сила, мой юный падаван" });

            migrationBuilder.InsertData(
                table: "Quotations",
                columns: new[] { "Id", "Author", "PubDate", "QuotationText" },
                values: new object[] { 2, "Khurshed", new DateTime(2020, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Не надо мелочиться, нужно рубить с корня" });

            migrationBuilder.InsertData(
                table: "Quotations",
                columns: new[] { "Id", "Author", "PubDate", "QuotationText" },
                values: new object[] { 3, "Firdavs", new DateTime(2020, 2, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Французишь друг мой" });

            migrationBuilder.InsertData(
                table: "Quotations",
                columns: new[] { "Id", "Author", "PubDate", "QuotationText" },
                values: new object[] { 4, "Shahzod", new DateTime(2020, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kali лучше чем parrot" });

            migrationBuilder.InsertData(
                table: "Quotations",
                columns: new[] { "Id", "Author", "PubDate", "QuotationText" },
                values: new object[] { 5, "Amin", new DateTime(2020, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Много поколений процессоров не бывает" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Quotations");
        }
    }
}
