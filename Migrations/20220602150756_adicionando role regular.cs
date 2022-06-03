using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UsuarioAluraFlix.Migrations
{
    public partial class adicionandoroleregular : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 999999998,
                column: "ConcurrencyStamp",
                value: "2dab14b6-4b73-463b-bad6-a0538f14d82c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 999999999,
                column: "ConcurrencyStamp",
                value: "14308316-7605-47e4-b402-8d19a3b22a5d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 999999999,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0fed5b4e-9738-4c50-8a01-df49819b673c", "AQAAAAEAACcQAAAAEN2PiSGFmu7W20zszerEGHlQFR60ts9HQicVNbbM4UgbfgLc9hpX7X6PTb7faY1aWA==", "37cdf163-4646-4099-b0f1-775d0138fa0d" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { 999999998, 0, "e01a831d-175b-4af4-afa9-04bf04437e08", null, true, false, null, "USER@USER.COM", "USER", "AQAAAAEAACcQAAAAENcNAKVcT863mt/G+WcKHrG0GNVXULpH7dxIrcTTwc5RJd0HhrlU4OVUm6J6IvplMg==", null, false, "80424aa1-2587-4432-bf8d-4f4d857faffb", false, "user" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { 999999998, 999999998 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 999999998, 999999998 });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 999999998);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 999999998,
                column: "ConcurrencyStamp",
                value: "2851e0b2-bea6-4797-bd4b-8536622d3848");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 999999999,
                column: "ConcurrencyStamp",
                value: "e29f7550-63a2-411b-b41b-2bb1caadacb5");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 999999999,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "90ef5274-756c-41d4-8274-5b6ed89408d1", "AQAAAAEAACcQAAAAEPgRbMMSGtT7WhOIfgQo2OG5oyo7SgYLbQAlipVEKG2b/6c7WSKt7dIAZgiueltfJQ==", "7bf0eb51-7dc7-400b-bcf5-ad63310a4611" });
        }
    }
}
