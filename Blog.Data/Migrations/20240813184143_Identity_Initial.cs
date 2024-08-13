using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Blog.Data.Migrations
{
    /// <inheritdoc />
    public partial class Identity_Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("045223ad-c51b-484d-b5fb-658185ff1229"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("69910679-3c89-4fba-899d-1328ef70d89c"));

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("1202ea09-daea-447f-a519-fc9fbfbc3245"), new Guid("dfb950ad-e959-463f-ab3f-84658d5d4695"), "Asp.net core lorem ipsum dolor solet", "Admin Test", new DateTime(2024, 8, 13, 18, 41, 40, 645, DateTimeKind.Utc).AddTicks(7832), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3224267d-94e7-4501-a7f3-0d376c3060a7"), false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Asp.Net Core", 15 },
                    { new Guid("f5727d75-924b-4637-8a91-159ac1baea15"), new Guid("5d54ba1a-6f8a-410d-9a92-8800feea5415"), "visual studio lorem ipsum dolor solet", "Admin Test", new DateTime(2024, 8, 13, 18, 41, 40, 645, DateTimeKind.Utc).AddTicks(7853), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4a34a0a9-367c-4a27-918d-4782c48a6384"), false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Visual Studio", 15 }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5d54ba1a-6f8a-410d-9a92-8800feea5415"),
                column: "CreatedDate",
                value: new DateTime(2024, 8, 13, 18, 41, 40, 645, DateTimeKind.Utc).AddTicks(9684));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("dfb950ad-e959-463f-ab3f-84658d5d4695"),
                column: "CreatedDate",
                value: new DateTime(2024, 8, 13, 18, 41, 40, 645, DateTimeKind.Utc).AddTicks(9671));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("3224267d-94e7-4501-a7f3-0d376c3060a7"),
                column: "CreatedDate",
                value: new DateTime(2024, 8, 13, 18, 41, 40, 646, DateTimeKind.Utc).AddTicks(1475));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("4a34a0a9-367c-4a27-918d-4782c48a6384"),
                column: "CreatedDate",
                value: new DateTime(2024, 8, 13, 18, 41, 40, 646, DateTimeKind.Utc).AddTicks(1490));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("1202ea09-daea-447f-a519-fc9fbfbc3245"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("f5727d75-924b-4637-8a91-159ac1baea15"));

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("045223ad-c51b-484d-b5fb-658185ff1229"), new Guid("dfb950ad-e959-463f-ab3f-84658d5d4695"), "Asp.net core lorem ipsum dolor solet", "Admin Test", new DateTime(2024, 8, 6, 19, 13, 18, 295, DateTimeKind.Utc).AddTicks(7422), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3224267d-94e7-4501-a7f3-0d376c3060a7"), false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Asp.Net Core", 15 },
                    { new Guid("69910679-3c89-4fba-899d-1328ef70d89c"), new Guid("5d54ba1a-6f8a-410d-9a92-8800feea5415"), "visual studio lorem ipsum dolor solet", "Admin Test", new DateTime(2024, 8, 6, 19, 13, 18, 295, DateTimeKind.Utc).AddTicks(7443), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4a34a0a9-367c-4a27-918d-4782c48a6384"), false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Visual Studio", 15 }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5d54ba1a-6f8a-410d-9a92-8800feea5415"),
                column: "CreatedDate",
                value: new DateTime(2024, 8, 6, 19, 13, 18, 295, DateTimeKind.Utc).AddTicks(9403));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("dfb950ad-e959-463f-ab3f-84658d5d4695"),
                column: "CreatedDate",
                value: new DateTime(2024, 8, 6, 19, 13, 18, 295, DateTimeKind.Utc).AddTicks(9390));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("3224267d-94e7-4501-a7f3-0d376c3060a7"),
                column: "CreatedDate",
                value: new DateTime(2024, 8, 6, 19, 13, 18, 296, DateTimeKind.Utc).AddTicks(952));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("4a34a0a9-367c-4a27-918d-4782c48a6384"),
                column: "CreatedDate",
                value: new DateTime(2024, 8, 6, 19, 13, 18, 296, DateTimeKind.Utc).AddTicks(967));
        }
    }
}
