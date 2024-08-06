using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Blog.Data.Migrations
{
    /// <inheritdoc />
    public partial class Seeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("00538489-3796-4ee7-9803-0b878c93a97f"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("a81c33f6-2356-4605-a741-3a6cee97c619"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8ac8b2b9-5f21-47d8-81bf-35a76da8b4d9"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ea5991ee-a1da-4659-b0d7-664fed464121"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("44575e46-c0ee-4c4f-9d99-40efca1c9ed5"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("862d9a72-5bc1-4f4e-af4f-7c8cd85655e7"));

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsDeleted", "ModifiedBy", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { new Guid("5d54ba1a-6f8a-410d-9a92-8800feea5415"), "Admin Test", new DateTime(2024, 8, 6, 19, 13, 18, 295, DateTimeKind.Utc).AddTicks(9403), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Visual Studio" },
                    { new Guid("dfb950ad-e959-463f-ab3f-84658d5d4695"), "Admin Test", new DateTime(2024, 8, 6, 19, 13, 18, 295, DateTimeKind.Utc).AddTicks(9390), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Asp.Net Core" }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "FileName", "FileType", "IsDeleted", "ModifiedBy", "ModifiedDate" },
                values: new object[,]
                {
                    { new Guid("3224267d-94e7-4501-a7f3-0d376c3060a7"), "Admin Test", new DateTime(2024, 8, 6, 19, 13, 18, 296, DateTimeKind.Utc).AddTicks(952), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "images/testimage", "jpg", false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4a34a0a9-367c-4a27-918d-4782c48a6384"), "Admin Test", new DateTime(2024, 8, 6, 19, 13, 18, 296, DateTimeKind.Utc).AddTicks(967), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "images/vstest", "png", false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("045223ad-c51b-484d-b5fb-658185ff1229"), new Guid("dfb950ad-e959-463f-ab3f-84658d5d4695"), "Asp.net core lorem ipsum dolor solet", "Admin Test", new DateTime(2024, 8, 6, 19, 13, 18, 295, DateTimeKind.Utc).AddTicks(7422), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3224267d-94e7-4501-a7f3-0d376c3060a7"), false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Asp.Net Core", 15 },
                    { new Guid("69910679-3c89-4fba-899d-1328ef70d89c"), new Guid("5d54ba1a-6f8a-410d-9a92-8800feea5415"), "visual studio lorem ipsum dolor solet", "Admin Test", new DateTime(2024, 8, 6, 19, 13, 18, 295, DateTimeKind.Utc).AddTicks(7443), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4a34a0a9-367c-4a27-918d-4782c48a6384"), false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Visual Studio", 15 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("045223ad-c51b-484d-b5fb-658185ff1229"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("69910679-3c89-4fba-899d-1328ef70d89c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5d54ba1a-6f8a-410d-9a92-8800feea5415"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("dfb950ad-e959-463f-ab3f-84658d5d4695"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("3224267d-94e7-4501-a7f3-0d376c3060a7"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("4a34a0a9-367c-4a27-918d-4782c48a6384"));

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsDeleted", "ModifiedBy", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { new Guid("8ac8b2b9-5f21-47d8-81bf-35a76da8b4d9"), "Admin Test", new DateTime(2024, 8, 6, 19, 1, 21, 944, DateTimeKind.Utc).AddTicks(25), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Visual Studio" },
                    { new Guid("ea5991ee-a1da-4659-b0d7-664fed464121"), "Admin Test", new DateTime(2024, 8, 6, 19, 1, 21, 944, DateTimeKind.Utc).AddTicks(13), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Asp.Net Core" }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "FileName", "FileType", "IsDeleted", "ModifiedBy", "ModifiedDate" },
                values: new object[,]
                {
                    { new Guid("44575e46-c0ee-4c4f-9d99-40efca1c9ed5"), "Admin Test", new DateTime(2024, 8, 6, 19, 1, 21, 944, DateTimeKind.Utc).AddTicks(1588), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "images/vstest", "png", false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("862d9a72-5bc1-4f4e-af4f-7c8cd85655e7"), "Admin Test", new DateTime(2024, 8, 6, 19, 1, 21, 944, DateTimeKind.Utc).AddTicks(1574), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "images/testimage", "jpg", false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("00538489-3796-4ee7-9803-0b878c93a97f"), new Guid("ea5991ee-a1da-4659-b0d7-664fed464121"), "Asp.net core lorem ipsum dolor solet", "Admin Test", new DateTime(2024, 8, 6, 19, 1, 21, 943, DateTimeKind.Utc).AddTicks(8057), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("862d9a72-5bc1-4f4e-af4f-7c8cd85655e7"), false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Asp.Net Core", 15 },
                    { new Guid("a81c33f6-2356-4605-a741-3a6cee97c619"), new Guid("8ac8b2b9-5f21-47d8-81bf-35a76da8b4d9"), "visual studio lorem ipsum dolor solet", "Admin Test", new DateTime(2024, 8, 6, 19, 1, 21, 943, DateTimeKind.Utc).AddTicks(8079), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("44575e46-c0ee-4c4f-9d99-40efca1c9ed5"), false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Visual Studio", 15 }
                });
        }
    }
}
