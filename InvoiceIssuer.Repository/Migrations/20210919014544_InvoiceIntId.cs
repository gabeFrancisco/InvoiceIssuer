using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace InvoiceIssuer.Repository.Migrations
{
    public partial class InvoiceIntId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Invoices",
                table: "Invoices");

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

            migrationBuilder.AddColumn<int>(
                name: "Number",
                table: "Invoices",
                nullable: false,
                defaultValue: 0)
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Invoices",
                table: "Invoices",
                column: "Number");

            migrationBuilder.InsertData(
                table: "CompanyTypes",
                columns: new[] { "Id", "CreatedAt", "Description", "Name", "TaxRate", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("5d053612-1a3c-4065-8532-86ecd9b0a642"), new DateTime(2021, 9, 19, 1, 45, 44, 415, DateTimeKind.Utc).AddTicks(9020), "This type of company is free from tax applications", "Individual Business", 0.0m, null },
                    { new Guid("3129b6bd-1b66-4462-b6bd-2249480db04d"), new DateTime(2021, 9, 19, 1, 45, 44, 416, DateTimeKind.Utc).AddTicks(1712), "Small company that is beginning", "Small Company", 2.5m, null },
                    { new Guid("ab794eec-8984-4b90-ba39-ebdebf4d9a74"), new DateTime(2021, 9, 19, 1, 45, 44, 416, DateTimeKind.Utc).AddTicks(1864), "Mid-port company", "Medium Company", 4.5m, null },
                    { new Guid("5fdd9e0e-75ce-4194-9a22-377554406b99"), new DateTime(2021, 9, 19, 1, 45, 44, 416, DateTimeKind.Utc).AddTicks(1889), "Large company with more branches", "Large Company", 7.5m, null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Invoices",
                table: "Invoices");

            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("3129b6bd-1b66-4462-b6bd-2249480db04d"));

            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("5d053612-1a3c-4065-8532-86ecd9b0a642"));

            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("5fdd9e0e-75ce-4194-9a22-377554406b99"));

            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("ab794eec-8984-4b90-ba39-ebdebf4d9a74"));

            migrationBuilder.DropColumn(
                name: "Number",
                table: "Invoices");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Invoices",
                table: "Invoices",
                column: "Id");

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
    }
}
