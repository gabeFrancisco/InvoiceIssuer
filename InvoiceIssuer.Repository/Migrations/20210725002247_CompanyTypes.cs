using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace InvoiceIssuer.Repository.Migrations
{
    public partial class CompanyTypes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "CompanyTypes",
                columns: new[] { "Id", "CreatedAt", "Description", "Name", "TaxRate", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("8bef5025-7143-4249-b44c-45e90646de9b"), new DateTime(2021, 7, 25, 0, 22, 46, 552, DateTimeKind.Utc).AddTicks(6298), "This type of company is free from tax applications", "Individual Business", 0.0m, null },
                    { new Guid("5a197336-4800-4261-96f2-4d6bf8b4b5e4"), new DateTime(2021, 7, 25, 0, 22, 46, 552, DateTimeKind.Utc).AddTicks(8690), "Small company that is beginning", "Small Company", 2.5m, null },
                    { new Guid("457c5fd2-1150-4eb8-9b8f-4aaf17a61e52"), new DateTime(2021, 7, 25, 0, 22, 46, 552, DateTimeKind.Utc).AddTicks(8745), "Mid-port company", "Medium Company", 4.5m, null },
                    { new Guid("b0ba86df-e655-4ee1-8f5d-746b081cbdd6"), new DateTime(2021, 7, 25, 0, 22, 46, 552, DateTimeKind.Utc).AddTicks(8770), "Large company with more branches", "Large Company", 7.5m, null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("457c5fd2-1150-4eb8-9b8f-4aaf17a61e52"));

            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("5a197336-4800-4261-96f2-4d6bf8b4b5e4"));

            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("8bef5025-7143-4249-b44c-45e90646de9b"));

            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("b0ba86df-e655-4ee1-8f5d-746b081cbdd6"));
        }
    }
}
