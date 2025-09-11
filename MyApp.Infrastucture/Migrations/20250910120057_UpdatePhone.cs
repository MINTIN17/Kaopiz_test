using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyApp.Infrastucture.Migrations
{
    /// <inheritdoc />
    public partial class UpdatePhone : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PhoneNumber", "SecurityStamp" },
                values: new object[] { "da5807e6-a01f-4e4f-8643-541c3cedf5ef", "AQAAAAIAAYagAAAAELj03SemH0WSPzS01hKjmCLoiBjdvex0hk/tIyKhf56wBhQ4QgERKO11Xsm6+uhjfg==", "123456789", "30caf1ee-d7cb-4c3c-b883-66d60a515338" });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "EndUser",
                keyColumn: "Id",
                keyValue: 6,
                column: "Phone",
                value: "(897) 944-1478 x7331");

            migrationBuilder.UpdateData(
                table: "EndUser",
                keyColumn: "Id",
                keyValue: 7,
                column: "Phone",
                value: "(824) 519-7112 x18210");

            migrationBuilder.UpdateData(
                table: "EndUser",
                keyColumn: "Id",
                keyValue: 8,
                column: "Phone",
                value: "567.280.2973");

            migrationBuilder.UpdateData(
                table: "EndUser",
                keyColumn: "Id",
                keyValue: 9,
                column: "Phone",
                value: "1-338-740-7061 x54884");

            migrationBuilder.UpdateData(
                table: "EndUser",
                keyColumn: "Id",
                keyValue: 10,
                column: "Phone",
                value: "502.378.7909");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PhoneNumber", "SecurityStamp" },
                values: new object[] { "bbc55759-58b0-47a6-a3a5-8ccb42198b77", "AQAAAAIAAYagAAAAEKkefW0d2Q+u88zNnfwVk8XJK8r3UxstHuiKJZfWV7aEl30sveqPrG4IXdH0yGgegQ==", null, "7bac8f18-8c80-4cea-aed5-94101b858d50" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "7566b090-78d3-43e7-abdc-0b7c12c6bf83", "TichThien_Phan@gmail.com", "TICHTHIEN_PHAN@GMAIL.COM", "TUANDUC.LAM70", "AQAAAAIAAYagAAAAEIR7zKyNa9wW9ePe93q9Nwgbh6/T6KR8GeAPUH7SbA5L93eAa45m33/JCqtwXw2N+w==", null, "5cd89b95-5a0a-4bd2-a5e7-6a90d25ee719", "TuanDuc.Lam70" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "ea8b6310-5c1c-440b-8840-39e7576b321f", "TuongAnh_Tang@yahoo.com", "TUONGANH_TANG@YAHOO.COM", "MYTRANG38", "AQAAAAIAAYagAAAAEI9x9kc2dJi+4Enuku7Wl2Yi0LxqDRDkayJ5e7EbbuY6n6EcNxE/8KJya1aiO6ugIg==", null, "727ae5d8-30b8-4c36-9993-718f93434f37", "MyTrang38" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "5b108a5d-be8e-48d2-ad13-ddc19cfc1046", "XuanNhien74@gmail.com", "XUANNHIEN74@GMAIL.COM", "BAOSON_LE", "AQAAAAIAAYagAAAAEGBLKglSMySaZVH+GVVXJNb+U4tc7br+12fWLAECCsANstVse4YjB51BBZ9Mh578mA==", null, "cf352a96-d961-4c92-8ab9-14fc94a9e90a", "BaoSon_Le" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "c1f9dbff-512e-43dc-8b8c-f7ae71a676d7", "MaiLinh74@yahoo.com", "MAILINH74@YAHOO.COM", "BICHLIEN23", "AQAAAAIAAYagAAAAELwTqcFsHsvWQY1uR36irSVQi9uBDAi//s6skvpQi83MRlYHjgWxXbq5T6asI+t3lg==", null, "ca6b6420-219e-4496-83e4-514e3bd53678", "BichLien23" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "393d58aa-2ff3-463f-abd5-7667580895ed", "TrangNha_Do@yahoo.com", "TRANGNHA_DO@YAHOO.COM", "KHIETLINH87", "AQAAAAIAAYagAAAAEAxhg/LAeO7KInaMGSNkllt4fYpl9QiicnlshD53oOKWO0kjXy1ioH7Cbw+lsRS+tg==", null, "3c304075-2c7c-4793-8c22-16954a83549f", "KhietLinh87" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "533f9dc0-5783-48f7-a255-2dda1a7b7403", "ThuHa.Lam55@hotmail.com", "THUHA.LAM55@HOTMAIL.COM", "NHATNAM.TO", "AQAAAAIAAYagAAAAEI5Oy+yqH/go0wALBfMCQY9hROlIHQa6A5Cstd7SZ4rPD5VoXCCbwUYs83w2Tagbrw==", null, "ced8b322-7843-4473-a843-8d54b34c4917", "NhatNam.To" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "d97a7139-5c24-4a6d-bfec-cba5d4924a0d", "HuyenThu_Vuong81@hotmail.com", "HUYENTHU_VUONG81@HOTMAIL.COM", "DUYTAM_NGUYEN", "AQAAAAIAAYagAAAAEG64/k33Oja0OGN2Of/ag8jzOfEtljlGpGQTcb7jztUijSgXQ1/5pmllVhKK7T4G6A==", null, "4d3bb072-f04c-41ed-9d45-131f2d8294eb", "DuyTam_Nguyen" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "ffdcec70-9c28-4f08-9383-ac9375d7d07e", "DiemLoc42@gmail.com", "DIEMLOC42@GMAIL.COM", "LETHU51", "AQAAAAIAAYagAAAAEOpXrvJZXLeS3TFeWx1UZqzqIJkdMXLmffS4z/3hUf6KM6+AJEkA+jxEhVrjurLJMw==", null, "698e6d7f-d9fe-445d-a7ab-90214465579b", "LeThu51" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "b99667e4-9a82-46a3-adc5-f1f7e25f4338", "ThuyVan70@hotmail.com", "THUYVAN70@HOTMAIL.COM", "HANHNHON11", "AQAAAAIAAYagAAAAEKamW2A8OZloe5pNKzwb5w5wEb7sIKG0zWWBrqygJQH8JdwoQyehJX/0BnGbM7kLXw==", null, "6a6c664d-3325-4b80-98b3-ff082be3837c", "HanhNhon11" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "3070e4da-8367-4eb2-9ec1-6173e4c1e244", "UyenPhuong54@hotmail.com", "UYENPHUONG54@HOTMAIL.COM", "HOAIBAC.HA69", "AQAAAAIAAYagAAAAEDHn/QLWeIhe2UqnBuxZUQZGXP/qk1FEXkMEeNDOCMTUK8T5WxUc6NEYqgvDDTP3og==", null, "9bbed01b-61c5-4c77-b0df-ca6d184e16cf", "HoaiBac.Ha69" });
        }
    }
}
