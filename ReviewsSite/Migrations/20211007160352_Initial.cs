using Microsoft.EntityFrameworkCore.Migrations;

namespace ReviewsSite.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HauntedHouses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Duration = table.Column<int>(type: "int", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HauntedHouses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HauntedHouseId = table.Column<int>(type: "int", nullable: false),
                    Scareablity = table.Column<int>(type: "int", nullable: false),
                    Recommend = table.Column<bool>(type: "bit", nullable: false),
                    WouldReturn = table.Column<bool>(type: "bit", nullable: false),
                    StarRating = table.Column<int>(type: "int", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reviews_HauntedHouses_HauntedHouseId",
                        column: x => x.HauntedHouseId,
                        principalTable: "HauntedHouses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "HauntedHouses",
                columns: new[] { "Id", "Duration", "Location", "Name", "Price" },
                values: new object[] { 1, 30, "Canton, Ohio", "Carnival Of Horrors", 24.0 });

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_HauntedHouseId",
                table: "Reviews",
                column: "HauntedHouseId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "HauntedHouses");
        }
    }
}
