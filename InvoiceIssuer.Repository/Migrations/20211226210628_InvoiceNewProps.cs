using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace InvoiceIssuer.Repository.Migrations
{
    public partial class InvoiceNewProps : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("1ac0daa9-4de6-46d7-b26a-8d016172126a"));

            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("8adc1720-02fe-4940-9d2e-63b6441c410d"));

            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("b770ba86-f06c-4c9b-a8e6-ac3b49d90e05"));

            migrationBuilder.DeleteData(
                table: "CompanyTypes",
                keyColumn: "Id",
                keyValue: new Guid("d87ee15a-6168-408d-92f9-2db7f6f3aafe"));

            migrationBuilder.DeleteData(
                table: "ServiceTypes",
                keyColumn: "Id",
                keyValue: new Guid("068dd165-688e-489d-a72e-9b1c0b8f2d06"));

            migrationBuilder.DeleteData(
                table: "ServiceTypes",
                keyColumn: "Id",
                keyValue: new Guid("1c6e87b2-84aa-45e9-a304-9ba6eec76b83"));

            migrationBuilder.DeleteData(
                table: "ServiceTypes",
                keyColumn: "Id",
                keyValue: new Guid("2c6be071-d641-4d12-a9f6-914548c74775"));

            migrationBuilder.DeleteData(
                table: "ServiceTypes",
                keyColumn: "Id",
                keyValue: new Guid("4c9f9cfe-a5a7-4a4c-9057-0211524be934"));

            migrationBuilder.DeleteData(
                table: "ServiceTypes",
                keyColumn: "Id",
                keyValue: new Guid("50748a92-e8e7-4f71-b4ee-7d28cd9feb49"));

            migrationBuilder.DeleteData(
                table: "ServiceTypes",
                keyColumn: "Id",
                keyValue: new Guid("50ec9c9f-8f8d-4ca6-a991-191b9a15a480"));

            migrationBuilder.DeleteData(
                table: "ServiceTypes",
                keyColumn: "Id",
                keyValue: new Guid("78da73cc-dbc9-4ab0-b8e5-c356f2034266"));

            migrationBuilder.DeleteData(
                table: "ServiceTypes",
                keyColumn: "Id",
                keyValue: new Guid("885b7932-42eb-42be-841e-fe3becd39f83"));

            migrationBuilder.DeleteData(
                table: "ServiceTypes",
                keyColumn: "Id",
                keyValue: new Guid("9b79b298-8f2a-4343-a490-49dd7a24ce1d"));

            migrationBuilder.DeleteData(
                table: "ServiceTypes",
                keyColumn: "Id",
                keyValue: new Guid("a69c7e55-5e43-491b-b93e-4bdcdfb73ab8"));

            migrationBuilder.DeleteData(
                table: "ServiceTypes",
                keyColumn: "Id",
                keyValue: new Guid("c8555f6d-1cfc-4542-af0f-d7bfbcbb3e3e"));

            migrationBuilder.DeleteData(
                table: "ServiceTypes",
                keyColumn: "Id",
                keyValue: new Guid("f628e4cc-b12d-4527-becb-3943704e27ae"));

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "CompanyTypes",
                columns: new[] { "Id", "CreatedAt", "Description", "Name", "TaxRate", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("d87ee15a-6168-408d-92f9-2db7f6f3aafe"), new DateTime(2021, 12, 26, 20, 59, 50, 875, DateTimeKind.Utc).AddTicks(7617), "This type of company is free from tax applications", "Individual Business", 0.0m, null },
                    { new Guid("b770ba86-f06c-4c9b-a8e6-ac3b49d90e05"), new DateTime(2021, 12, 26, 20, 59, 50, 875, DateTimeKind.Utc).AddTicks(9749), "Small company that is beginning", "Small Company", 2.5m, null },
                    { new Guid("8adc1720-02fe-4940-9d2e-63b6441c410d"), new DateTime(2021, 12, 26, 20, 59, 50, 875, DateTimeKind.Utc).AddTicks(9831), "Mid-port company", "Medium Company", 4.5m, null },
                    { new Guid("1ac0daa9-4de6-46d7-b26a-8d016172126a"), new DateTime(2021, 12, 26, 20, 59, 50, 875, DateTimeKind.Utc).AddTicks(9882), "Large company with more branches", "Large Company", 7.5m, null }
                });

            migrationBuilder.InsertData(
                table: "ServiceTypes",
                columns: new[] { "Id", "CreatedAt", "Description", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("2c6be071-d641-4d12-a9f6-914548c74775"), new DateTime(2021, 12, 26, 20, 59, 50, 877, DateTimeKind.Utc).AddTicks(1909), "Activities and plannings that includes software development, management and project architecture", "Software Development", null },
                    { new Guid("068dd165-688e-489d-a72e-9b1c0b8f2d06"), new DateTime(2021, 12, 26, 20, 59, 50, 877, DateTimeKind.Utc).AddTicks(2874), "Lead training sessions, workshops or presentations to help team members improve or learn a certain skill", "Training", null },
                    { new Guid("f628e4cc-b12d-4527-becb-3943704e27ae"), new DateTime(2021, 12, 26, 20, 59, 50, 877, DateTimeKind.Utc).AddTicks(2961), "Event planning service for office parties, fundraising events and other corporate functions", "Event planning", null },
                    { new Guid("50ec9c9f-8f8d-4ca6-a991-191b9a15a480"), new DateTime(2021, 12, 26, 20, 59, 50, 877, DateTimeKind.Utc).AddTicks(3012), "Consulting services for a variety of projects, including financial budgeting, landscaping, audits and more", "Consulting", null },
                    { new Guid("885b7932-42eb-42be-841e-fe3becd39f83"), new DateTime(2021, 12, 26, 20, 59, 50, 877, DateTimeKind.Utc).AddTicks(3062), "Marketing services for companies advertise their products, services and brand by creating marketing campaigns", "Marketing", null },
                    { new Guid("a69c7e55-5e43-491b-b93e-4bdcdfb73ab8"), new DateTime(2021, 12, 26, 20, 59, 50, 877, DateTimeKind.Utc).AddTicks(3112), "Collect garbage and take it away to landfills and recycling facilities", "Waste management", null },
                    { new Guid("4c9f9cfe-a5a7-4a4c-9057-0211524be934"), new DateTime(2021, 12, 26, 20, 59, 50, 877, DateTimeKind.Utc).AddTicks(3161), "Service that project and execute construnctions for private and public areas", "Construction", null },
                    { new Guid("9b79b298-8f2a-4343-a490-49dd7a24ce1d"), new DateTime(2021, 12, 26, 20, 59, 50, 877, DateTimeKind.Utc).AddTicks(3212), "Draft business agreements, ask for advice or navigate a legal issue", "Law", null },
                    { new Guid("78da73cc-dbc9-4ab0-b8e5-c356f2034266"), new DateTime(2021, 12, 26, 20, 59, 50, 877, DateTimeKind.Utc).AddTicks(3262), "Medical assistance and health procedures", "Health", null },
                    { new Guid("c8555f6d-1cfc-4542-af0f-d7bfbcbb3e3e"), new DateTime(2021, 12, 26, 20, 59, 50, 877, DateTimeKind.Utc).AddTicks(3312), "Security services to ensure the safety of its employees and guests", "Security", null },
                    { new Guid("1c6e87b2-84aa-45e9-a304-9ba6eec76b83"), new DateTime(2021, 12, 26, 20, 59, 50, 877, DateTimeKind.Utc).AddTicks(3362), "Financial procedures for companies or peoples", "Finance", null },
                    { new Guid("50748a92-e8e7-4f71-b4ee-7d28cd9feb49"), new DateTime(2021, 12, 26, 20, 59, 50, 877, DateTimeKind.Utc).AddTicks(3412), "Service for child care assistance", "Child care", null }
                });
        }
    }
}
