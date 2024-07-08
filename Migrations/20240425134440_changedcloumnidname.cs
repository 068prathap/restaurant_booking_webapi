using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RestaurantBookingWebApi.Migrations
{
    /// <inheritdoc />
    public partial class changedcloumnidname : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "id",
                table: "UserList",
                newName: "userId");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "RestaurantList",
                newName: "restaurantId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "userId",
                table: "UserList",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "restaurantId",
                table: "RestaurantList",
                newName: "id");
        }
    }
}
