using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace InvoiceIssuer.Repository.Migrations
{
    public partial class InvoiceIdFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<int>(
                name: "Number",
                table: "Invoices",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddColumn<Guid>(
                name: "ProviderId",
                table: "Invoices",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddPrimaryKey(
                name: "PK_Invoices",
                table: "Invoices",
                column: "Id");

            migrationBuilder.InsertData(
                table: "CompanyTypes",
                columns: new[] { "Id", "CreatedAt", "Description", "Name", "TaxRate", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("d478155c-b418-40fb-a004-990d1f1b2133"), new DateTime(2021, 9, 19, 16, 9, 2, 270, DateTimeKind.Utc).AddTicks(7055), "This type of company is free from tax applications", "Individual Business", 0.0m, null },
                    { new Guid("dcd648fa-ff87-4dc9-89ca-67ce867901dd"), new DateTime(2021, 9, 19, 16, 9, 2, 270, DateTimeKind.Utc).AddTicks(9408), "Small company that is beginning", "Small Company", 2.5m, null },
                    { new Guid("82fa412c-8fa4-43b2-af0d-4cc1f2fd34d4"), new DateTime(2021, 9, 19, 16, 9, 2, 270, DateTimeKind.Utc).AddTicks(9470), "Mid-port company", "Medium Company", 4.5m, null },
                    { new Guid("06400ac3-acd0-42fc-8866-c85b481eceb4"), new DateTime(2021, 9, 19, 16, 9, 2, 270, DateTimeKind.Utc).AddTicks(9495), "Large company with more branches", "Large Company", 7.5m, null }
                });

            migrationBuilder.InsertData(
                table: "ServiceTypes",
                columns: new[] { "Id", "CreatedAt", "Description", "Name", "UpdatedAt" },
                values: new object[] { new Guid("1015c5c0-b4d7-4024-86ea-6a262924f6c5"), new DateTime(2021, 9, 19, 16, 9, 2, 272, DateTimeKind.Utc).AddTicks(1065), "Activities and plannings that includes software development, management and project architecture", "Software Development", null });

            migrationBuilder.CreateIndex(
                name: "IX_Invoices_ProviderId",
                table: "Invoices",
                column: "ProviderId");

            migrationBuilder.AddForeignKey(
                name: "FK_Invoices_Providers_ProviderId",
                table: "Invoices",
                column: "ProviderId",
                principalTable: "Providers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Invoices_Providers_ProviderId",
                table: "Invoices");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Invoices",
                table: "Invoices");

            migrationBuilder.DropIndex(
                name: "IX_Invoices_ProviderId",
                table: "Invoices");

            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("06400ac3-acd0-42fc-8866-c85b481eceb4"));

            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("82fa412c-8fa4-43b2-af0d-4cc1f2fd34d4"));

            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("d478155c-b418-40fb-a004-990d1f1b2133"));

            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("dcd648fa-ff87-4dc9-89ca-67ce867901dd"));

            migrationBuilder.DeleteData(
                table: "ServiceTypes",
                keyColumn: "Id",
                keyValue: new Guid("1015c5c0-b4d7-4024-86ea-6a262924f6c5"));

            migrationBuilder.DropColumn(
                name: "ProviderId",
                table: "Invoices");

            migrationBuilder.AlterColumn<int>(
                name: "Number",
                table: "Invoices",
                type: "int",
                nullable: false,
                oldClrType: typeof(int))
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
    }
}
