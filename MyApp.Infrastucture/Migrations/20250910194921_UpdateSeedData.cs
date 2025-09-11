using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyApp.Infrastucture.Migrations
{
    /// <inheritdoc />
    public partial class UpdateSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Phone",
                table: "EndUser",
                newName: "Adress");

            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "Users",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256);

            migrationBuilder.AddColumn<string>(
                name: "FullName",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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
                columns: new[] { "ConcurrencyStamp", "FullName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "069cf0cd-d219-45d8-a15b-56f4c3165b61", "Admin", "AQAAAAIAAYagAAAAEC/fPYAxhFI/8dlV7KEUFjCv0NwAdOnwCjU958nY2cSzK4lIBzJdYf/mWuWpbDsKHA==", "9d0d5243-9290-4ffa-89d1-17fbf766fd44" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "062f7399-47e4-4990-8afd-090da5c41910", "KimQuyen_Truong53@gmail.com", "Trần Niệm Nhiên", "KIMQUYEN_TRUONG53@GMAIL.COM", null, "AQAAAAIAAYagAAAAELOC1lE1R8m1lS+IOLHyB5wHoX6pWSj+lkqr1YyIjekOHvapZAZtMM+Q4XUt3xIT2g==", "021 6966 3700", "944eed4e-457d-4633-abea-0e83910374bc", "KimQuyen_Truong53@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "24be8df8-1bd9-4d66-8a64-661740e5f62a", "TienGiang.Hoang51@hotmail.com", "Lê Vân Thúy", "TIENGIANG.HOANG51@HOTMAIL.COM", null, "AQAAAAIAAYagAAAAEJYIcGaauI4EAUSGL/1k/gMd/G/uBG/nxdbfTaEE/fh+Lqw6ys33t0Mbw0GjiJGgmA==", "024 5674 5764", "119453cd-784f-4e4b-a827-66b6a962f950", "TienGiang.Hoang51@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "02abaad3-8435-41a7-822c-85e3ddf7f971", "QuocHung_Nguyen73@yahoo.com", "Trương Hữu Phước", "QUOCHUNG_NGUYEN73@YAHOO.COM", null, "AQAAAAIAAYagAAAAEDdDOriPBsF34N+qyfCxJVRRR+eLxOcVIFr61UZRD78gBLYY/aeuST+P7u9vcdaH0g==", "020 6726 7725", "059fe5d5-03dc-4027-a0bd-3bc218432ba1", "QuocHung_Nguyen73@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "714700b8-4b52-4d31-93df-d14fa0abedbc", "ThienLuong.Doan65@yahoo.com", "Đặng Hải Hà", "THIENLUONG.DOAN65@YAHOO.COM", null, "AQAAAAIAAYagAAAAELsBlvTuhsIyqeJDonfKwA8aGE37e5WKZPq9WXNOAixNRW8tQcHw62PJLzSrZ0HO5w==", "0222 5732 9881", "8cdccf76-1146-40bf-aeb1-bb9339fb369f", "ThienLuong.Doan65@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "cb634c9d-5442-4990-b51d-7b2802e0eb05", "DinhSang.Lam35@hotmail.com", "Lý Thành Lợi", "DINHSANG.LAM35@HOTMAIL.COM", null, "AQAAAAIAAYagAAAAEGBKooPlhfI9KlG3v6YNMu/mCC1LhMca3ExAlWnB5M/XHnnyPcWaahtfOCT7cUYhqQ==", "023 7507 6667", "b1a0c40e-2b50-4587-85eb-f0827d7530cc", "DinhSang.Lam35@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "9e063d76-bf4b-41fa-928b-3915690c1685", "ChiCong.Ho91@gmail.com", "Vương Thái Tân", "CHICONG.HO91@GMAIL.COM", null, "AQAAAAIAAYagAAAAEIIj+Syb/js1t5Ew3Kc45SnTNfRKoK29W/2lrpxWjn4W1r/YpJMq+Rx152XVzEBnlA==", "0297 1011 5139", "772e553a-f29a-4498-956a-ba0a08a5420e", "ChiCong.Ho91@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "51bb973d-b69d-49ca-954c-3958f2c2aa40", "BichTrang68@yahoo.com", "Hồ Trường Long", "BICHTRANG68@YAHOO.COM", null, "AQAAAAIAAYagAAAAEACi1eSglPJGlU7gm/HaauGU0cX7G46KuNbjDiWT0TQdYoFfDEcV7CycsaqaICdK4A==", "022 7381 9209", "09dc2e97-693a-459d-b49f-e8d798b430fe", "BichTrang68@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "5f6d38ec-c6ac-4757-8a42-434fa2764d9c", "TheLam.Do19@gmail.com", "Đoàn Ngọc Cầm", "THELAM.DO19@GMAIL.COM", null, "AQAAAAIAAYagAAAAEH5dvx35v5eQW0CQ/L96wRDOnPYcbRIIpfFQhT/ennnktbF1oyjPYSe2ZDRPskNGNQ==", "028 1231 8202", "575adf29-764a-4bc8-9436-7c414ccc67a0", "TheLam.Do19@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "f105a81a-59bf-478e-bbb0-3743caab77a1", "KhacVu.Dang@gmail.com", "Tô Thăng Long", "KHACVU.DANG@GMAIL.COM", null, "AQAAAAIAAYagAAAAEGaDYm8ZzxXLBXCuOYoTQTrMCFzvL1WT/b7+e+NEmK3/mBlKvDf1ACsb8wE8Bm2SUA==", "0268 9399 7354", "76e24841-3968-4f40-8fe7-b0161a2d5c79", "KhacVu.Dang@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ConcurrencyStamp", "Email", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "8f1ed94a-42bb-4374-b95f-b0bd8ebe8e29", "GiaNhi.Bui39@hotmail.com", "Bùi Bạch Trà", "GIANHI.BUI39@HOTMAIL.COM", null, "AQAAAAIAAYagAAAAEIVgWyYyMXWEy5Y4r9co/jmpmmlw7vJagRpyRPLt66NkjTHNsZag9mOXbjkpAhLneA==", "0204 7104 3652", "54599efe-6244-457d-a387-ec526ecb3ea1", "GiaNhi.Bui39@hotmail.com" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FullName",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "Adress",
                table: "EndUser",
                newName: "Phone");

            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "Users",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "EndUser",
                keyColumn: "Id",
                keyValue: 6,
                column: "Phone",
                value: "(861) 921-1194 x25660");

            migrationBuilder.UpdateData(
                table: "EndUser",
                keyColumn: "Id",
                keyValue: 7,
                column: "Phone",
                value: "719-774-5208 x610");

            migrationBuilder.UpdateData(
                table: "EndUser",
                keyColumn: "Id",
                keyValue: 8,
                column: "Phone",
                value: "987-289-0858 x08331");

            migrationBuilder.UpdateData(
                table: "EndUser",
                keyColumn: "Id",
                keyValue: 9,
                column: "Phone",
                value: "586.927.1724");

            migrationBuilder.UpdateData(
                table: "EndUser",
                keyColumn: "Id",
                keyValue: 10,
                column: "Phone",
                value: "339.573.9365 x8754");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "da5807e6-a01f-4e4f-8643-541c3cedf5ef", "AQAAAAIAAYagAAAAELj03SemH0WSPzS01hKjmCLoiBjdvex0hk/tIyKhf56wBhQ4QgERKO11Xsm6+uhjfg==", "30caf1ee-d7cb-4c3c-b883-66d60a515338" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "a7d07c50-4179-4b1a-9154-682acb5ddf11", "ThuyDu.Dao@hotmail.com", "THUYDU.DAO@HOTMAIL.COM", "KHACVU.NGO18", "AQAAAAIAAYagAAAAEPDFSw6OyMxdO1hM1IWNRyrnzEmQYaVzMdvoyYoUOunQaIN0ndMcdmy0Xs+xINX79Q==", "020 6293 4489", "acdafdc9-1ab3-4350-97b5-8bbbdb5c41a7", "KhacVu.Ngo18" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "97ac3290-cf43-4152-8a6f-ddff9bbd4658", "NguyetCam69@gmail.com", "NGUYETCAM69@GMAIL.COM", "PHINHAN_TANG22", "AQAAAAIAAYagAAAAENTvAk09e3k0TTS8La0l/KdthZDQN2lakPel5fCq/OLSODP1ZZN62NnZDd0iGccCwg==", "022 8249 4388", "e94ce5b0-faf8-4d0f-929a-d8eb65a9561b", "PhiNhan_Tang22" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "678fe8a1-13bc-4daa-8e0c-2a30de70d6e2", "DieuHuyen.Dao24@gmail.com", "DIEUHUYEN.DAO24@GMAIL.COM", "HOANGVIET.TRUONG97", "AQAAAAIAAYagAAAAEA7OgGE1fHnjyXU2I6KGNoow3G8Z3HVCXPsbBKw/PF0diGUWfUc4X2Plsc4bArp18Q==", "0215 9604 1945", "4759e2a2-db35-4eb4-b845-6759c40efdd3", "HoangViet.Truong97" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "9163d07c-b243-49f3-98b8-5ade4df27907", "BaoThuy.Ha@yahoo.com", "BAOTHUY.HA@YAHOO.COM", "THANHY_TANG66", "AQAAAAIAAYagAAAAEKP1vdF8+bOxYiTz4dd6VbI+7wR4gclrCrbL1RB1nG3UKdaEaggh1ZyQp1mziAjCBg==", "023 1001 3582", "46b9ab23-064a-4290-802c-089d70f4fb87", "ThanhY_Tang66" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "c8d05af5-8b18-45b2-acdf-f002c45836a9", "DucMinh_Mai96@hotmail.com", "DUCMINH_MAI96@HOTMAIL.COM", "DONGDUONG.DANG", "AQAAAAIAAYagAAAAEHssh4Y31Ytrd6aM5ZwuehU+Ywz2VyBgqG5vLrx++uDNe4jmpXQbry/FpXPHtenSOw==", "0218 8368 4328", "5aa8f662-722f-48ee-8d7f-2a0c16f1a167", "DongDuong.Dang" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "e1e6a33e-055e-4bbb-8a70-2ab323a4c434", "NgocAn65@gmail.com", "NGOCAN65@GMAIL.COM", "QUANGDUC.HO", "AQAAAAIAAYagAAAAEKnXoOWHW8JPv3zy29Imo98hgkfqDOFNvh/iKRBbfrWcKv/5Sq2ahF3dmYGX51Rgyw==", "022 8660 8694", "f6eb249f-aa87-4807-b98a-a225cd1526c8", "QuangDuc.Ho" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "7a3d3f43-2290-4f93-9a2c-49001db7ff44", "PhungViet.Le@hotmail.com", "PHUNGVIET.LE@HOTMAIL.COM", "NGUYENLOC76", "AQAAAAIAAYagAAAAEGXCRHjGjP18mHXtOH3uQax4nFGY3DpqGWfKZNp04aOKL3Ajilz9Qx46IuhW9boTnw==", "0264 4366 0342", "ec4a3a66-1fde-4d7a-ac6d-d69d640942ca", "NguyenLoc76" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "72eb2c37-efcb-4588-9e07-d52c5e7389fd", "NhaKhanh_Le59@yahoo.com", "NHAKHANH_LE59@YAHOO.COM", "TUYETHONG_VUONG", "AQAAAAIAAYagAAAAEC6sFHaGXpQPOoksKIBbVsEc1Ne5jFt59FymU0K3fktSAZAHsCY6onZw6HssGY0Www==", "029 1782 1177", "b9c04595-0f07-47b7-bed2-47d4673009a3", "TuyetHong_Vuong" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "94aa9b20-dc5a-4bfa-9553-e4fb76ebe06b", "ThanhNguyen_Tang94@yahoo.com", "THANHNGUYEN_TANG94@YAHOO.COM", "BACHVAN36", "AQAAAAIAAYagAAAAEMvU4V912CddEdjTabdri3WTXdvTSqAEgTmuJYpLc/ml+/NMznM5PFDZszQFPyArKw==", "028 5808 5080", "1b8406a7-017f-4502-90d7-145dbd4c869d", "BachVan36" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "43915f7d-0a19-43e3-9030-cb19e0576ad3", "MinhKhue_Do58@gmail.com", "MINHKHUE_DO58@GMAIL.COM", "NHATPHUONG36", "AQAAAAIAAYagAAAAELnQL4DqnRYK7sljnAMmU7qd5xAJRue5F3ULjD/xZNuR3OhgXbE7XiaZ4nCmEJJyvw==", "021 6413 8742", "361714d6-74e7-4ec0-8542-cc8547a8b1b9", "NhatPhuong36" });
        }
    }
}
