using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyApp.Infrastucture.Migrations
{
    /// <inheritdoc />
    public partial class UpdateData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "70f44db2-8bb3-4c5f-b262-fce5ddf2ddb4", "QuangNinh38@hotmail.com", "Phan Kim Đan", "QUANGNINH38@HOTMAIL.COM", "AQAAAAIAAYagAAAAENP4ttfhWG05v+KoGBNdoDRtgWC6CDuwLxjBJcRed0R7dPBYePnb1zSt7TuvZXRX5g==", "026 9165 3839", "5fd44595-1e1a-40f6-8b4c-cf0eb04f3614", "QuangNinh38@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "e8874f86-99ad-4bf2-9140-f61efaa96cd0", "LanThuong.Ngo57@gmail.com", "Đinh Hải Ngân", "LANTHUONG.NGO57@GMAIL.COM", "AQAAAAIAAYagAAAAELHtGQM1NGRRsmKGAESuxbuui8iQasn7FeHEqj6ANDW5NunwciJT/fnRTv0kF4984g==", "0219 0280 6460", "f3b29d1d-6474-4ba2-b3e6-362c1aded004", "LanThuong.Ngo57@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "614332b6-daf6-42d1-9914-2bf5058566aa", "MinhPhuong.Dang0@hotmail.com", "Vương Mộng Quỳnh", "MINHPHUONG.DANG0@HOTMAIL.COM", "AQAAAAIAAYagAAAAEG7EL6HlM+WobQ8H8uzZy6AIFZqCwaILJi/qIFxwuM7H6NX1FBDoaUcsiA6u5vvfWA==", "028 9207 7539", "d58f1b31-3ee8-4a62-b93b-a9f7f0a39e6a", "MinhPhuong.Dang0@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "6accfb63-34d7-48fb-acde-a0d47307b273", "LeQuyen_Hoang3@yahoo.com", "Nguyễn Trọng Nghĩa", "LEQUYEN_HOANG3@YAHOO.COM", "AQAAAAIAAYagAAAAEPeTNkAHE6xlMZfJfMnbOBsa5aREckMM5kGONBq63L6LD76SR5dQjqFaDYHGG2NXGA==", "0235 3497 1579", "51bea0aa-cc7e-4535-b34c-898c58955d7f", "LeQuyen_Hoang3@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "0cc812d6-8be8-44d9-84e5-3b5229cd8891", "HoaLac.Phan@hotmail.com", "Lý Diệu Ngà", "HOALAC.PHAN@HOTMAIL.COM", "AQAAAAIAAYagAAAAEFF2Uvtlfb3JHByz8W4tguLBvyGWh3Im7o8rTYlAQKdLMrtlNAYtLS005kQPqqRnjw==", "0244 1253 5286", "318cf5fd-2a44-4ad0-9677-1f9146e3d52d", "HoaLac.Phan@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "ebbc948b-e285-4c82-9a33-717215e0874b", "BaoLong.To@yahoo.com", "Phan Hải Sơn", "BAOLONG.TO@YAHOO.COM", "AQAAAAIAAYagAAAAEHOwYpNY8ZALCwikG73kNYWYflYnQB1/ZQtEzmX9O2wyV0blqHavsOo6QcZ79kXGFw==", "0259 2902 7769", "0c717233-9681-4508-8c9b-3aec87fd9d88", "BaoLong.To@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "2144327e-a8fa-4c99-b2d7-be34e7726887", "QuangThai_Pham@hotmail.com", "Trương Mộng Liễu", "QUANGTHAI_PHAM@HOTMAIL.COM", "AQAAAAIAAYagAAAAEB1G6tH9sZz5vl2DfoAIF18bIUNJwhJUPAlOt/AnKDGvjst2h3N6cGFuGbrIawgnyw==", "029 5365 4703", "9d641bab-8c35-42b5-a45a-225c0bb00bd4", "QuangThai_Pham@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "26dfcdb4-6997-433d-9ac4-e14f4fd39cc3", "NghiDung_Hoang11@hotmail.com", "Trương Hữu Tường", "NGHIDUNG_HOANG11@HOTMAIL.COM", "AQAAAAIAAYagAAAAEIB8rYmKqj8nhDvv7Mf/UQQggUzul+jxXjJSoXvbQYSWswbIDrXyWA793s5Kog782Q==", "0287 9221 3153", "7e66ef7c-9c49-4ce7-a095-897edfe9b779", "NghiDung_Hoang11@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "ade69bd6-e6b7-488b-ba62-66b125a54085", "TuanDung.Doan@hotmail.com", "Hoàng Hồng Phát", "TUANDUNG.DOAN@HOTMAIL.COM", "AQAAAAIAAYagAAAAEJsaujgLw9pbeCAE/cuf0CL3NJoogXu1jiZtGVyL/wH1kGT3R6Mbc8lDLUu6G5cc0g==", "029 0544 0023", "cf99443f-ae3d-4221-aeb5-a60b9d15ee58", "TuanDung.Doan@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "7b698e47-2c7d-4767-a386-773f51b74e06", "MyKieu60@gmail.com", "Lý Thiện Lương", "MYKIEU60@GMAIL.COM", "AQAAAAIAAYagAAAAEP46WuMeKD5Uk0s/vV5U9CMcgwwmHFtqnwo4sEetcc3S6zjp+4el7YU164gukaPAMQ==", "020 3659 2548", "689d1cbf-282e-43dd-9be2-48e34ae70fb2", "MyKieu60@gmail.com" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "EndUser",
                keyColumn: "Id",
                keyValue: 6,
                column: "Adress",
                value: "0548 Elaina Common");

            migrationBuilder.UpdateData(
                table: "EndUser",
                keyColumn: "Id",
                keyValue: 7,
                column: "Adress",
                value: "83495 Hayes Circles");

            migrationBuilder.UpdateData(
                table: "EndUser",
                keyColumn: "Id",
                keyValue: 8,
                column: "Adress",
                value: "17210 Purdy Courts");

            migrationBuilder.UpdateData(
                table: "EndUser",
                keyColumn: "Id",
                keyValue: 9,
                column: "Adress",
                value: "7002 Ondricka Points");

            migrationBuilder.UpdateData(
                table: "EndUser",
                keyColumn: "Id",
                keyValue: 10,
                column: "Adress",
                value: "25606 Cartwright Springs");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "069cf0cd-d219-45d8-a15b-56f4c3165b61", "AQAAAAIAAYagAAAAEC/fPYAxhFI/8dlV7KEUFjCv0NwAdOnwCjU958nY2cSzK4lIBzJdYf/mWuWpbDsKHA==", "9d0d5243-9290-4ffa-89d1-17fbf766fd44" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "062f7399-47e4-4990-8afd-090da5c41910", "KimQuyen_Truong53@gmail.com", "Trần Niệm Nhiên", "KIMQUYEN_TRUONG53@GMAIL.COM", "AQAAAAIAAYagAAAAELOC1lE1R8m1lS+IOLHyB5wHoX6pWSj+lkqr1YyIjekOHvapZAZtMM+Q4XUt3xIT2g==", "021 6966 3700", "944eed4e-457d-4633-abea-0e83910374bc", "KimQuyen_Truong53@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "24be8df8-1bd9-4d66-8a64-661740e5f62a", "TienGiang.Hoang51@hotmail.com", "Lê Vân Thúy", "TIENGIANG.HOANG51@HOTMAIL.COM", "AQAAAAIAAYagAAAAEJYIcGaauI4EAUSGL/1k/gMd/G/uBG/nxdbfTaEE/fh+Lqw6ys33t0Mbw0GjiJGgmA==", "024 5674 5764", "119453cd-784f-4e4b-a827-66b6a962f950", "TienGiang.Hoang51@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "02abaad3-8435-41a7-822c-85e3ddf7f971", "QuocHung_Nguyen73@yahoo.com", "Trương Hữu Phước", "QUOCHUNG_NGUYEN73@YAHOO.COM", "AQAAAAIAAYagAAAAEDdDOriPBsF34N+qyfCxJVRRR+eLxOcVIFr61UZRD78gBLYY/aeuST+P7u9vcdaH0g==", "020 6726 7725", "059fe5d5-03dc-4027-a0bd-3bc218432ba1", "QuocHung_Nguyen73@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "714700b8-4b52-4d31-93df-d14fa0abedbc", "ThienLuong.Doan65@yahoo.com", "Đặng Hải Hà", "THIENLUONG.DOAN65@YAHOO.COM", "AQAAAAIAAYagAAAAELsBlvTuhsIyqeJDonfKwA8aGE37e5WKZPq9WXNOAixNRW8tQcHw62PJLzSrZ0HO5w==", "0222 5732 9881", "8cdccf76-1146-40bf-aeb1-bb9339fb369f", "ThienLuong.Doan65@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "cb634c9d-5442-4990-b51d-7b2802e0eb05", "DinhSang.Lam35@hotmail.com", "Lý Thành Lợi", "DINHSANG.LAM35@HOTMAIL.COM", "AQAAAAIAAYagAAAAEGBKooPlhfI9KlG3v6YNMu/mCC1LhMca3ExAlWnB5M/XHnnyPcWaahtfOCT7cUYhqQ==", "023 7507 6667", "b1a0c40e-2b50-4587-85eb-f0827d7530cc", "DinhSang.Lam35@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "9e063d76-bf4b-41fa-928b-3915690c1685", "ChiCong.Ho91@gmail.com", "Vương Thái Tân", "CHICONG.HO91@GMAIL.COM", "AQAAAAIAAYagAAAAEIIj+Syb/js1t5Ew3Kc45SnTNfRKoK29W/2lrpxWjn4W1r/YpJMq+Rx152XVzEBnlA==", "0297 1011 5139", "772e553a-f29a-4498-956a-ba0a08a5420e", "ChiCong.Ho91@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "51bb973d-b69d-49ca-954c-3958f2c2aa40", "BichTrang68@yahoo.com", "Hồ Trường Long", "BICHTRANG68@YAHOO.COM", "AQAAAAIAAYagAAAAEACi1eSglPJGlU7gm/HaauGU0cX7G46KuNbjDiWT0TQdYoFfDEcV7CycsaqaICdK4A==", "022 7381 9209", "09dc2e97-693a-459d-b49f-e8d798b430fe", "BichTrang68@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "5f6d38ec-c6ac-4757-8a42-434fa2764d9c", "TheLam.Do19@gmail.com", "Đoàn Ngọc Cầm", "THELAM.DO19@GMAIL.COM", "AQAAAAIAAYagAAAAEH5dvx35v5eQW0CQ/L96wRDOnPYcbRIIpfFQhT/ennnktbF1oyjPYSe2ZDRPskNGNQ==", "028 1231 8202", "575adf29-764a-4bc8-9436-7c414ccc67a0", "TheLam.Do19@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "f105a81a-59bf-478e-bbb0-3743caab77a1", "KhacVu.Dang@gmail.com", "Tô Thăng Long", "KHACVU.DANG@GMAIL.COM", "AQAAAAIAAYagAAAAEGaDYm8ZzxXLBXCuOYoTQTrMCFzvL1WT/b7+e+NEmK3/mBlKvDf1ACsb8wE8Bm2SUA==", "0268 9399 7354", "76e24841-3968-4f40-8fe7-b0161a2d5c79", "KhacVu.Dang@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "8f1ed94a-42bb-4374-b95f-b0bd8ebe8e29", "GiaNhi.Bui39@hotmail.com", "Bùi Bạch Trà", "GIANHI.BUI39@HOTMAIL.COM", "AQAAAAIAAYagAAAAEIVgWyYyMXWEy5Y4r9co/jmpmmlw7vJagRpyRPLt66NkjTHNsZag9mOXbjkpAhLneA==", "0204 7104 3652", "54599efe-6244-457d-a387-ec526ecb3ea1", "GiaNhi.Bui39@hotmail.com" });
        }
    }
}
