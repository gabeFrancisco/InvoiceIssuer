using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace InvoiceIssuer.Repository.Migrations
{
    public partial class LengthFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("00c49b71-df78-42d6-93ad-4ccc28a30ea0"));

            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("08e889d6-fc38-4ba6-b3a9-78695bc38088"));

            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("566d75e0-4270-4ec6-9202-c0d2eebf9360"));

            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("d2e0c4f8-755a-4c15-ad3a-ba086ff9c156"));

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "Providers",
                maxLength: 500,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "char(500) CHARACTER SET utf8mb4",
                oldFixedLength: true,
                oldMaxLength: 500);

            migrationBuilder.InsertData(
                table: "CompanyTypes",
                columns: new[] { "Id", "CreatedAt", "Description", "Name", "TaxRate", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("00be59db-80f6-4a80-9c6f-f386b18eabd9"), new DateTime(2021, 8, 1, 1, 38, 59, 467, DateTimeKind.Utc).AddTicks(8505), "This type of company is free from tax applications", "Individual Business", 0.0m, null },
                    { new Guid("fc2bd035-7b17-4ae4-807b-fefe0a9f0bed"), new DateTime(2021, 8, 1, 1, 38, 59, 468, DateTimeKind.Utc).AddTicks(1773), "Small company that is beginning", "Small Company", 2.5m, null },
                    { new Guid("96d50c82-cb8b-4f79-a258-df1a350681dc"), new DateTime(2021, 8, 1, 1, 38, 59, 468, DateTimeKind.Utc).AddTicks(1844), "Mid-port company", "Medium Company", 4.5m, null },
                    { new Guid("c8dfd323-af60-4d66-9c68-4b8637171446"), new DateTime(2021, 8, 1, 1, 38, 59, 468, DateTimeKind.Utc).AddTicks(1877), "Large company with more branches", "Large Company", 7.5m, null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("00be59db-80f6-4a80-9c6f-f386b18eabd9"));

            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("96d50c82-cb8b-4f79-a258-df1a350681dc"));

            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("c8dfd323-af60-4d66-9c68-4b8637171446"));

            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("fc2bd035-7b17-4ae4-807b-fefe0a9f0bed"));

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "Providers",
                type: "char(500) CHARACTER SET utf8mb4",
                fixedLength: true,
                maxLength: 500,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 500);

            migrationBuilder.InsertData(
                table: "CompanyTypes",
                columns: new[] { "Id", "CreatedAt", "Description", "Name", "TaxRate", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("566d75e0-4270-4ec6-9202-c0d2eebf9360"), new DateTime(2021, 8, 1, 1, 37, 15, 674, DateTimeKind.Utc).AddTicks(3034), "This type of company is free from tax applications", "Individual Business", 0.0m, null },
                    { new Guid("d2e0c4f8-755a-4c15-ad3a-ba086ff9c156"), new DateTime(2021, 8, 1, 1, 37, 15, 674, DateTimeKind.Utc).AddTicks(6699), "Small company that is beginning", "Small Company", 2.5m, null },
                    { new Guid("00c49b71-df78-42d6-93ad-4ccc28a30ea0"), new DateTime(2021, 8, 1, 1, 37, 15, 674, DateTimeKind.Utc).AddTicks(6769), "Mid-port company", "Medium Company", 4.5m, null },
                    { new Guid("08e889d6-fc38-4ba6-b3a9-78695bc38088"), new DateTime(2021, 8, 1, 1, 37, 15, 674, DateTimeKind.Utc).AddTicks(6801), "Large company with more branches", "Large Company", 7.5m, null }
                });
        }
    }
}
