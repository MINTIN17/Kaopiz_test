using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MyApp.Infrastucture.Migrations
{
    /// <inheritdoc />
    public partial class SeedRandom : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EndUser",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "EndUser",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "EndUser",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "EndUser",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "EndUser",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "EndUser",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.UpdateData(
                table: "EndUser",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Phone", "UserId" },
                values: new object[] { "(897) 944-1478 x7331", 7 });

            migrationBuilder.UpdateData(
                table: "EndUser",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Phone", "UserId" },
                values: new object[] { "(824) 519-7112 x18210", 8 });

            migrationBuilder.UpdateData(
                table: "EndUser",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Phone", "UserId" },
                values: new object[] { "567.280.2973", 9 });

            migrationBuilder.UpdateData(
                table: "EndUser",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Phone", "UserId" },
                values: new object[] { "1-338-740-7061 x54884", 10 });

            migrationBuilder.UpdateData(
                table: "EndUser",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Phone", "UserId" },
                values: new object[] { "502.378.7909", 11 });

            migrationBuilder.UpdateData(
                table: "Partner",
                keyColumn: "Id",
                keyValue: 1,
                column: "About",
                value: "Thông tin partner");

            migrationBuilder.UpdateData(
                table: "Partner",
                keyColumn: "Id",
                keyValue: 2,
                column: "About",
                value: "Thông tin partner");

            migrationBuilder.UpdateData(
                table: "Partner",
                keyColumn: "Id",
                keyValue: 3,
                column: "About",
                value: "Thông tin partner");

            migrationBuilder.UpdateData(
                table: "Partner",
                keyColumn: "Id",
                keyValue: 4,
                column: "About",
                value: "Thông tin partner");

            migrationBuilder.UpdateData(
                table: "Partner",
                keyColumn: "Id",
                keyValue: 5,
                column: "About",
                value: "Thông tin partner");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "Email", "EmailConfirmed", "NormalizedEmail", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bbc55759-58b0-47a6-a3a5-8ccb42198b77", "admin@myapp.com", true, "ADMIN@MYAPP.COM", "AQAAAAIAAYagAAAAEKkefW0d2Q+u88zNnfwVk8XJK8r3UxstHuiKJZfWV7aEl30sveqPrG4IXdH0yGgegQ==", "7bac8f18-8c80-4cea-aed5-94101b858d50" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "7566b090-78d3-43e7-abdc-0b7c12c6bf83", "TichThien_Phan@gmail.com", "TICHTHIEN_PHAN@GMAIL.COM", "TUANDUC.LAM70", "AQAAAAIAAYagAAAAEIR7zKyNa9wW9ePe93q9Nwgbh6/T6KR8GeAPUH7SbA5L93eAa45m33/JCqtwXw2N+w==", "5cd89b95-5a0a-4bd2-a5e7-6a90d25ee719", "TuanDuc.Lam70" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "ea8b6310-5c1c-440b-8840-39e7576b321f", "TuongAnh_Tang@yahoo.com", "TUONGANH_TANG@YAHOO.COM", "MYTRANG38", "AQAAAAIAAYagAAAAEI9x9kc2dJi+4Enuku7Wl2Yi0LxqDRDkayJ5e7EbbuY6n6EcNxE/8KJya1aiO6ugIg==", "727ae5d8-30b8-4c36-9993-718f93434f37", "MyTrang38" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "5b108a5d-be8e-48d2-ad13-ddc19cfc1046", "XuanNhien74@gmail.com", "XUANNHIEN74@GMAIL.COM", "BAOSON_LE", "AQAAAAIAAYagAAAAEGBLKglSMySaZVH+GVVXJNb+U4tc7br+12fWLAECCsANstVse4YjB51BBZ9Mh578mA==", "cf352a96-d961-4c92-8ab9-14fc94a9e90a", "BaoSon_Le" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "c1f9dbff-512e-43dc-8b8c-f7ae71a676d7", "MaiLinh74@yahoo.com", "MAILINH74@YAHOO.COM", "BICHLIEN23", "AQAAAAIAAYagAAAAELwTqcFsHsvWQY1uR36irSVQi9uBDAi//s6skvpQi83MRlYHjgWxXbq5T6asI+t3lg==", "ca6b6420-219e-4496-83e4-514e3bd53678", "BichLien23" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "393d58aa-2ff3-463f-abd5-7667580895ed", "TrangNha_Do@yahoo.com", "TRANGNHA_DO@YAHOO.COM", "KHIETLINH87", "AQAAAAIAAYagAAAAEAxhg/LAeO7KInaMGSNkllt4fYpl9QiicnlshD53oOKWO0kjXy1ioH7Cbw+lsRS+tg==", "3c304075-2c7c-4793-8c22-16954a83549f", "KhietLinh87" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "533f9dc0-5783-48f7-a255-2dda1a7b7403", "ThuHa.Lam55@hotmail.com", "THUHA.LAM55@HOTMAIL.COM", "NHATNAM.TO", "AQAAAAIAAYagAAAAEI5Oy+yqH/go0wALBfMCQY9hROlIHQa6A5Cstd7SZ4rPD5VoXCCbwUYs83w2Tagbrw==", "ced8b322-7843-4473-a843-8d54b34c4917", "NhatNam.To" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "d97a7139-5c24-4a6d-bfec-cba5d4924a0d", "HuyenThu_Vuong81@hotmail.com", "HUYENTHU_VUONG81@HOTMAIL.COM", "DUYTAM_NGUYEN", "AQAAAAIAAYagAAAAEG64/k33Oja0OGN2Of/ag8jzOfEtljlGpGQTcb7jztUijSgXQ1/5pmllVhKK7T4G6A==", "4d3bb072-f04c-41ed-9d45-131f2d8294eb", "DuyTam_Nguyen" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "ffdcec70-9c28-4f08-9383-ac9375d7d07e", "DiemLoc42@gmail.com", "DIEMLOC42@GMAIL.COM", "LETHU51", "AQAAAAIAAYagAAAAEOpXrvJZXLeS3TFeWx1UZqzqIJkdMXLmffS4z/3hUf6KM6+AJEkA+jxEhVrjurLJMw==", "698e6d7f-d9fe-445d-a7ab-90214465579b", "LeThu51" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "b99667e4-9a82-46a3-adc5-f1f7e25f4338", "ThuyVan70@hotmail.com", "THUYVAN70@HOTMAIL.COM", "HANHNHON11", "AQAAAAIAAYagAAAAEKamW2A8OZloe5pNKzwb5w5wEb7sIKG0zWWBrqygJQH8JdwoQyehJX/0BnGbM7kLXw==", "6a6c664d-3325-4b80-98b3-ff082be3837c", "HanhNhon11" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "3070e4da-8367-4eb2-9ec1-6173e4c1e244", "UyenPhuong54@hotmail.com", "UYENPHUONG54@HOTMAIL.COM", "HOAIBAC.HA69", "AQAAAAIAAYagAAAAEDHn/QLWeIhe2UqnBuxZUQZGXP/qk1FEXkMEeNDOCMTUK8T5WxUc6NEYqgvDDTP3og==", "9bbed01b-61c5-4c77-b0df-ca6d184e16cf", "HoaiBac.Ha69" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "EndUser",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Phone", "UserId" },
                values: new object[] { "1-959-473-8224 x7766", 6 });

            migrationBuilder.UpdateData(
                table: "EndUser",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Phone", "UserId" },
                values: new object[] { "1-530-616-2880 x78179", 7 });

            migrationBuilder.UpdateData(
                table: "EndUser",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Phone", "UserId" },
                values: new object[] { "944.280.6688 x801", 8 });

            migrationBuilder.UpdateData(
                table: "EndUser",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Phone", "UserId" },
                values: new object[] { "1-283-627-2085 x540", 9 });

            migrationBuilder.UpdateData(
                table: "EndUser",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Phone", "UserId" },
                values: new object[] { "1-866-564-5265", 10 });

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
                    { 11, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "429-430-6578", 11 }
                });

            migrationBuilder.UpdateData(
                table: "Partner",
                keyColumn: "Id",
                keyValue: 1,
                column: "About",
                value: "Thông tin");

            migrationBuilder.UpdateData(
                table: "Partner",
                keyColumn: "Id",
                keyValue: 2,
                column: "About",
                value: "Thông tin");

            migrationBuilder.UpdateData(
                table: "Partner",
                keyColumn: "Id",
                keyValue: 3,
                column: "About",
                value: "Thông tin");

            migrationBuilder.UpdateData(
                table: "Partner",
                keyColumn: "Id",
                keyValue: 4,
                column: "About",
                value: "Thông tin");

            migrationBuilder.UpdateData(
                table: "Partner",
                keyColumn: "Id",
                keyValue: 5,
                column: "About",
                value: "Thông tin");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "Email", "EmailConfirmed", "NormalizedEmail", "PasswordHash", "SecurityStamp" },
                values: new object[] { "23a60e3b-4581-4a5b-9c45-7e53e85f00b7", null, false, null, "AQAAAAIAAYagAAAAEMF6odRx0OWJWQP8jeCJsMr+DpX9+MW2DhVgwRfHuyS6Yo1YUaVNu6pSfD4ohfzpXA==", "2dde6a6b-4c37-445d-958b-bf207d6623c7" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "41eb4612-4fa4-420a-bcc7-42503aa0dd50", "HoangQuan.Nguyen@yahoo.com", "HOANGQUAN.NGUYEN@YAHOO.COM", "HOANGQUAN.NGUYEN@YAHOO.COM", "AQAAAAIAAYagAAAAEMK5TJufDc3Pro880lHaJyJlTDyjCh9LR7pQy0Y5FbpRib9botumRB7vcIPPmsOBfA==", "8e7d578d-be52-49d1-b919-34adebc8d14b", "HoangQuan.Nguyen@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "d28b7961-b3da-4690-8eeb-c346245a37f4", "NhatHoang.Le9@gmail.com", "NHATHOANG.LE9@GMAIL.COM", "NHATHOANG.LE9@GMAIL.COM", "AQAAAAIAAYagAAAAEH0Q+Zs7n1/fOZMADAdTJssLFM16h6vgoPG62xkA25mVewyNRiJ7Ac92M2ka28vxug==", "223942fe-10a1-4113-b505-a5b0e456eac0", "NhatHoang.Le9@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "b51c982e-04ee-40c9-b357-18c890bd487f", "HongHoa.Vu@hotmail.com", "HONGHOA.VU@HOTMAIL.COM", "HONGHOA.VU@HOTMAIL.COM", "AQAAAAIAAYagAAAAEGzQbyNNYz23WJWfSRPGvsd/7xcJZFu4PW4HqTSVCpQduOnT7nTPNzW0M6VfWzSyEw==", "662205d9-6ca9-40b2-a0f5-2a27c3c13a2c", "HongHoa.Vu@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "2eb3a573-5381-4586-85ce-de0e5d8fca60", "ThuHue.Tran@hotmail.com", "THUHUE.TRAN@HOTMAIL.COM", "THUHUE.TRAN@HOTMAIL.COM", "AQAAAAIAAYagAAAAEKxu1nfVr3g7qDdymeACg/BqbwWr7ayOGC3fnXGE3aHfGJuu2HMoInb+WFGczSQE7g==", "6e28c6de-f9b6-4fcb-b896-49c2eddcb21a", "ThuHue.Tran@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "19ca97cf-ecea-4428-ba49-97002c642acd", "NgocHai_Vu80@yahoo.com", "NGOCHAI_VU80@YAHOO.COM", "NGOCHAI_VU80@YAHOO.COM", "AQAAAAIAAYagAAAAEGFJxx3it1NR26NhZupLxiBXwkKLHWVfu0XNZECiaWUPBD8wzE0FsSJ5OUcR+TYySA==", "40a0c4fa-04f8-4e15-82f6-9dc24607db1c", "NgocHai_Vu80@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "5dcc2e22-1056-4cee-a23c-659ba2cc8a60", "NgocThuan70@gmail.com", "NGOCTHUAN70@GMAIL.COM", "NGOCTHUAN70@GMAIL.COM", "AQAAAAIAAYagAAAAENdyuUec+SLXnXnwsfte60B4k0My6LZ+p1eMTd0rjUN9XSqVBIHLQfvTzislejg6UQ==", "d65a6769-62e2-431b-9449-67f46d2c3e65", "NgocThuan70@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "91dd7a5e-77cd-4e91-90fa-0fe7dd9efdf7", "MinhHanh16@gmail.com", "MINHHANH16@GMAIL.COM", "MINHHANH16@GMAIL.COM", "AQAAAAIAAYagAAAAEMGK5gfIsb434SkhS31epzobolK8zbvLJ7E16nbRTW+ejuqw3QT2U5mCS0m6XSb3ng==", "a2499cdf-057c-4d86-8d40-29adcd630cbc", "MinhHanh16@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "025be60d-c5eb-4d96-bab8-199c084030f0", "QuocQuy.Nguyen@gmail.com", "QUOCQUY.NGUYEN@GMAIL.COM", "QUOCQUY.NGUYEN@GMAIL.COM", "AQAAAAIAAYagAAAAEG8XEIaqc92iFqCQjEwbYbyUWOTD9Tquo4p4SMgoYjI0PogWQmEtQjA+SNjw0TbQ0g==", "759d0b03-c3d7-4214-a3c2-c6b76dc714a0", "QuocQuy.Nguyen@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "83890bd1-8c1d-4f56-b639-6ee8a82522db", "HaTien_Mai@hotmail.com", "HATIEN_MAI@HOTMAIL.COM", "HATIEN_MAI@HOTMAIL.COM", "AQAAAAIAAYagAAAAEHBMOmWiYOrimFKAX5aJtlUGY0PEjJhxvCScSizHH4VKhDwXxd9qp6orbNeY5xa6UQ==", "13b84bef-9379-4f68-973d-b1eb1a72d090", "HaTien_Mai@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "8dba8044-b74b-49b9-8029-97cd9f218eee", "ChieuDuong.Ngo50@gmail.com", "CHIEUDUONG.NGO50@GMAIL.COM", "CHIEUDUONG.NGO50@GMAIL.COM", "AQAAAAIAAYagAAAAEOF9NJZaTMgSTqZicbnqbR7gXBTvJpBpz0AN2ZtQibH6XaeIMF6hYkkf5GtOsWkDEw==", "68dae171-e2c8-4581-8493-50cb3dbf0575", "ChieuDuong.Ngo50@gmail.com" });
        }
    }
}
