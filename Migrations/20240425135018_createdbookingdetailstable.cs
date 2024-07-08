using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RestaurantBookingWebApi.Migrations
{
    /// <inheritdoc />
    public partial class createdbookingdetailstable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RestaurantBookingDetails",
                columns: table => new
                {
                    bookingId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    date = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    startTime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    endTime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    tableNo = table.Column<int>(type: "int", nullable: false),
                    restaurantId = table.Column<int>(type: "int", nullable: false),
                    userId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RestaurantBookingDetails", x => x.bookingId);
                    table.ForeignKey(
                        name: "FK_RestaurantBookingDetails_RestaurantList_restaurantId",
                        column: x => x.restaurantId,
                        principalTable: "RestaurantList",
                        principalColumn: "restaurantId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RestaurantBookingDetails_UserList_userId",
                        column: x => x.userId,
                        principalTable: "UserList",
                        principalColumn: "userId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_RestaurantBookingDetails_restaurantId",
                table: "RestaurantBookingDetails",
                column: "restaurantId");

            migrationBuilder.CreateIndex(
                name: "IX_RestaurantBookingDetails_userId",
                table: "RestaurantBookingDetails",
                column: "userId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RestaurantBookingDetails");
        }
    }
}
