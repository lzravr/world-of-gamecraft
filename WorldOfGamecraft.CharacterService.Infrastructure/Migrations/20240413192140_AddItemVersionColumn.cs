using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WorldOfGamecraft.CharacterService.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddItemVersionColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "classes",
                keyColumn: "id",
                keyValue: new Guid("3d30bf8c-4e53-4f47-9eef-33701e3a7b19"));

            migrationBuilder.DeleteData(
                table: "classes",
                keyColumn: "id",
                keyValue: new Guid("72f3e124-ebca-45f7-9882-c9ed4eee7c06"));

            migrationBuilder.DeleteData(
                table: "items",
                keyColumn: "id",
                keyValue: new Guid("15afbf36-1847-44d6-b5f6-fc32f2804cdb"));

            migrationBuilder.DeleteData(
                table: "items",
                keyColumn: "id",
                keyValue: new Guid("2c256179-eabb-4b16-90d3-7444a8ae533e"));

            migrationBuilder.DeleteData(
                table: "items",
                keyColumn: "id",
                keyValue: new Guid("7435e0fd-a0aa-407c-9bb8-0467e0396bd3"));

            migrationBuilder.DeleteData(
                table: "items",
                keyColumn: "id",
                keyValue: new Guid("75d3df17-6ff6-4dfc-8e69-dd55f314c768"));

            migrationBuilder.DeleteData(
                table: "items",
                keyColumn: "id",
                keyValue: new Guid("9f4f0103-699e-48a0-8908-1a62c0438883"));

            migrationBuilder.DeleteData(
                table: "characters",
                keyColumn: "id",
                keyValue: new Guid("21f9c31a-490d-4eda-a5b7-cc237f45a889"));

            migrationBuilder.DeleteData(
                table: "characters",
                keyColumn: "id",
                keyValue: new Guid("8023da36-f5dc-4314-9c56-79bcf21ca876"));

            migrationBuilder.DeleteData(
                table: "characters",
                keyColumn: "id",
                keyValue: new Guid("a86c1c30-f798-493f-9576-fa031d4e293c"));

            migrationBuilder.DeleteData(
                table: "characters",
                keyColumn: "id",
                keyValue: new Guid("b16e8485-d109-453d-8b03-d51883a821f8"));

            migrationBuilder.DeleteData(
                table: "characters",
                keyColumn: "id",
                keyValue: new Guid("f6a496af-d9da-432d-be7c-2bc0f00604fc"));

            migrationBuilder.DeleteData(
                table: "classes",
                keyColumn: "id",
                keyValue: new Guid("8cc132e6-52f0-4f16-83b5-f29e43ca3abd"));

            migrationBuilder.DeleteData(
                table: "classes",
                keyColumn: "id",
                keyValue: new Guid("9d0e44fd-4577-43f7-b158-1737ab1c795f"));

            migrationBuilder.DeleteData(
                table: "classes",
                keyColumn: "id",
                keyValue: new Guid("b158dd00-8b10-44c4-b5f9-87e8641d3dec"));

            migrationBuilder.DeleteData(
                table: "classes",
                keyColumn: "id",
                keyValue: new Guid("c75551bc-d02c-4e82-b17d-00fa5f16fa36"));

            migrationBuilder.AddColumn<uint>(
                name: "xmin",
                table: "items",
                type: "xid",
                rowVersion: true,
                nullable: false,
                defaultValue: 0u);

            migrationBuilder.InsertData(
                table: "classes",
                columns: new[] { "id", "description", "name" },
                values: new object[,]
                {
                    { new Guid("07e36e47-634b-4934-aa26-fbfb8695f208"), "Quas error sapiente nihil.", "Mage" },
                    { new Guid("53be613f-fff6-49b0-a7c5-0826b5640a27"), "Numquam voluptatem omnis pariatur.", "Priest" },
                    { new Guid("ad877dbc-2e11-4eaf-8780-354da5049866"), "Eum eum excepturi quo minima quo necessitatibus.", "Warrior" },
                    { new Guid("b061d3b8-3a9f-4e97-9026-073e77a8797b"), "Similique facere repellat adipisci laborum exercitationem dolorem aut rerum.", "Necromancer" },
                    { new Guid("b92e7572-3e16-48ff-bd1c-ea44c6ac3bfd"), "Necessitatibus placeat suscipit velit sit autem sunt libero.", "Rogue" },
                    { new Guid("fff77fc2-ff65-4a72-ad2c-d5c6b2f38e9d"), "Quia et doloremque nemo veritatis soluta.", "Elf" }
                });

            migrationBuilder.InsertData(
                table: "characters",
                columns: new[] { "id", "base_agility", "base_faith", "base_intelligence", "base_strength", "class_id", "created_by", "health", "mana", "name" },
                values: new object[,]
                {
                    { new Guid("16cffa98-7ee4-4f43-9a84-0934040448f0"), 47, 36, 30, 24, new Guid("b92e7572-3e16-48ff-bd1c-ea44c6ac3bfd"), new Guid("00000000-0000-0000-0000-000000000000"), 1021, 174, "JeanTheDynamic Directives Coordinator" },
                    { new Guid("2b137709-4991-4225-b4f1-0ff871d14b3b"), 48, 33, 45, 21, new Guid("ad877dbc-2e11-4eaf-8780-354da5049866"), new Guid("00000000-0000-0000-0000-000000000000"), 1221, 343, "TaureanTheCorporate Web Specialist" },
                    { new Guid("88ca59a7-9250-4eb1-ad4e-8593f13c098d"), 41, 17, 24, 13, new Guid("b061d3b8-3a9f-4e97-9026-073e77a8797b"), new Guid("00000000-0000-0000-0000-000000000000"), 1256, 350, "FranciscoTheFuture Infrastructure Producer" },
                    { new Guid("c6b7ac57-164d-4b42-93e5-46fc9203e6a4"), 26, 41, 34, 49, new Guid("53be613f-fff6-49b0-a7c5-0826b5640a27"), new Guid("00000000-0000-0000-0000-000000000000"), 913, 464, "ShannyTheDynamic Marketing Supervisor" },
                    { new Guid("c7e0d399-18c0-4e31-8a56-fae75368baac"), 15, 36, 50, 24, new Guid("fff77fc2-ff65-4a72-ad2c-d5c6b2f38e9d"), new Guid("00000000-0000-0000-0000-000000000000"), 927, 203, "CarmelTheDistrict Assurance Officer" }
                });

            migrationBuilder.InsertData(
                table: "items",
                columns: new[] { "id", "bonus_agility", "bonus_faith", "bonus_intelligence", "bonus_strength", "character_id", "description", "name" },
                values: new object[,]
                {
                    { new Guid("0a4912e5-5ba0-40ee-8e81-d8b780a49923"), 28, 17, 40, 44, new Guid("16cffa98-7ee4-4f43-9a84-0934040448f0"), "Voluptas dolores porro illo sed eum error excepturi.", "soul_booster" },
                    { new Guid("25bffd38-ee4f-4814-a8e2-0131ca637fc5"), 37, 13, 35, 49, new Guid("2b137709-4991-4225-b4f1-0ff871d14b3b"), "Quam sequi eaque consectetur quisquam.", "hood_of_defiance" },
                    { new Guid("a5fa475f-69f9-454e-9e10-fcaf05a6a402"), 32, 37, 46, 33, new Guid("c7e0d399-18c0-4e31-8a56-fae75368baac"), "Veniam et deleniti labore et fugiat sed officiis.", "soul_booster" },
                    { new Guid("a671f269-edae-4469-a9cf-4654a2a697b8"), 27, 37, 35, 47, new Guid("88ca59a7-9250-4eb1-ad4e-8593f13c098d"), "Distinctio quia laboriosam nostrum ad quo.", "assault" },
                    { new Guid("ba21837b-b9e9-4bb8-b184-10544d6b9bbe"), 17, 35, 38, 33, new Guid("c6b7ac57-164d-4b42-93e5-46fc9203e6a4"), "Eveniet quis ut et aliquid ut porro sit ratione.", "sphere" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "classes",
                keyColumn: "id",
                keyValue: new Guid("07e36e47-634b-4934-aa26-fbfb8695f208"));

            migrationBuilder.DeleteData(
                table: "items",
                keyColumn: "id",
                keyValue: new Guid("0a4912e5-5ba0-40ee-8e81-d8b780a49923"));

            migrationBuilder.DeleteData(
                table: "items",
                keyColumn: "id",
                keyValue: new Guid("25bffd38-ee4f-4814-a8e2-0131ca637fc5"));

            migrationBuilder.DeleteData(
                table: "items",
                keyColumn: "id",
                keyValue: new Guid("a5fa475f-69f9-454e-9e10-fcaf05a6a402"));

            migrationBuilder.DeleteData(
                table: "items",
                keyColumn: "id",
                keyValue: new Guid("a671f269-edae-4469-a9cf-4654a2a697b8"));

            migrationBuilder.DeleteData(
                table: "items",
                keyColumn: "id",
                keyValue: new Guid("ba21837b-b9e9-4bb8-b184-10544d6b9bbe"));

            migrationBuilder.DeleteData(
                table: "characters",
                keyColumn: "id",
                keyValue: new Guid("16cffa98-7ee4-4f43-9a84-0934040448f0"));

            migrationBuilder.DeleteData(
                table: "characters",
                keyColumn: "id",
                keyValue: new Guid("2b137709-4991-4225-b4f1-0ff871d14b3b"));

            migrationBuilder.DeleteData(
                table: "characters",
                keyColumn: "id",
                keyValue: new Guid("88ca59a7-9250-4eb1-ad4e-8593f13c098d"));

            migrationBuilder.DeleteData(
                table: "characters",
                keyColumn: "id",
                keyValue: new Guid("c6b7ac57-164d-4b42-93e5-46fc9203e6a4"));

            migrationBuilder.DeleteData(
                table: "characters",
                keyColumn: "id",
                keyValue: new Guid("c7e0d399-18c0-4e31-8a56-fae75368baac"));

            migrationBuilder.DeleteData(
                table: "classes",
                keyColumn: "id",
                keyValue: new Guid("53be613f-fff6-49b0-a7c5-0826b5640a27"));

            migrationBuilder.DeleteData(
                table: "classes",
                keyColumn: "id",
                keyValue: new Guid("ad877dbc-2e11-4eaf-8780-354da5049866"));

            migrationBuilder.DeleteData(
                table: "classes",
                keyColumn: "id",
                keyValue: new Guid("b061d3b8-3a9f-4e97-9026-073e77a8797b"));

            migrationBuilder.DeleteData(
                table: "classes",
                keyColumn: "id",
                keyValue: new Guid("b92e7572-3e16-48ff-bd1c-ea44c6ac3bfd"));

            migrationBuilder.DeleteData(
                table: "classes",
                keyColumn: "id",
                keyValue: new Guid("fff77fc2-ff65-4a72-ad2c-d5c6b2f38e9d"));

            migrationBuilder.DropColumn(
                name: "xmin",
                table: "items");

            migrationBuilder.InsertData(
                table: "classes",
                columns: new[] { "id", "description", "name" },
                values: new object[,]
                {
                    { new Guid("3d30bf8c-4e53-4f47-9eef-33701e3a7b19"), "Assumenda nobis qui delectus corporis placeat laboriosam modi rerum velit.", "Warrior" },
                    { new Guid("72f3e124-ebca-45f7-9882-c9ed4eee7c06"), "Et soluta eos rerum voluptates.", "Elf" },
                    { new Guid("8cc132e6-52f0-4f16-83b5-f29e43ca3abd"), "Nisi nobis nihil et reprehenderit aut laudantium vero perspiciatis.", "Priest" },
                    { new Guid("9d0e44fd-4577-43f7-b158-1737ab1c795f"), "Aliquid consequatur in veritatis fugiat numquam ducimus neque.", "Rogue" },
                    { new Guid("b158dd00-8b10-44c4-b5f9-87e8641d3dec"), "Natus nulla eum recusandae ex id ut quo corporis id.", "Necromancer" },
                    { new Guid("c75551bc-d02c-4e82-b17d-00fa5f16fa36"), "Vel delectus commodi et accusamus accusamus vero perferendis eos et.", "Mage" }
                });

            migrationBuilder.InsertData(
                table: "characters",
                columns: new[] { "id", "base_agility", "base_faith", "base_intelligence", "base_strength", "class_id", "created_by", "health", "mana", "name" },
                values: new object[,]
                {
                    { new Guid("21f9c31a-490d-4eda-a5b7-cc237f45a889"), 17, 47, 20, 30, new Guid("b158dd00-8b10-44c4-b5f9-87e8641d3dec"), new Guid("00000000-0000-0000-0000-000000000000"), 1068, 331, "BrayanTheInternational Intranet Strategist" },
                    { new Guid("8023da36-f5dc-4314-9c56-79bcf21ca876"), 44, 30, 20, 20, new Guid("8cc132e6-52f0-4f16-83b5-f29e43ca3abd"), new Guid("00000000-0000-0000-0000-000000000000"), 1020, 130, "NedraTheChief Operations Developer" },
                    { new Guid("a86c1c30-f798-493f-9576-fa031d4e293c"), 10, 23, 45, 38, new Guid("c75551bc-d02c-4e82-b17d-00fa5f16fa36"), new Guid("00000000-0000-0000-0000-000000000000"), 1167, 124, "AlfredaTheHuman Response Developer" },
                    { new Guid("b16e8485-d109-453d-8b03-d51883a821f8"), 48, 28, 24, 45, new Guid("c75551bc-d02c-4e82-b17d-00fa5f16fa36"), new Guid("00000000-0000-0000-0000-000000000000"), 1242, 316, "NoeTheCentral Security Producer" },
                    { new Guid("f6a496af-d9da-432d-be7c-2bc0f00604fc"), 22, 17, 31, 33, new Guid("9d0e44fd-4577-43f7-b158-1737ab1c795f"), new Guid("00000000-0000-0000-0000-000000000000"), 928, 311, "BennyTheForward Brand Architect" }
                });

            migrationBuilder.InsertData(
                table: "items",
                columns: new[] { "id", "bonus_agility", "bonus_faith", "bonus_intelligence", "bonus_strength", "character_id", "description", "name" },
                values: new object[,]
                {
                    { new Guid("15afbf36-1847-44d6-b5f6-fc32f2804cdb"), 50, 39, 25, 22, new Guid("a86c1c30-f798-493f-9576-fa031d4e293c"), "Autem voluptates eum adipisci.", "soul_booster" },
                    { new Guid("2c256179-eabb-4b16-90d3-7444a8ae533e"), 10, 37, 18, 40, new Guid("b16e8485-d109-453d-8b03-d51883a821f8"), "Molestiae corrupti delectus id.", "hood_of_defiance" },
                    { new Guid("7435e0fd-a0aa-407c-9bb8-0467e0396bd3"), 38, 16, 21, 29, new Guid("8023da36-f5dc-4314-9c56-79bcf21ca876"), "Voluptatibus ratione dolor repellendus impedit debitis odio deserunt soluta.", "shivas_guard" },
                    { new Guid("75d3df17-6ff6-4dfc-8e69-dd55f314c768"), 33, 17, 47, 34, new Guid("f6a496af-d9da-432d-be7c-2bc0f00604fc"), "Repudiandae dolorem rem culpa.", "assault" },
                    { new Guid("9f4f0103-699e-48a0-8908-1a62c0438883"), 15, 42, 38, 32, new Guid("21f9c31a-490d-4eda-a5b7-cc237f45a889"), "Consectetur repellendus omnis.", "refresher" }
                });
        }
    }
}
