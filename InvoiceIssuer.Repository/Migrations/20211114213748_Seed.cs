using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace InvoiceIssuer.Repository.Migrations
{
    public partial class Seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "CompanyTypes",
                columns: new[] { "Id", "CreatedAt", "Description", "Name", "TaxRate", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("b92c0161-994e-4566-b5de-36733e26c9e7"), new DateTime(2021, 11, 14, 21, 37, 47, 915, DateTimeKind.Utc).AddTicks(4365), "This type of company is free from tax applications", "Individual Business", 0.0m, null },
                    { new Guid("09688420-9927-4ae0-994c-4ed99596d39a"), new DateTime(2021, 11, 14, 21, 37, 47, 915, DateTimeKind.Utc).AddTicks(6707), "Small company that is beginning", "Small Company", 2.5m, null },
                    { new Guid("e0c56739-de2e-4c85-853f-df290f90ed58"), new DateTime(2021, 11, 14, 21, 37, 47, 915, DateTimeKind.Utc).AddTicks(6751), "Mid-port company", "Medium Company", 4.5m, null },
                    { new Guid("7466597e-68fb-4587-99e3-245a2a3e061e"), new DateTime(2021, 11, 14, 21, 37, 47, 915, DateTimeKind.Utc).AddTicks(6763), "Large company with more branches", "Large Company", 7.5m, null }
                });

            migrationBuilder.InsertData(
                table: "ServiceTypes",
                columns: new[] { "Id", "CreatedAt", "Description", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("0cc9cd1c-1928-4c2d-a0ef-cc032768a412"), new DateTime(2021, 11, 14, 21, 37, 47, 916, DateTimeKind.Utc).AddTicks(8792), "Activities and plannings that includes software development, management and project architecture", "Software Development", null },
                    { new Guid("83d29a79-ccf7-4959-999a-abc82b72d726"), new DateTime(2021, 11, 14, 21, 37, 47, 916, DateTimeKind.Utc).AddTicks(9490), "Lead training sessions, workshops or presentations to help team members improve or learn a certain skill", "Training", null },
                    { new Guid("81c48a6a-37ea-4bc4-8ad9-42102670e11c"), new DateTime(2021, 11, 14, 21, 37, 47, 916, DateTimeKind.Utc).AddTicks(9524), "Event planning service for office parties, fundraising events and other corporate functions", "Event planning", null },
                    { new Guid("8f608867-782d-46fb-a011-c6b7476fa81d"), new DateTime(2021, 11, 14, 21, 37, 47, 916, DateTimeKind.Utc).AddTicks(9536), "Consulting services for a variety of projects, including financial budgeting, landscaping, audits and more", "Consulting", null },
                    { new Guid("c06ed54e-bb29-4a09-9d29-40d5d54db779"), new DateTime(2021, 11, 14, 21, 37, 47, 916, DateTimeKind.Utc).AddTicks(9546), "Marketing services for companies advertise their products, services and brand by creating marketing campaigns", "Marketing", null },
                    { new Guid("52079df6-841b-48cf-bbd7-69cf1f12c506"), new DateTime(2021, 11, 14, 21, 37, 47, 916, DateTimeKind.Utc).AddTicks(9557), "Collect garbage and take it away to landfills and recycling facilities", "Waste management", null },
                    { new Guid("c4fa0388-1d87-4f60-b2c1-335729720d71"), new DateTime(2021, 11, 14, 21, 37, 47, 916, DateTimeKind.Utc).AddTicks(9568), "Service that project and execute construnctions for private and public areas", "Construction", null },
                    { new Guid("fb2cc9b8-dd3a-4f86-a8b8-3ee882760332"), new DateTime(2021, 11, 14, 21, 37, 47, 916, DateTimeKind.Utc).AddTicks(9579), "Draft business agreements, ask for advice or navigate a legal issue", "Law", null },
                    { new Guid("ef32aeab-08d6-44b4-a10f-b257a0b612fe"), new DateTime(2021, 11, 14, 21, 37, 47, 916, DateTimeKind.Utc).AddTicks(9589), "Medical assistance and health procedures", "Health", null },
                    { new Guid("06dcd283-9c0e-44f9-aa8e-3d8109f2b0f7"), new DateTime(2021, 11, 14, 21, 37, 47, 916, DateTimeKind.Utc).AddTicks(9600), "Security services to ensure the safety of its employees and guests", "Security", null },
                    { new Guid("1334a3c9-e3a3-4683-85bd-d32a51ad159f"), new DateTime(2021, 11, 14, 21, 37, 47, 916, DateTimeKind.Utc).AddTicks(9610), "Financial procedures for companies or peoples", "Finance", null },
                    { new Guid("1335d9f8-cc3d-42c2-a82c-f40fbf98588a"), new DateTime(2021, 11, 14, 21, 37, 47, 916, DateTimeKind.Utc).AddTicks(9621), "Service for child care assistance", "Child care", null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("09688420-9927-4ae0-994c-4ed99596d39a"));

            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("7466597e-68fb-4587-99e3-245a2a3e061e"));

            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("b92c0161-994e-4566-b5de-36733e26c9e7"));

            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("e0c56739-de2e-4c85-853f-df290f90ed58"));

            migrationBuilder.DeleteData(
                table: "ServiceTypes",
                keyColumn: "Id",
                keyValue: new Guid("06dcd283-9c0e-44f9-aa8e-3d8109f2b0f7"));

            migrationBuilder.DeleteData(
                table: "ServiceTypes",
                keyColumn: "Id",
                keyValue: new Guid("0cc9cd1c-1928-4c2d-a0ef-cc032768a412"));

            migrationBuilder.DeleteData(
                table: "ServiceTypes",
                keyColumn: "Id",
                keyValue: new Guid("1334a3c9-e3a3-4683-85bd-d32a51ad159f"));

            migrationBuilder.DeleteData(
                table: "ServiceTypes",
                keyColumn: "Id",
                keyValue: new Guid("1335d9f8-cc3d-42c2-a82c-f40fbf98588a"));

            migrationBuilder.DeleteData(
                table: "ServiceTypes",
                keyColumn: "Id",
                keyValue: new Guid("52079df6-841b-48cf-bbd7-69cf1f12c506"));

            migrationBuilder.DeleteData(
                table: "ServiceTypes",
                keyColumn: "Id",
                keyValue: new Guid("81c48a6a-37ea-4bc4-8ad9-42102670e11c"));

            migrationBuilder.DeleteData(
                table: "ServiceTypes",
                keyColumn: "Id",
                keyValue: new Guid("83d29a79-ccf7-4959-999a-abc82b72d726"));

            migrationBuilder.DeleteData(
                table: "ServiceTypes",
                keyColumn: "Id",
                keyValue: new Guid("8f608867-782d-46fb-a011-c6b7476fa81d"));

            migrationBuilder.DeleteData(
                table: "ServiceTypes",
                keyColumn: "Id",
                keyValue: new Guid("c06ed54e-bb29-4a09-9d29-40d5d54db779"));

            migrationBuilder.DeleteData(
                table: "ServiceTypes",
                keyColumn: "Id",
                keyValue: new Guid("c4fa0388-1d87-4f60-b2c1-335729720d71"));

            migrationBuilder.DeleteData(
                table: "ServiceTypes",
                keyColumn: "Id",
                keyValue: new Guid("ef32aeab-08d6-44b4-a10f-b257a0b612fe"));

            migrationBuilder.DeleteData(
                table: "ServiceTypes",
                keyColumn: "Id",
                keyValue: new Guid("fb2cc9b8-dd3a-4f86-a8b8-3ee882760332"));

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
        }
    }
}
