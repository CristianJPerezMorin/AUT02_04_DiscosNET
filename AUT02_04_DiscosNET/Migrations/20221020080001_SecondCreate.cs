using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AUT02_04_DiscosNET.Migrations
{
    public partial class SecondCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2f630a63-7788-4960-a3df-1b083d80344f", "ad76b858-7ce8-44f7-b71f-91c3bf7f3578", "Admin", "ADMIN" },
                    { "301def20-0c8a-4491-bc06-13f2e7808a2f", "28d591df-3ee3-40fa-bc8a-29daa0ea87d5", "Manager", "MANAGER" },
                    { "cfb17cfa-72fc-474a-9c8c-b19a0ef840cd", "47a87df5-3a65-427b-ace0-a68ade3229a6", "Default", "DEFAULT" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "0c2a61ac-f4b6-4e5f-9909-9c965226c552", 0, "c1103be8-52fb-42e9-8a25-7146c5a59e9f", "Admin@disquera.com", true, false, null, "ADMIN@DISQUERA.COM", "ADMIN@DISQUERA.COM", "AQAAAAEAACcQAAAAEJWsQK+ym34YYicKr4ZgFQ7TIRaIAhn7pBPU2m8ugobAaJuUhqsrUExryscl1dZKyg==", null, false, "a062cbb6-921f-4faa-9bd6-5403fe82fd56", false, "Admin@disquera.com" },
                    { "7756a2fb-c453-46c7-9b24-ea727603d7b3", 0, "ed885e10-8d5e-4a4a-90a1-cc5cfc3e971d", "Manager@disquera.com", true, false, null, "MANAGER@DISQUERA.COM", "MANAGER@DISQUERA.COM", "AQAAAAEAACcQAAAAEB3QGwqY5jYshNgN1Xbw9gG7VP1ZlyNQ5pFx3QFzO4/AkP5BzvSWnQK3u4YmkjsVLg==", null, false, "9c65f01f-4411-4e10-ab54-6e34c714b4e1", false, "Manager@disquera.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "2f630a63-7788-4960-a3df-1b083d80344f", "0c2a61ac-f4b6-4e5f-9909-9c965226c552" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "301def20-0c8a-4491-bc06-13f2e7808a2f", "7756a2fb-c453-46c7-9b24-ea727603d7b3" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cfb17cfa-72fc-474a-9c8c-b19a0ef840cd");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2f630a63-7788-4960-a3df-1b083d80344f", "0c2a61ac-f4b6-4e5f-9909-9c965226c552" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "301def20-0c8a-4491-bc06-13f2e7808a2f", "7756a2fb-c453-46c7-9b24-ea727603d7b3" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2f630a63-7788-4960-a3df-1b083d80344f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "301def20-0c8a-4491-bc06-13f2e7808a2f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0c2a61ac-f4b6-4e5f-9909-9c965226c552");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7756a2fb-c453-46c7-9b24-ea727603d7b3");
        }
    }
}
