using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyApp.Infrastucture.Migrations
{
    /// <inheritdoc />
    public partial class UpdateSeedData1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "EndUser",
                keyColumn: "Id",
                keyValue: 6,
                column: "Adress",
                value: "6137 Terry Roads");

            migrationBuilder.UpdateData(
                table: "EndUser",
                keyColumn: "Id",
                keyValue: 7,
                column: "Adress",
                value: "3159 Okuneva Center");

            migrationBuilder.UpdateData(
                table: "EndUser",
                keyColumn: "Id",
                keyValue: 8,
                column: "Adress",
                value: "82861 Marisa Forks");

            migrationBuilder.UpdateData(
                table: "EndUser",
                keyColumn: "Id",
                keyValue: 9,
                column: "Adress",
                value: "9472 Zemlak Corners");

            migrationBuilder.UpdateData(
                table: "EndUser",
                keyColumn: "Id",
                keyValue: 10,
                column: "Adress",
                value: "12315 Mathew Shore");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "94e9a03a-a799-49c0-80ba-479bf757f801", "AQAAAAIAAYagAAAAEOR90bP3IMZuJkhRpFdSEdPf0lM8hcOGc8bP+89XMyWkMNO2i2+43+jAEQunWo8/pg==", "a73bf126-11cc-4b41-9a6e-b0a865c6d4f5" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "7831bc4c-08a9-420d-ae31-9994f5b8e287", "PhuongChi53@gmail.com", "Nguyễn Bích San", "PHUONGCHI53@GMAIL.COM", "PHUONGCHI53@GMAIL.COM", "AQAAAAIAAYagAAAAEPABKew4A/tw1pmWWLvPesGz0TbyYXGoPqw3kdStiYgd/BQrUFFkfM5dNpRzGA83TQ==", "0286 1464 7988", "3638ef2f-cfd9-4406-b8bd-37efe74d21c0", "PhuongChi53@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "edda715c-8cab-4c56-96eb-6949497d1d14", "HuyenAnh_Ly@yahoo.com", "Phan Ðông Vy", "HUYENANH_LY@YAHOO.COM", "HUYENANH_LY@YAHOO.COM", "AQAAAAIAAYagAAAAECwxdfc23l35DQsfYlpFtWBxwaPp22D5kkf7rKE3BNxibub1O0CKgkY/skfuThfLdQ==", "0240 4318 6497", "81d8d5bf-652f-4a0f-a701-e53bb474deea", "HuyenAnh_Ly@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "888dcd5c-a9f3-4769-a984-accf2053157c", "DinhHuong1@hotmail.com", "Lê Quốc Trường", "DINHHUONG1@HOTMAIL.COM", "DINHHUONG1@HOTMAIL.COM", "AQAAAAIAAYagAAAAELnbgfYbgUWIA6uYd44PZTpThe7hkZVvAwgBGf+SLgiIHcVymklavOlGLhecdd2//Q==", "025 8919 8135", "6450cb4c-75d6-4ce9-82e8-295b87e4b134", "DinhHuong1@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "a00df942-3249-443a-a3bf-64ec486e1445", "HuuKhang_Vu@gmail.com", "Trương Tiến Dũng", "HUUKHANG_VU@GMAIL.COM", "HUUKHANG_VU@GMAIL.COM", "AQAAAAIAAYagAAAAELnDbGbiYJIEQBW0X0ziXayu1huqXcXjoZjtGIKh3hX2TQNwN17NAVp/dlVPkH+m3w==", "0274 4742 3810", "a6adb77d-3fd8-4c03-9188-f6a297e1842e", "HuuKhang_Vu@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "ee322fe0-9f17-4a76-87e2-4f718a9b9a6c", "NhatDa.Trinh36@yahoo.com", "Hồ Kiều Mai", "NHATDA.TRINH36@YAHOO.COM", "NHATDA.TRINH36@YAHOO.COM", "AQAAAAIAAYagAAAAELrIK3Ak5iY8gqdqqUe6tROkWplmwO9jyeyv9c0zujazJmERxmMkat8NvXGdI5HJWg==", "0282 5168 1653", "40d86b3a-77d7-49f1-96be-67dae516a300", "NhatDa.Trinh36@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "88f91a43-f685-4eae-a712-9c55e14825fe", "XuanNhien_Ly30@gmail.com", "Mai Đan Thư", "XUANNHIEN_LY30@GMAIL.COM", "XUANNHIEN_LY30@GMAIL.COM", "AQAAAAIAAYagAAAAEHJ1tYzaxdTfQBCmZCC0U4CYPoBL2xMqe6AXUK8r7o1aJ8AXcBt02MWCJcE3j/UZ+A==", "0273 7065 8818", "b4080f37-7dd6-403b-954c-88b69d85a840", "XuanNhien_Ly30@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "0346be65-da88-4a4c-abad-fc07e9eec8f3", "KhanhChi_Ha29@yahoo.com", "Dương Hữu Vượng", "KHANHCHI_HA29@YAHOO.COM", "KHANHCHI_HA29@YAHOO.COM", "AQAAAAIAAYagAAAAEFIQAD7Bv9ARxc7BajXNsj2oR/pJmxZ5yt/ji7mNoHHItkbvMlg0+3TH4Dxpo0A13g==", "023 6374 5685", "bbf25849-28fa-4f06-bc5f-dee674f93f90", "KhanhChi_Ha29@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "26e5326a-cb00-4dd6-8f96-06c3cb9b6393", "QuocViet.Do@yahoo.com", "Dương Thiên Lương", "QUOCVIET.DO@YAHOO.COM", "QUOCVIET.DO@YAHOO.COM", "AQAAAAIAAYagAAAAEBGs4KvQejAkjfZuYKCHcEWh5XKdBlbzskEObVbBhlbZ/6HN+CuiRpPTUAvL3LaMLg==", "024 2266 5333", "ddbfc23b-4a7b-4d39-91cd-6cc26f044733", "QuocViet.Do@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "b4711e7e-9364-412e-849d-f50ac3e34b54", "TheDung.Dinh65@yahoo.com", "Đỗ Hữu Thiện", "THEDUNG.DINH65@YAHOO.COM", "THEDUNG.DINH65@YAHOO.COM", "AQAAAAIAAYagAAAAELpaky6ys+0H+A/dtRz/ye9+Y0HCgL7hqO776d+D7WLUOm6V3z8QXgRB0KhZs7Ti1A==", "025 1641 0774", "6399115d-3d94-4ef2-b9e5-c4764beead2e", "TheDung.Dinh65@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "25f264fc-6155-4ffe-8e25-6ce966f13b89", "HiepHa9@yahoo.com", "Trương Gia Khánh", "HIEPHA9@YAHOO.COM", "HIEPHA9@YAHOO.COM", "AQAAAAIAAYagAAAAEAW46z38dBTxBlz6mF52W2DYRoNGs4clC5XiV8BhSctt04RYPtxoS7suHVfnRqwNgA==", "0251 8172 4122", "acda77ff-3d1f-46bd-ae6f-2533d71cd212", "HiepHa9@yahoo.com" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "EndUser",
                keyColumn: "Id",
                keyValue: 6,
                column: "Adress",
                value: "42758 Casper Forges");

            migrationBuilder.UpdateData(
                table: "EndUser",
                keyColumn: "Id",
                keyValue: 7,
                column: "Adress",
                value: "34373 Reyes Islands");

            migrationBuilder.UpdateData(
                table: "EndUser",
                keyColumn: "Id",
                keyValue: 8,
                column: "Adress",
                value: "5926 Schroeder Terrace");

            migrationBuilder.UpdateData(
                table: "EndUser",
                keyColumn: "Id",
                keyValue: 9,
                column: "Adress",
                value: "87835 Bauch Radial");

            migrationBuilder.UpdateData(
                table: "EndUser",
                keyColumn: "Id",
                keyValue: 10,
                column: "Adress",
                value: "90710 Jordy Square");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1cf6d5dc-e427-4c32-b2b4-d1d130a88084", "AQAAAAIAAYagAAAAEF8c3DAmLzTLoFg9A1goyLyVzFRGVKTxBy7ZyyqnqWBrQFd1/ZED68eOpaYAErUKPQ==", "81798fef-9569-4b18-93b3-e2f1dad111c9" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "70f44db2-8bb3-4c5f-b262-fce5ddf2ddb4", "QuangNinh38@hotmail.com", "Phan Kim Đan", "QUANGNINH38@HOTMAIL.COM", null, "AQAAAAIAAYagAAAAENP4ttfhWG05v+KoGBNdoDRtgWC6CDuwLxjBJcRed0R7dPBYePnb1zSt7TuvZXRX5g==", "026 9165 3839", "5fd44595-1e1a-40f6-8b4c-cf0eb04f3614", "QuangNinh38@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "e8874f86-99ad-4bf2-9140-f61efaa96cd0", "LanThuong.Ngo57@gmail.com", "Đinh Hải Ngân", "LANTHUONG.NGO57@GMAIL.COM", null, "AQAAAAIAAYagAAAAELHtGQM1NGRRsmKGAESuxbuui8iQasn7FeHEqj6ANDW5NunwciJT/fnRTv0kF4984g==", "0219 0280 6460", "f3b29d1d-6474-4ba2-b3e6-362c1aded004", "LanThuong.Ngo57@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "614332b6-daf6-42d1-9914-2bf5058566aa", "MinhPhuong.Dang0@hotmail.com", "Vương Mộng Quỳnh", "MINHPHUONG.DANG0@HOTMAIL.COM", null, "AQAAAAIAAYagAAAAEG7EL6HlM+WobQ8H8uzZy6AIFZqCwaILJi/qIFxwuM7H6NX1FBDoaUcsiA6u5vvfWA==", "028 9207 7539", "d58f1b31-3ee8-4a62-b93b-a9f7f0a39e6a", "MinhPhuong.Dang0@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "6accfb63-34d7-48fb-acde-a0d47307b273", "LeQuyen_Hoang3@yahoo.com", "Nguyễn Trọng Nghĩa", "LEQUYEN_HOANG3@YAHOO.COM", null, "AQAAAAIAAYagAAAAEPeTNkAHE6xlMZfJfMnbOBsa5aREckMM5kGONBq63L6LD76SR5dQjqFaDYHGG2NXGA==", "0235 3497 1579", "51bea0aa-cc7e-4535-b34c-898c58955d7f", "LeQuyen_Hoang3@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "0cc812d6-8be8-44d9-84e5-3b5229cd8891", "HoaLac.Phan@hotmail.com", "Lý Diệu Ngà", "HOALAC.PHAN@HOTMAIL.COM", null, "AQAAAAIAAYagAAAAEFF2Uvtlfb3JHByz8W4tguLBvyGWh3Im7o8rTYlAQKdLMrtlNAYtLS005kQPqqRnjw==", "0244 1253 5286", "318cf5fd-2a44-4ad0-9677-1f9146e3d52d", "HoaLac.Phan@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "ebbc948b-e285-4c82-9a33-717215e0874b", "BaoLong.To@yahoo.com", "Phan Hải Sơn", "BAOLONG.TO@YAHOO.COM", null, "AQAAAAIAAYagAAAAEHOwYpNY8ZALCwikG73kNYWYflYnQB1/ZQtEzmX9O2wyV0blqHavsOo6QcZ79kXGFw==", "0259 2902 7769", "0c717233-9681-4508-8c9b-3aec87fd9d88", "BaoLong.To@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "2144327e-a8fa-4c99-b2d7-be34e7726887", "QuangThai_Pham@hotmail.com", "Trương Mộng Liễu", "QUANGTHAI_PHAM@HOTMAIL.COM", null, "AQAAAAIAAYagAAAAEB1G6tH9sZz5vl2DfoAIF18bIUNJwhJUPAlOt/AnKDGvjst2h3N6cGFuGbrIawgnyw==", "029 5365 4703", "9d641bab-8c35-42b5-a45a-225c0bb00bd4", "QuangThai_Pham@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "26dfcdb4-6997-433d-9ac4-e14f4fd39cc3", "NghiDung_Hoang11@hotmail.com", "Trương Hữu Tường", "NGHIDUNG_HOANG11@HOTMAIL.COM", null, "AQAAAAIAAYagAAAAEIB8rYmKqj8nhDvv7Mf/UQQggUzul+jxXjJSoXvbQYSWswbIDrXyWA793s5Kog782Q==", "0287 9221 3153", "7e66ef7c-9c49-4ce7-a095-897edfe9b779", "NghiDung_Hoang11@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "ade69bd6-e6b7-488b-ba62-66b125a54085", "TuanDung.Doan@hotmail.com", "Hoàng Hồng Phát", "TUANDUNG.DOAN@HOTMAIL.COM", null, "AQAAAAIAAYagAAAAEJsaujgLw9pbeCAE/cuf0CL3NJoogXu1jiZtGVyL/wH1kGT3R6Mbc8lDLUu6G5cc0g==", "029 0544 0023", "cf99443f-ae3d-4221-aeb5-a60b9d15ee58", "TuanDung.Doan@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "7b698e47-2c7d-4767-a386-773f51b74e06", "MyKieu60@gmail.com", "Lý Thiện Lương", "MYKIEU60@GMAIL.COM", null, "AQAAAAIAAYagAAAAEP46WuMeKD5Uk0s/vV5U9CMcgwwmHFtqnwo4sEetcc3S6zjp+4el7YU164gukaPAMQ==", "020 3659 2548", "689d1cbf-282e-43dd-9be2-48e34ae70fb2", "MyKieu60@gmail.com" });
        }
    }
}
