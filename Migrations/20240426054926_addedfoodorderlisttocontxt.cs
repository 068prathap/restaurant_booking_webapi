using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RestaurantBookingWebApi.Migrations
{
    /// <inheritdoc />
    public partial class addedfoodorderlisttocontxt : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FoodOrdersList",
                columns: table => new
                {
                    foodOrderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    foodName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    foodPrice = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    foodQuantity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    bookingId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodOrdersList", x => x.foodOrderId);
                    table.ForeignKey(
                        name: "FK_FoodOrdersList_RestaurantBookingDetails_bookingId",
                        column: x => x.bookingId,
                        principalTable: "RestaurantBookingDetails",
                        principalColumn: "bookingId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FoodOrdersList_bookingId",
                table: "FoodOrdersList",
                column: "bookingId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FoodOrdersList");
        }
    }
}
