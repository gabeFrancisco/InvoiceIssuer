using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace InvoiceIssuer.Repository.Migrations
{
    public partial class CITypeFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                name: "CI",
                table: "Takers",
                fixedLength: true,
                maxLength: 7,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldFixedLength: true,
                oldMaxLength: 7);

            migrationBuilder.AlterColumn<string>(
                name: "CI",
                table: "Providers",
                fixedLength: true,
                maxLength: 7,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 7);

            migrationBuilder.InsertData(
                table: "CompanyTypes",
                columns: new[] { "Id", "CreatedAt", "Description", "Name", "TaxRate", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("bb4b9ab5-0643-47a9-aab6-7309aa09720d"), new DateTime(2021, 8, 1, 17, 49, 32, 811, DateTimeKind.Utc).AddTicks(1584), "This type of company is free from tax applications", "Individual Business", 0.0m, null },
                    { new Guid("0e2a9b0c-3958-4929-af5d-3bbbd3ba69d7"), new DateTime(2021, 8, 1, 17, 49, 32, 811, DateTimeKind.Utc).AddTicks(3960), "Small company that is beginning", "Small Company", 2.5m, null },
                    { new Guid("aa80d9e5-2162-474b-8cb3-1195f6a0f0bb"), new DateTime(2021, 8, 1, 17, 49, 32, 811, DateTimeKind.Utc).AddTicks(4015), "Mid-port company", "Medium Company", 4.5m, null },
                    { new Guid("6a41aeda-3353-45b7-93ed-45b85f9fe167"), new DateTime(2021, 8, 1, 17, 49, 32, 811, DateTimeKind.Utc).AddTicks(4041), "Large company with more branches", "Large Company", 7.5m, null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("0e2a9b0c-3958-4929-af5d-3bbbd3ba69d7"));

            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("6a41aeda-3353-45b7-93ed-45b85f9fe167"));

            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("aa80d9e5-2162-474b-8cb3-1195f6a0f0bb"));

            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("bb4b9ab5-0643-47a9-aab6-7309aa09720d"));

            migrationBuilder.AlterColumn<int>(
                name: "CI",
                table: "Takers",
                type: "int",
                fixedLength: true,
                maxLength: 7,
                nullable: false,
                oldClrType: typeof(string),
                oldFixedLength: true,
                oldMaxLength: 7);

            migrationBuilder.AlterColumn<int>(
                name: "CI",
                table: "Providers",
                type: "int",
                maxLength: 7,
                nullable: false,
                oldClrType: typeof(string),
                oldFixedLength: true,
                oldMaxLength: 7);

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
    }
}
