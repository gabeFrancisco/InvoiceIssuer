using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace InvoiceIssuer.Repository.Migrations
{
    public partial class Canceled_Edited_Fix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("166481f2-6466-406d-a449-e3a629ca72aa"));

            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("32b5d240-a9e8-41b6-8037-a9e42be5794f"));

            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("7dd43fa1-0c49-4909-a21a-468dc5ba8bb1"));

            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("f60ee2a8-957c-4ae9-aa20-b71995af8b53"));

            migrationBuilder.DeleteData(
                table: "ServiceTypes",
                keyColumn: "Id",
                keyValue: new Guid("07d3f2c5-0562-4a89-9d97-cda876ef6813"));

            migrationBuilder.DeleteData(
                table: "ServiceTypes",
                keyColumn: "Id",
                keyValue: new Guid("1f94a8a0-0de2-419c-acb8-6a9982ae6304"));

            migrationBuilder.DeleteData(
                table: "ServiceTypes",
                keyColumn: "Id",
                keyValue: new Guid("26e6be00-41c7-45c9-902c-babfb3b1b93a"));

            migrationBuilder.DeleteData(
                table: "ServiceTypes",
                keyColumn: "Id",
                keyValue: new Guid("287218ab-aa45-4bad-a4cd-12604d48b64e"));

            migrationBuilder.DeleteData(
                table: "ServiceTypes",
                keyColumn: "Id",
                keyValue: new Guid("342ff50d-a6bd-4dac-a56e-ffea61ed298b"));

            migrationBuilder.DeleteData(
                table: "ServiceTypes",
                keyColumn: "Id",
                keyValue: new Guid("3582503c-20d1-4bb2-a237-b63630200616"));

            migrationBuilder.DeleteData(
                table: "ServiceTypes",
                keyColumn: "Id",
                keyValue: new Guid("b0fde239-2fb2-4a9b-954a-7d8ee6b5ee73"));

            migrationBuilder.DeleteData(
                table: "ServiceTypes",
                keyColumn: "Id",
                keyValue: new Guid("bb72d802-7082-45fb-a043-c3d5b163680f"));

            migrationBuilder.DeleteData(
                table: "ServiceTypes",
                keyColumn: "Id",
                keyValue: new Guid("bd4f8d33-ad18-489a-9ce9-cb354498de9e"));

            migrationBuilder.DeleteData(
                table: "ServiceTypes",
                keyColumn: "Id",
                keyValue: new Guid("d698158f-c50e-4b3c-b127-e292cb16a9d9"));

            migrationBuilder.DeleteData(
                table: "ServiceTypes",
                keyColumn: "Id",
                keyValue: new Guid("d7cee500-5227-43af-bf2d-89210fc2dfad"));

            migrationBuilder.DeleteData(
                table: "ServiceTypes",
                keyColumn: "Id",
                keyValue: new Guid("fc552c6b-6c52-4004-806f-d73b0f22a79e"));

            migrationBuilder.InsertData(
                table: "CompanyTypes",
                columns: new[] { "Id", "CreatedAt", "Description", "Name", "TaxRate", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("d6bcb227-e4ed-4952-baef-e9b70d235550"), new DateTime(2023, 5, 5, 3, 10, 6, 285, DateTimeKind.Utc).AddTicks(2410), "This type of company is free from tax applications", "Individual Business", 0.0m, null },
                    { new Guid("73bfea7f-fecf-4d59-8b37-ca802d10c6f7"), new DateTime(2023, 5, 5, 3, 10, 6, 285, DateTimeKind.Utc).AddTicks(4590), "Small company that is beginning", "Small Company", 2.5m, null },
                    { new Guid("b48b3a7a-368a-4e54-88c1-5a3415d116e9"), new DateTime(2023, 5, 5, 3, 10, 6, 285, DateTimeKind.Utc).AddTicks(4644), "Mid-port company", "Medium Company", 4.5m, null },
                    { new Guid("84c75355-4148-455e-bbba-059ff4d2dc0f"), new DateTime(2023, 5, 5, 3, 10, 6, 285, DateTimeKind.Utc).AddTicks(4667), "Large company with more branches", "Large Company", 7.5m, null }
                });

            migrationBuilder.InsertData(
                table: "ServiceTypes",
                columns: new[] { "Id", "CreatedAt", "Description", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("ead2aabd-dc8c-496e-9284-6ddb5ce02498"), new DateTime(2023, 5, 5, 3, 10, 6, 286, DateTimeKind.Utc).AddTicks(6837), "Activities and plannings that includes software development, management and project architecture", "Software Development", null },
                    { new Guid("87486c90-8354-418c-816b-0c0dc04cb8ab"), new DateTime(2023, 5, 5, 3, 10, 6, 286, DateTimeKind.Utc).AddTicks(7579), "Lead training sessions, workshops or presentations to help team members improve or learn a certain skill", "Training", null },
                    { new Guid("146ded85-36b5-4e00-8bb6-8e0a19c1f031"), new DateTime(2023, 5, 5, 3, 10, 6, 286, DateTimeKind.Utc).AddTicks(7625), "Event planning service for office parties, fundraising events and other corporate functions", "Event planning", null },
                    { new Guid("dc88a24f-06e8-466f-8c46-581f04162e93"), new DateTime(2023, 5, 5, 3, 10, 6, 286, DateTimeKind.Utc).AddTicks(7648), "Consulting services for a variety of projects, including financial budgeting, landscaping, audits and more", "Consulting", null },
                    { new Guid("81e7da92-379b-4e5d-9305-4c33329a90bc"), new DateTime(2023, 5, 5, 3, 10, 6, 286, DateTimeKind.Utc).AddTicks(7671), "Marketing services for companies advertise their products, services and brand by creating marketing campaigns", "Marketing", null },
                    { new Guid("abe5922d-a921-4d8e-93d7-7f06e77e7f75"), new DateTime(2023, 5, 5, 3, 10, 6, 286, DateTimeKind.Utc).AddTicks(7693), "Collect garbage and take it away to landfills and recycling facilities", "Waste management", null },
                    { new Guid("fcda8ca6-b4d6-4060-82ee-afae08efa1d4"), new DateTime(2023, 5, 5, 3, 10, 6, 286, DateTimeKind.Utc).AddTicks(7716), "Service that project and execute construnctions for private and public areas", "Construction", null },
                    { new Guid("3c180d52-8505-4b5c-b138-ad641ae54427"), new DateTime(2023, 5, 5, 3, 10, 6, 286, DateTimeKind.Utc).AddTicks(7739), "Draft business agreements, ask for advice or navigate a legal issue", "Law", null },
                    { new Guid("33994095-8abf-4a02-9792-4a2859ce6c84"), new DateTime(2023, 5, 5, 3, 10, 6, 286, DateTimeKind.Utc).AddTicks(7761), "Medical assistance and health procedures", "Health", null },
                    { new Guid("e9ee0c8f-3c2a-4114-9415-da8df238d513"), new DateTime(2023, 5, 5, 3, 10, 6, 286, DateTimeKind.Utc).AddTicks(7784), "Security services to ensure the safety of its employees and guests", "Security", null },
                    { new Guid("4c4e92af-ec1f-4d13-8442-335897167f19"), new DateTime(2023, 5, 5, 3, 10, 6, 286, DateTimeKind.Utc).AddTicks(7807), "Financial procedures for companies or peoples", "Finance", null },
                    { new Guid("af4b74c9-1bba-4a45-84e7-95785ef655a2"), new DateTime(2023, 5, 5, 3, 10, 6, 286, DateTimeKind.Utc).AddTicks(7829), "Service for child care assistance", "Child care", null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("73bfea7f-fecf-4d59-8b37-ca802d10c6f7"));

            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("84c75355-4148-455e-bbba-059ff4d2dc0f"));

            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("b48b3a7a-368a-4e54-88c1-5a3415d116e9"));

            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("d6bcb227-e4ed-4952-baef-e9b70d235550"));

            migrationBuilder.DeleteData(
                table: "ServiceTypes",
                keyColumn: "Id",
                keyValue: new Guid("146ded85-36b5-4e00-8bb6-8e0a19c1f031"));

            migrationBuilder.DeleteData(
                table: "ServiceTypes",
                keyColumn: "Id",
                keyValue: new Guid("33994095-8abf-4a02-9792-4a2859ce6c84"));

            migrationBuilder.DeleteData(
                table: "ServiceTypes",
                keyColumn: "Id",
                keyValue: new Guid("3c180d52-8505-4b5c-b138-ad641ae54427"));

            migrationBuilder.DeleteData(
                table: "ServiceTypes",
                keyColumn: "Id",
                keyValue: new Guid("4c4e92af-ec1f-4d13-8442-335897167f19"));

            migrationBuilder.DeleteData(
                table: "ServiceTypes",
                keyColumn: "Id",
                keyValue: new Guid("81e7da92-379b-4e5d-9305-4c33329a90bc"));

            migrationBuilder.DeleteData(
                table: "ServiceTypes",
                keyColumn: "Id",
                keyValue: new Guid("87486c90-8354-418c-816b-0c0dc04cb8ab"));

            migrationBuilder.DeleteData(
                table: "ServiceTypes",
                keyColumn: "Id",
                keyValue: new Guid("abe5922d-a921-4d8e-93d7-7f06e77e7f75"));

            migrationBuilder.DeleteData(
                table: "ServiceTypes",
                keyColumn: "Id",
                keyValue: new Guid("af4b74c9-1bba-4a45-84e7-95785ef655a2"));

            migrationBuilder.DeleteData(
                table: "ServiceTypes",
                keyColumn: "Id",
                keyValue: new Guid("dc88a24f-06e8-466f-8c46-581f04162e93"));

            migrationBuilder.DeleteData(
                table: "ServiceTypes",
                keyColumn: "Id",
                keyValue: new Guid("e9ee0c8f-3c2a-4114-9415-da8df238d513"));

            migrationBuilder.DeleteData(
                table: "ServiceTypes",
                keyColumn: "Id",
                keyValue: new Guid("ead2aabd-dc8c-496e-9284-6ddb5ce02498"));

            migrationBuilder.DeleteData(
                table: "ServiceTypes",
                keyColumn: "Id",
                keyValue: new Guid("fcda8ca6-b4d6-4060-82ee-afae08efa1d4"));

            migrationBuilder.InsertData(
                table: "CompanyTypes",
                columns: new[] { "Id", "CreatedAt", "Description", "Name", "TaxRate", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("32b5d240-a9e8-41b6-8037-a9e42be5794f"), new DateTime(2023, 5, 5, 3, 2, 33, 203, DateTimeKind.Utc).AddTicks(6825), "This type of company is free from tax applications", "Individual Business", 0.0m, null },
                    { new Guid("166481f2-6466-406d-a449-e3a629ca72aa"), new DateTime(2023, 5, 5, 3, 2, 33, 203, DateTimeKind.Utc).AddTicks(8876), "Small company that is beginning", "Small Company", 2.5m, null },
                    { new Guid("f60ee2a8-957c-4ae9-aa20-b71995af8b53"), new DateTime(2023, 5, 5, 3, 2, 33, 203, DateTimeKind.Utc).AddTicks(8931), "Mid-port company", "Medium Company", 4.5m, null },
                    { new Guid("7dd43fa1-0c49-4909-a21a-468dc5ba8bb1"), new DateTime(2023, 5, 5, 3, 2, 33, 203, DateTimeKind.Utc).AddTicks(8954), "Large company with more branches", "Large Company", 7.5m, null }
                });

            migrationBuilder.InsertData(
                table: "ServiceTypes",
                columns: new[] { "Id", "CreatedAt", "Description", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("07d3f2c5-0562-4a89-9d97-cda876ef6813"), new DateTime(2023, 5, 5, 3, 2, 33, 205, DateTimeKind.Utc).AddTicks(1742), "Activities and plannings that includes software development, management and project architecture", "Software Development", null },
                    { new Guid("d7cee500-5227-43af-bf2d-89210fc2dfad"), new DateTime(2023, 5, 5, 3, 2, 33, 205, DateTimeKind.Utc).AddTicks(2511), "Lead training sessions, workshops or presentations to help team members improve or learn a certain skill", "Training", null },
                    { new Guid("bb72d802-7082-45fb-a043-c3d5b163680f"), new DateTime(2023, 5, 5, 3, 2, 33, 205, DateTimeKind.Utc).AddTicks(2560), "Event planning service for office parties, fundraising events and other corporate functions", "Event planning", null },
                    { new Guid("342ff50d-a6bd-4dac-a56e-ffea61ed298b"), new DateTime(2023, 5, 5, 3, 2, 33, 205, DateTimeKind.Utc).AddTicks(2583), "Consulting services for a variety of projects, including financial budgeting, landscaping, audits and more", "Consulting", null },
                    { new Guid("26e6be00-41c7-45c9-902c-babfb3b1b93a"), new DateTime(2023, 5, 5, 3, 2, 33, 205, DateTimeKind.Utc).AddTicks(2606), "Marketing services for companies advertise their products, services and brand by creating marketing campaigns", "Marketing", null },
                    { new Guid("287218ab-aa45-4bad-a4cd-12604d48b64e"), new DateTime(2023, 5, 5, 3, 2, 33, 205, DateTimeKind.Utc).AddTicks(2628), "Collect garbage and take it away to landfills and recycling facilities", "Waste management", null },
                    { new Guid("1f94a8a0-0de2-419c-acb8-6a9982ae6304"), new DateTime(2023, 5, 5, 3, 2, 33, 205, DateTimeKind.Utc).AddTicks(2651), "Service that project and execute construnctions for private and public areas", "Construction", null },
                    { new Guid("3582503c-20d1-4bb2-a237-b63630200616"), new DateTime(2023, 5, 5, 3, 2, 33, 205, DateTimeKind.Utc).AddTicks(2674), "Draft business agreements, ask for advice or navigate a legal issue", "Law", null },
                    { new Guid("fc552c6b-6c52-4004-806f-d73b0f22a79e"), new DateTime(2023, 5, 5, 3, 2, 33, 205, DateTimeKind.Utc).AddTicks(2696), "Medical assistance and health procedures", "Health", null },
                    { new Guid("b0fde239-2fb2-4a9b-954a-7d8ee6b5ee73"), new DateTime(2023, 5, 5, 3, 2, 33, 205, DateTimeKind.Utc).AddTicks(2719), "Security services to ensure the safety of its employees and guests", "Security", null },
                    { new Guid("d698158f-c50e-4b3c-b127-e292cb16a9d9"), new DateTime(2023, 5, 5, 3, 2, 33, 205, DateTimeKind.Utc).AddTicks(2741), "Financial procedures for companies or peoples", "Finance", null },
                    { new Guid("bd4f8d33-ad18-489a-9ce9-cb354498de9e"), new DateTime(2023, 5, 5, 3, 2, 33, 205, DateTimeKind.Utc).AddTicks(2764), "Service for child care assistance", "Child care", null }
                });
        }
    }
}
