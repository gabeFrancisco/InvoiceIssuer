using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace InvoiceIssuer.Repository.Migrations
{
    public partial class Canceled_Edited : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("58837249-b572-4c69-a7a3-454c99f5bdd5"));

            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("60a13227-9992-4f95-b387-855fdb34cef4"));

            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("d6675f73-2593-4d61-bf76-2926faef7373"));

            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("dffc8e53-207d-4076-8bf4-096d8df87649"));

            migrationBuilder.DeleteData(
                table: "ServiceTypes",
                keyColumn: "Id",
                keyValue: new Guid("277ddf89-a921-4e1d-a204-caa7d2415108"));

            migrationBuilder.DeleteData(
                table: "ServiceTypes",
                keyColumn: "Id",
                keyValue: new Guid("2b90f47b-f3a2-4477-a359-8036523a2b48"));

            migrationBuilder.DeleteData(
                table: "ServiceTypes",
                keyColumn: "Id",
                keyValue: new Guid("2c13bd1b-4edf-43b6-802b-2d93154092c3"));

            migrationBuilder.DeleteData(
                table: "ServiceTypes",
                keyColumn: "Id",
                keyValue: new Guid("4c7ffb03-5bc5-43b9-a782-831be7ccc862"));

            migrationBuilder.DeleteData(
                table: "ServiceTypes",
                keyColumn: "Id",
                keyValue: new Guid("76e33afb-fd17-4f7b-8c29-b00fe28f4a65"));

            migrationBuilder.DeleteData(
                table: "ServiceTypes",
                keyColumn: "Id",
                keyValue: new Guid("8a4952e6-0993-4a8d-a4c4-6922a73d8902"));

            migrationBuilder.DeleteData(
                table: "ServiceTypes",
                keyColumn: "Id",
                keyValue: new Guid("8d711f35-dfa1-4333-a3cf-31e33ada93d3"));

            migrationBuilder.DeleteData(
                table: "ServiceTypes",
                keyColumn: "Id",
                keyValue: new Guid("bde37595-5f20-43cb-aa91-a2eb37233ccc"));

            migrationBuilder.DeleteData(
                table: "ServiceTypes",
                keyColumn: "Id",
                keyValue: new Guid("c70af450-9852-4cd7-8285-9c7e166dcc64"));

            migrationBuilder.DeleteData(
                table: "ServiceTypes",
                keyColumn: "Id",
                keyValue: new Guid("db0f68de-c8e5-4b64-abba-bd1b8eceb237"));

            migrationBuilder.DeleteData(
                table: "ServiceTypes",
                keyColumn: "Id",
                keyValue: new Guid("e6895aa7-9563-4223-9f4f-a9c6914d9f95"));

            migrationBuilder.DeleteData(
                table: "ServiceTypes",
                keyColumn: "Id",
                keyValue: new Guid("f4903fab-30b4-4979-8b9f-8b67adeb7756"));

            migrationBuilder.AddColumn<bool>(
                name: "IsEditable",
                table: "Invoices",
                type: "bool",
                nullable: false,
                defaultValue: false);

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "IsEditable",
                table: "Invoices");

            migrationBuilder.InsertData(
                table: "CompanyTypes",
                columns: new[] { "Id", "CreatedAt", "Description", "Name", "TaxRate", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("58837249-b572-4c69-a7a3-454c99f5bdd5"), new DateTime(2021, 12, 26, 21, 6, 27, 980, DateTimeKind.Utc).AddTicks(8689), "This type of company is free from tax applications", "Individual Business", 0.0m, null },
                    { new Guid("60a13227-9992-4f95-b387-855fdb34cef4"), new DateTime(2021, 12, 26, 21, 6, 27, 981, DateTimeKind.Utc).AddTicks(782), "Small company that is beginning", "Small Company", 2.5m, null },
                    { new Guid("dffc8e53-207d-4076-8bf4-096d8df87649"), new DateTime(2021, 12, 26, 21, 6, 27, 981, DateTimeKind.Utc).AddTicks(870), "Mid-port company", "Medium Company", 4.5m, null },
                    { new Guid("d6675f73-2593-4d61-bf76-2926faef7373"), new DateTime(2021, 12, 26, 21, 6, 27, 981, DateTimeKind.Utc).AddTicks(923), "Large company with more branches", "Large Company", 7.5m, null }
                });

            migrationBuilder.InsertData(
                table: "ServiceTypes",
                columns: new[] { "Id", "CreatedAt", "Description", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("bde37595-5f20-43cb-aa91-a2eb37233ccc"), new DateTime(2021, 12, 26, 21, 6, 27, 982, DateTimeKind.Utc).AddTicks(3456), "Activities and plannings that includes software development, management and project architecture", "Software Development", null },
                    { new Guid("8d711f35-dfa1-4333-a3cf-31e33ada93d3"), new DateTime(2021, 12, 26, 21, 6, 27, 982, DateTimeKind.Utc).AddTicks(4439), "Lead training sessions, workshops or presentations to help team members improve or learn a certain skill", "Training", null },
                    { new Guid("76e33afb-fd17-4f7b-8c29-b00fe28f4a65"), new DateTime(2021, 12, 26, 21, 6, 27, 982, DateTimeKind.Utc).AddTicks(4516), "Event planning service for office parties, fundraising events and other corporate functions", "Event planning", null },
                    { new Guid("2c13bd1b-4edf-43b6-802b-2d93154092c3"), new DateTime(2021, 12, 26, 21, 6, 27, 982, DateTimeKind.Utc).AddTicks(4567), "Consulting services for a variety of projects, including financial budgeting, landscaping, audits and more", "Consulting", null },
                    { new Guid("db0f68de-c8e5-4b64-abba-bd1b8eceb237"), new DateTime(2021, 12, 26, 21, 6, 27, 982, DateTimeKind.Utc).AddTicks(4617), "Marketing services for companies advertise their products, services and brand by creating marketing campaigns", "Marketing", null },
                    { new Guid("8a4952e6-0993-4a8d-a4c4-6922a73d8902"), new DateTime(2021, 12, 26, 21, 6, 27, 982, DateTimeKind.Utc).AddTicks(4666), "Collect garbage and take it away to landfills and recycling facilities", "Waste management", null },
                    { new Guid("c70af450-9852-4cd7-8285-9c7e166dcc64"), new DateTime(2021, 12, 26, 21, 6, 27, 982, DateTimeKind.Utc).AddTicks(4716), "Service that project and execute construnctions for private and public areas", "Construction", null },
                    { new Guid("2b90f47b-f3a2-4477-a359-8036523a2b48"), new DateTime(2021, 12, 26, 21, 6, 27, 982, DateTimeKind.Utc).AddTicks(4766), "Draft business agreements, ask for advice or navigate a legal issue", "Law", null },
                    { new Guid("f4903fab-30b4-4979-8b9f-8b67adeb7756"), new DateTime(2021, 12, 26, 21, 6, 27, 982, DateTimeKind.Utc).AddTicks(4817), "Medical assistance and health procedures", "Health", null },
                    { new Guid("e6895aa7-9563-4223-9f4f-a9c6914d9f95"), new DateTime(2021, 12, 26, 21, 6, 27, 982, DateTimeKind.Utc).AddTicks(4867), "Security services to ensure the safety of its employees and guests", "Security", null },
                    { new Guid("277ddf89-a921-4e1d-a204-caa7d2415108"), new DateTime(2021, 12, 26, 21, 6, 27, 982, DateTimeKind.Utc).AddTicks(4917), "Financial procedures for companies or peoples", "Finance", null },
                    { new Guid("4c7ffb03-5bc5-43b9-a782-831be7ccc862"), new DateTime(2021, 12, 26, 21, 6, 27, 982, DateTimeKind.Utc).AddTicks(4966), "Service for child care assistance", "Child care", null }
                });
        }
    }
}
