using Microsoft.EntityFrameworkCore.Migrations;

namespace ReviewsSite.Migrations
{
    public partial class AddedHauntedHouses : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "HauntedHouses",
                columns: new[] { "Id", "Duration", "Location", "Name", "Price" },
                values: new object[,]
                {
                    { 2, 60, "Cleveland, Ohio", "Seven Floors of Hell", 30.0 },
                    { 3, 30, "Columbus, Ohio", "Fear Columbus", 19.99 },
                    { 4, 45, "Mansfield, Ohio", "Escape from Blood Prison", 25.0 },
                    { 5, 30, "Broadview Heights, Ohio", "Bloodview Haunted House", 30.0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "HauntedHouses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "HauntedHouses",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "HauntedHouses",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "HauntedHouses",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
