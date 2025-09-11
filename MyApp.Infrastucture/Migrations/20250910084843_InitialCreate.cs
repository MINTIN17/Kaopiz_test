using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MyApp.Infrastucture.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RoleClaims_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EndUser",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    LastModifiedBy = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EndUser", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EndUser_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Partner",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    About = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    LastModifiedBy = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Partner", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Partner_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserClaims_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_UserLogins_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_UserRoles_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserRoles_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserTokens",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_UserTokens_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { 1, null, "Admin", "ADMIN" },
                    { 2, null, "Partner", "PARTNER" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { 1, 0, "23a60e3b-4581-4a5b-9c45-7e53e85f00b7", null, false, false, null, null, "ADMIN", "AQAAAAIAAYagAAAAEMF6odRx0OWJWQP8jeCJsMr+DpX9+MW2DhVgwRfHuyS6Yo1YUaVNu6pSfD4ohfzpXA==", null, false, "2dde6a6b-4c37-445d-958b-bf207d6623c7", false, "Admin" },
                    { 2, 0, "41eb4612-4fa4-420a-bcc7-42503aa0dd50", "HoangQuan.Nguyen@yahoo.com", true, false, null, "HOANGQUAN.NGUYEN@YAHOO.COM", "HOANGQUAN.NGUYEN@YAHOO.COM", "AQAAAAIAAYagAAAAEMK5TJufDc3Pro880lHaJyJlTDyjCh9LR7pQy0Y5FbpRib9botumRB7vcIPPmsOBfA==", null, false, "8e7d578d-be52-49d1-b919-34adebc8d14b", false, "HoangQuan.Nguyen@yahoo.com" },
                    { 3, 0, "d28b7961-b3da-4690-8eeb-c346245a37f4", "NhatHoang.Le9@gmail.com", true, false, null, "NHATHOANG.LE9@GMAIL.COM", "NHATHOANG.LE9@GMAIL.COM", "AQAAAAIAAYagAAAAEH0Q+Zs7n1/fOZMADAdTJssLFM16h6vgoPG62xkA25mVewyNRiJ7Ac92M2ka28vxug==", null, false, "223942fe-10a1-4113-b505-a5b0e456eac0", false, "NhatHoang.Le9@gmail.com" },
                    { 4, 0, "b51c982e-04ee-40c9-b357-18c890bd487f", "HongHoa.Vu@hotmail.com", true, false, null, "HONGHOA.VU@HOTMAIL.COM", "HONGHOA.VU@HOTMAIL.COM", "AQAAAAIAAYagAAAAEGzQbyNNYz23WJWfSRPGvsd/7xcJZFu4PW4HqTSVCpQduOnT7nTPNzW0M6VfWzSyEw==", null, false, "662205d9-6ca9-40b2-a0f5-2a27c3c13a2c", false, "HongHoa.Vu@hotmail.com" },
                    { 5, 0, "2eb3a573-5381-4586-85ce-de0e5d8fca60", "ThuHue.Tran@hotmail.com", true, false, null, "THUHUE.TRAN@HOTMAIL.COM", "THUHUE.TRAN@HOTMAIL.COM", "AQAAAAIAAYagAAAAEKxu1nfVr3g7qDdymeACg/BqbwWr7ayOGC3fnXGE3aHfGJuu2HMoInb+WFGczSQE7g==", null, false, "6e28c6de-f9b6-4fcb-b896-49c2eddcb21a", false, "ThuHue.Tran@hotmail.com" },
                    { 6, 0, "19ca97cf-ecea-4428-ba49-97002c642acd", "NgocHai_Vu80@yahoo.com", true, false, null, "NGOCHAI_VU80@YAHOO.COM", "NGOCHAI_VU80@YAHOO.COM", "AQAAAAIAAYagAAAAEGFJxx3it1NR26NhZupLxiBXwkKLHWVfu0XNZECiaWUPBD8wzE0FsSJ5OUcR+TYySA==", null, false, "40a0c4fa-04f8-4e15-82f6-9dc24607db1c", false, "NgocHai_Vu80@yahoo.com" },
                    { 7, 0, "5dcc2e22-1056-4cee-a23c-659ba2cc8a60", "NgocThuan70@gmail.com", true, false, null, "NGOCTHUAN70@GMAIL.COM", "NGOCTHUAN70@GMAIL.COM", "AQAAAAIAAYagAAAAENdyuUec+SLXnXnwsfte60B4k0My6LZ+p1eMTd0rjUN9XSqVBIHLQfvTzislejg6UQ==", null, false, "d65a6769-62e2-431b-9449-67f46d2c3e65", false, "NgocThuan70@gmail.com" },
                    { 8, 0, "91dd7a5e-77cd-4e91-90fa-0fe7dd9efdf7", "MinhHanh16@gmail.com", true, false, null, "MINHHANH16@GMAIL.COM", "MINHHANH16@GMAIL.COM", "AQAAAAIAAYagAAAAEMGK5gfIsb434SkhS31epzobolK8zbvLJ7E16nbRTW+ejuqw3QT2U5mCS0m6XSb3ng==", null, false, "a2499cdf-057c-4d86-8d40-29adcd630cbc", false, "MinhHanh16@gmail.com" },
                    { 9, 0, "025be60d-c5eb-4d96-bab8-199c084030f0", "QuocQuy.Nguyen@gmail.com", true, false, null, "QUOCQUY.NGUYEN@GMAIL.COM", "QUOCQUY.NGUYEN@GMAIL.COM", "AQAAAAIAAYagAAAAEG8XEIaqc92iFqCQjEwbYbyUWOTD9Tquo4p4SMgoYjI0PogWQmEtQjA+SNjw0TbQ0g==", null, false, "759d0b03-c3d7-4214-a3c2-c6b76dc714a0", false, "QuocQuy.Nguyen@gmail.com" },
                    { 10, 0, "83890bd1-8c1d-4f56-b639-6ee8a82522db", "HaTien_Mai@hotmail.com", true, false, null, "HATIEN_MAI@HOTMAIL.COM", "HATIEN_MAI@HOTMAIL.COM", "AQAAAAIAAYagAAAAEHBMOmWiYOrimFKAX5aJtlUGY0PEjJhxvCScSizHH4VKhDwXxd9qp6orbNeY5xa6UQ==", null, false, "13b84bef-9379-4f68-973d-b1eb1a72d090", false, "HaTien_Mai@hotmail.com" },
                    { 11, 0, "8dba8044-b74b-49b9-8029-97cd9f218eee", "ChieuDuong.Ngo50@gmail.com", true, false, null, "CHIEUDUONG.NGO50@GMAIL.COM", "CHIEUDUONG.NGO50@GMAIL.COM", "AQAAAAIAAYagAAAAEOF9NJZaTMgSTqZicbnqbR7gXBTvJpBpz0AN2ZtQibH6XaeIMF6hYkkf5GtOsWkDEw==", null, false, "68dae171-e2c8-4581-8493-50cb3dbf0575", false, "ChieuDuong.Ngo50@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "EndUser",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "IsDeleted", "LastModifiedAt", "LastModifiedBy", "Phone", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "709-439-8534", 1 },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "546.832.4626", 2 },
                    { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "690.767.9394", 3 },
                    { 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "1-257-989-5151", 4 },
                    { 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "851-431-3959 x4043", 5 },
                    { 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "1-959-473-8224 x7766", 6 },
                    { 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "1-530-616-2880 x78179", 7 },
                    { 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "944.280.6688 x801", 8 },
                    { 9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "1-283-627-2085 x540", 9 },
                    { 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "1-866-564-5265", 10 },
                    { 11, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "429-430-6578", 11 }
                });

            migrationBuilder.InsertData(
                table: "Partner",
                columns: new[] { "Id", "About", "CreatedAt", "CreatedBy", "IsDeleted", "LastModifiedAt", "LastModifiedBy", "UserId" },
                values: new object[,]
                {
                    { 1, "Thông tin", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 2 },
                    { 2, "Thông tin", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 3 },
                    { 3, "Thông tin", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 4 },
                    { 4, "Thông tin", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 5 },
                    { 5, "Thông tin", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, 6 }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 2 },
                    { 2, 3 },
                    { 2, 4 },
                    { 2, 5 },
                    { 2, 6 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_EndUser_UserId",
                table: "EndUser",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Partner_UserId",
                table: "Partner",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_RoleClaims_RoleId",
                table: "RoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "Roles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_UserClaims_UserId",
                table: "UserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserLogins_UserId",
                table: "UserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_RoleId",
                table: "UserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "Users",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "Users",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EndUser");

            migrationBuilder.DropTable(
                name: "Partner");

            migrationBuilder.DropTable(
                name: "RoleClaims");

            migrationBuilder.DropTable(
                name: "UserClaims");

            migrationBuilder.DropTable(
                name: "UserLogins");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "UserTokens");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
