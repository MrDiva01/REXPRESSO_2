using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Rexpresso_2.Migrations
{
    /// <inheritdoc />
    public partial class FourthMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "15f4e21d-68c6-4087-a63b-3a6d5cb3b00e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7508b141-9c27-4aec-bf0e-87afb5770272");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c61c9719-2983-41e1-9553-40e6da520ce2");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "63a6112a-c6b0-4780-95b1-644d5e5ecbd4", null, "admin", "admin" },
                    { "71fd3a59-9c83-4ed7-a7e3-70b9351704cf", null, "client", "client" },
                    { "8197f001-4abc-46a5-a813-4bc0427efa04", null, "seller", "seller" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "63a6112a-c6b0-4780-95b1-644d5e5ecbd4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "71fd3a59-9c83-4ed7-a7e3-70b9351704cf");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8197f001-4abc-46a5-a813-4bc0427efa04");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "15f4e21d-68c6-4087-a63b-3a6d5cb3b00e", null, "seller", null },
                    { "7508b141-9c27-4aec-bf0e-87afb5770272", null, "admin", "seller" },
                    { "c61c9719-2983-41e1-9553-40e6da520ce2", null, "client", null }
                });
        }
    }
}
