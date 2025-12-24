using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SystemITI.API.Migrations
{
    /// <inheritdoc />
    public partial class Configration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "IsDefualt", "IsDelete", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0195442f-5b32-7334-9a35-d43ff70d3aa9", "0195442f-5b32-761a-b2ee-cfca69434828", false, false, "Admin", "ADMIN" },
                    { "0195442f-5b32-7b00-a097-61b7c3baec76", "0195442f-5b32-7bfc-8b9c-18f34c1d2eea", true, false, "Student", "STUDENT" },
                    { "0195442f-5b32-8000-b111-22aa33bb44cc", "0195442f-5b32-8001-c222-33bb44cc55dd", true, false, "Instructor", "INSTRUCTOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FName", "LName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "0195442f-5b32-7163-9117-b7023daacb2d", 0, "0195442f-5b32-7594-8754-260776e9cdcc", "admin@SchoolSystem.com", true, "SystemITI", "Admin", false, null, "ADMIN@SCHOOLSYSTEM.COM", "ADMIN@SCHOOLSYSTEM.COM", "AQAAAAIAAYagAAAAEES76XCzEAJzOKK3RHphtyNuJc52FtrqMqoDuSoo921MiNJ/llOGYPXIq92thIuxvg==", "01205024661", true, "55BF92C9EF0249CDA210D85D1A851BC9", false, "School-Project" });

            migrationBuilder.InsertData(
                table: "AspNetRoleClaims",
                columns: new[] { "Id", "ClaimType", "ClaimValue", "RoleId" },
                values: new object[,]
                {
                    { 1, "permissions", "Exam:Get", "0195442f-5b32-7334-9a35-d43ff70d3aa9" },
                    { 2, "permissions", "Exam:Generate", "0195442f-5b32-7334-9a35-d43ff70d3aa9" },
                    { 3, "permissions", "Exam:GetModelAnser", "0195442f-5b32-7334-9a35-d43ff70d3aa9" },
                    { 4, "permissions", "Exam:GetStudentAnswer", "0195442f-5b32-7334-9a35-d43ff70d3aa9" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "0195442f-5b32-7334-9a35-d43ff70d3aa9", "0195442f-5b32-7163-9117-b7023daacb2d" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0195442f-5b32-7b00-a097-61b7c3baec76");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0195442f-5b32-8000-b111-22aa33bb44cc");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0195442f-5b32-7334-9a35-d43ff70d3aa9", "0195442f-5b32-7163-9117-b7023daacb2d" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0195442f-5b32-7334-9a35-d43ff70d3aa9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0195442f-5b32-7163-9117-b7023daacb2d");
        }
    }
}
