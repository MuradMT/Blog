using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Blog.Data.Migrations
{
    /// <inheritdoc />
    public partial class Modified : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("184e54ac-75ac-4a2c-9c9c-bc6a9513a117"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("be57440b-76ec-4ac6-8bad-f3a68018a7c4"));

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "UserId", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("843210c6-7303-42a8-af73-7c7db06be15d"), new Guid("5d54ba1a-6f8a-410d-9a92-8800feea5415"), "visual studio lorem ipsum dolor solet", "Admin Test", new DateTime(2024, 8, 30, 18, 2, 7, 854, DateTimeKind.Utc).AddTicks(1489), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4a34a0a9-367c-4a27-918d-4782c48a6384"), false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Visual Studio", new Guid("e9ede6b0-9d0d-48b1-a4a0-05fd5130e067"), 15 },
                    { new Guid("c5ca2e39-55cf-4d42-b223-8cca47bdce08"), new Guid("dfb950ad-e959-463f-ab3f-84658d5d4695"), "Asp.net core lorem ipsum dolor solet", "Admin Test", new DateTime(2024, 8, 30, 18, 2, 7, 854, DateTimeKind.Utc).AddTicks(1482), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3224267d-94e7-4501-a7f3-0d376c3060a7"), false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Asp.Net Core", new Guid("52d21bca-c91c-41e6-bb26-f2e5c33e2a46"), 15 }
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("2150ecc7-ea01-4d39-bce2-3f4e68cb2692"),
                column: "ConcurrencyStamp",
                value: "cb050682-553c-452f-86b7-6c4eaf565358");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("9dc8b41e-7de2-48be-9915-f71d0a8bc06e"),
                column: "ConcurrencyStamp",
                value: "3951a615-6e90-43b1-b3c7-a8d7e3d49f32");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("f2917c68-b590-4ddc-bdf3-510936428c1e"),
                column: "ConcurrencyStamp",
                value: "14708d74-0c1d-48e0-8477-5953bb160b0d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("52d21bca-c91c-41e6-bb26-f2e5c33e2a46"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2a45ac6b-5c1e-4931-8c77-8fc1a03e7bd5", "AQAAAAIAAYagAAAAEG1K5J0HYROwsmFpw9mjzADNCzajjNFESMhqSe7YHTxQBc3hBBM83EP44io93DJ1xw==", "985ee747-f176-496e-9c04-92a9810043be" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("bb668e51-6f7e-4d1f-9e9f-0b842761c120"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "eccf2b42-b1e1-41a7-8913-9280e033b9fb", "AQAAAAIAAYagAAAAECVnIzWDU5lRk3Vld8P4xtyGRwff0sVpzrs+tfXXOoFWPTJ3g8cxxATAhU00w1AQfg==", "fa294696-462e-48c4-b855-25bba320822f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e9ede6b0-9d0d-48b1-a4a0-05fd5130e067"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d76c867e-4b7c-4458-9d4a-29ccc6cbdeed", "AQAAAAIAAYagAAAAEJr5LI/ZVMwtRPzlPnUfZj4EQu0VWpIHyrM5Y+wAAs3GbMkTFM5EkAif1F/bJNZnCg==", "d9eb0091-70e8-4676-a7d8-489cf67d7125" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5d54ba1a-6f8a-410d-9a92-8800feea5415"),
                column: "CreatedDate",
                value: new DateTime(2024, 8, 30, 18, 2, 7, 854, DateTimeKind.Utc).AddTicks(2679));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("dfb950ad-e959-463f-ab3f-84658d5d4695"),
                column: "CreatedDate",
                value: new DateTime(2024, 8, 30, 18, 2, 7, 854, DateTimeKind.Utc).AddTicks(2664));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("3224267d-94e7-4501-a7f3-0d376c3060a7"),
                column: "CreatedDate",
                value: new DateTime(2024, 8, 30, 18, 2, 7, 854, DateTimeKind.Utc).AddTicks(3694));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("4a34a0a9-367c-4a27-918d-4782c48a6384"),
                column: "CreatedDate",
                value: new DateTime(2024, 8, 30, 18, 2, 7, 854, DateTimeKind.Utc).AddTicks(3697));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("843210c6-7303-42a8-af73-7c7db06be15d"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("c5ca2e39-55cf-4d42-b223-8cca47bdce08"));

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "UserId", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("184e54ac-75ac-4a2c-9c9c-bc6a9513a117"), new Guid("dfb950ad-e959-463f-ab3f-84658d5d4695"), "Asp.net core lorem ipsum dolor solet", "Admin Test", new DateTime(2024, 8, 20, 13, 32, 19, 157, DateTimeKind.Utc).AddTicks(8118), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3224267d-94e7-4501-a7f3-0d376c3060a7"), false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Asp.Net Core", new Guid("52d21bca-c91c-41e6-bb26-f2e5c33e2a46"), 15 },
                    { new Guid("be57440b-76ec-4ac6-8bad-f3a68018a7c4"), new Guid("5d54ba1a-6f8a-410d-9a92-8800feea5415"), "visual studio lorem ipsum dolor solet", "Admin Test", new DateTime(2024, 8, 20, 13, 32, 19, 157, DateTimeKind.Utc).AddTicks(8124), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4a34a0a9-367c-4a27-918d-4782c48a6384"), false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Visual Studio", new Guid("e9ede6b0-9d0d-48b1-a4a0-05fd5130e067"), 15 }
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("2150ecc7-ea01-4d39-bce2-3f4e68cb2692"),
                column: "ConcurrencyStamp",
                value: "9a296164-5ea8-4976-94b8-1a72954e699f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("9dc8b41e-7de2-48be-9915-f71d0a8bc06e"),
                column: "ConcurrencyStamp",
                value: "d2034491-378d-4d42-bc6f-4465af996d45");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("f2917c68-b590-4ddc-bdf3-510936428c1e"),
                column: "ConcurrencyStamp",
                value: "db27e782-9d25-4997-9bf7-572c6f0c7cb2");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("52d21bca-c91c-41e6-bb26-f2e5c33e2a46"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "045233e9-9eb0-420b-955e-542957d767f3", "AQAAAAIAAYagAAAAEGjMbHPUfRi0i5WdPcauICCKsrcttFfBYOn+BLSGAmwkxyVV5DT92GLbeOunNqJHRw==", "db27a1a1-12e9-492c-a977-b8d5af87f287" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("bb668e51-6f7e-4d1f-9e9f-0b842761c120"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d189a906-6be1-4242-a6e1-dc76866136be", "AQAAAAIAAYagAAAAEK1gRGUvmPBjf3aBGfGoBNtpDW4zpRz0lKkjJwRiPWAvriD4dDrPG1PJHir7ZX9t6w==", "795f07f0-4242-4b73-ba13-324b59addb93" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e9ede6b0-9d0d-48b1-a4a0-05fd5130e067"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e58bc3b3-380c-48cd-94b5-a00b0499a049", "AQAAAAIAAYagAAAAEAIoFpjQLyzuw59fIlGQ8D52Y0xCuuYWRPRaSphL9hi91ERCkCfiHa87OIVrA58+VQ==", "34ed7a6e-8e68-49a0-a510-6586344157aa" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5d54ba1a-6f8a-410d-9a92-8800feea5415"),
                column: "CreatedDate",
                value: new DateTime(2024, 8, 20, 13, 32, 19, 157, DateTimeKind.Utc).AddTicks(9388));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("dfb950ad-e959-463f-ab3f-84658d5d4695"),
                column: "CreatedDate",
                value: new DateTime(2024, 8, 20, 13, 32, 19, 157, DateTimeKind.Utc).AddTicks(9374));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("3224267d-94e7-4501-a7f3-0d376c3060a7"),
                column: "CreatedDate",
                value: new DateTime(2024, 8, 20, 13, 32, 19, 158, DateTimeKind.Utc).AddTicks(427));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("4a34a0a9-367c-4a27-918d-4782c48a6384"),
                column: "CreatedDate",
                value: new DateTime(2024, 8, 20, 13, 32, 19, 158, DateTimeKind.Utc).AddTicks(430));
        }
    }
}
