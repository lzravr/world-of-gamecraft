using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WorldOfGamecraft.CharacterService.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddedCreatedByColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "classes",
                keyColumn: "id",
                keyValue: new Guid("ee252b1b-3539-48b2-b792-b8da3042839f"));

            migrationBuilder.DeleteData(
                table: "items",
                keyColumn: "id",
                keyValue: new Guid("0ef4f863-23cc-444a-91cf-9ba65c54138a"));

            migrationBuilder.DeleteData(
                table: "items",
                keyColumn: "id",
                keyValue: new Guid("9d7ea528-4e31-47f7-83d0-44bc93ae6727"));

            migrationBuilder.DeleteData(
                table: "items",
                keyColumn: "id",
                keyValue: new Guid("9f1482b0-2177-4adb-a536-65f5664fd99c"));

            migrationBuilder.DeleteData(
                table: "items",
                keyColumn: "id",
                keyValue: new Guid("e21235bc-261a-4780-b54e-0a774be5f5bb"));

            migrationBuilder.DeleteData(
                table: "items",
                keyColumn: "id",
                keyValue: new Guid("eecb8993-8477-4adb-893c-6b5fd1f1f69a"));

            migrationBuilder.DeleteData(
                table: "characters",
                keyColumn: "id",
                keyValue: new Guid("00bd5ca7-efa2-4937-baae-232f5f5c4929"));

            migrationBuilder.DeleteData(
                table: "characters",
                keyColumn: "id",
                keyValue: new Guid("1cabccc7-0242-4c8d-bd8e-b39c388be554"));

            migrationBuilder.DeleteData(
                table: "characters",
                keyColumn: "id",
                keyValue: new Guid("2a388228-c79d-4194-bbea-c1d43e83559f"));

            migrationBuilder.DeleteData(
                table: "characters",
                keyColumn: "id",
                keyValue: new Guid("abac6546-b5dd-4722-bd15-edbd7582f58f"));

            migrationBuilder.DeleteData(
                table: "characters",
                keyColumn: "id",
                keyValue: new Guid("ae9c7d2e-1c09-4a66-9516-a15dc28f1a6e"));

            migrationBuilder.DeleteData(
                table: "classes",
                keyColumn: "id",
                keyValue: new Guid("1309b85f-e0bc-4754-abd8-8b11e13b61ac"));

            migrationBuilder.DeleteData(
                table: "classes",
                keyColumn: "id",
                keyValue: new Guid("27847584-1797-484f-a31b-fc1011eebb09"));

            migrationBuilder.DeleteData(
                table: "classes",
                keyColumn: "id",
                keyValue: new Guid("5332f2f4-5116-42eb-9d1a-c6b395ac3818"));

            migrationBuilder.DeleteData(
                table: "classes",
                keyColumn: "id",
                keyValue: new Guid("53f96b8f-be67-4890-ac5b-f82867612726"));

            migrationBuilder.DeleteData(
                table: "classes",
                keyColumn: "id",
                keyValue: new Guid("f0925ea0-3ac6-4458-8dce-aea903a23333"));

            migrationBuilder.AddColumn<Guid>(
                name: "created_by",
                table: "characters",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.InsertData(
                table: "classes",
                columns: new[] { "id", "description", "name" },
                values: new object[,]
                {
                    { new Guid("15dc6b97-75ec-494f-8626-95ee15179df8"), "Fugiat quia voluptas dolorum dignissimos.", "Elf" },
                    { new Guid("83454a3b-ada5-4580-8ec8-aac5ec1e6a8e"), "Ea exercitationem dolore alias in a commodi.", "Rogue" },
                    { new Guid("89ecac8e-a182-4d0c-a428-5e95367f7a77"), "Est et amet aut illum nisi.", "Warrior" },
                    { new Guid("8f15218c-eb7a-44b0-9580-e610ff6f6ca1"), "Ullam ut in molestias deleniti ut a.", "Priest" },
                    { new Guid("9547a77e-6af5-47a1-a294-ed29e99f554a"), "Earum molestiae cupiditate.", "Mage" },
                    { new Guid("e828e22e-9e02-467d-8daf-9c21881bce09"), "Aspernatur labore soluta sunt voluptate modi sunt voluptates qui praesentium.", "Necromancer" }
                });

            migrationBuilder.InsertData(
                table: "characters",
                columns: new[] { "id", "base_agility", "base_faith", "base_intelligence", "base_strength", "class_id", "created_by", "health", "mana", "name" },
                values: new object[,]
                {
                    { new Guid("308dc115-c571-4646-b044-51288e30886e"), 27, 33, 31, 15, new Guid("15dc6b97-75ec-494f-8626-95ee15179df8"), new Guid("00000000-0000-0000-0000-000000000000"), 813, 250, "RashadTheInternal Intranet Representative" },
                    { new Guid("42c8ee48-5939-48cb-82cd-d53fb02d5167"), 39, 47, 36, 17, new Guid("15dc6b97-75ec-494f-8626-95ee15179df8"), new Guid("00000000-0000-0000-0000-000000000000"), 917, 240, "LeeTheSenior Configuration Director" },
                    { new Guid("7bf3c011-f32b-4d1e-af4e-148ea55812ee"), 42, 50, 47, 39, new Guid("e828e22e-9e02-467d-8daf-9c21881bce09"), new Guid("00000000-0000-0000-0000-000000000000"), 863, 365, "AdamTheHuman Solutions Planner" },
                    { new Guid("808603ad-738a-4fa0-83c5-299456c77ba7"), 29, 36, 21, 47, new Guid("8f15218c-eb7a-44b0-9580-e610ff6f6ca1"), new Guid("00000000-0000-0000-0000-000000000000"), 1057, 167, "AdonisTheInternational Division Designer" },
                    { new Guid("aa1646cf-6605-4a78-bc60-26a3011a71fe"), 38, 33, 24, 50, new Guid("9547a77e-6af5-47a1-a294-ed29e99f554a"), new Guid("00000000-0000-0000-0000-000000000000"), 1283, 496, "GiuseppeTheFuture Paradigm Strategist" }
                });

            migrationBuilder.InsertData(
                table: "items",
                columns: new[] { "id", "bonus_agility", "bonus_faith", "bonus_intelligence", "bonus_strength", "character_id", "description", "name" },
                values: new object[,]
                {
                    { new Guid("1574d992-e2ec-4adb-8d4a-3a63628b77fd"), 40, 20, 32, 31, new Guid("7bf3c011-f32b-4d1e-af4e-148ea55812ee"), "Atque quos expedita omnis voluptatum quos odit sed quae modi.", "refresher" },
                    { new Guid("2625112f-fd45-4bd5-a6d0-a03951ea72ef"), 37, 46, 33, 11, new Guid("aa1646cf-6605-4a78-bc60-26a3011a71fe"), "Commodi nobis quia molestiae recusandae quis dolor.", "radiance" },
                    { new Guid("946efaa8-55ac-4f23-b49b-071148cb7bde"), 24, 13, 45, 22, new Guid("42c8ee48-5939-48cb-82cd-d53fb02d5167"), "Facere expedita ipsum consequuntur dolor laborum veritatis.", "orchid" },
                    { new Guid("b2102983-3437-429c-aa7a-0aab66eefdf5"), 21, 21, 37, 12, new Guid("808603ad-738a-4fa0-83c5-299456c77ba7"), "Et cum placeat eum sit sint molestias voluptas.", "heart" },
                    { new Guid("dacdc435-9c15-44f5-af27-8f744ee4acde"), 49, 35, 28, 21, new Guid("308dc115-c571-4646-b044-51288e30886e"), "Voluptatibus aut inventore et beatae ut dolorum earum beatae hic.", "monkey_king_bar" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "classes",
                keyColumn: "id",
                keyValue: new Guid("83454a3b-ada5-4580-8ec8-aac5ec1e6a8e"));

            migrationBuilder.DeleteData(
                table: "classes",
                keyColumn: "id",
                keyValue: new Guid("89ecac8e-a182-4d0c-a428-5e95367f7a77"));

            migrationBuilder.DeleteData(
                table: "items",
                keyColumn: "id",
                keyValue: new Guid("1574d992-e2ec-4adb-8d4a-3a63628b77fd"));

            migrationBuilder.DeleteData(
                table: "items",
                keyColumn: "id",
                keyValue: new Guid("2625112f-fd45-4bd5-a6d0-a03951ea72ef"));

            migrationBuilder.DeleteData(
                table: "items",
                keyColumn: "id",
                keyValue: new Guid("946efaa8-55ac-4f23-b49b-071148cb7bde"));

            migrationBuilder.DeleteData(
                table: "items",
                keyColumn: "id",
                keyValue: new Guid("b2102983-3437-429c-aa7a-0aab66eefdf5"));

            migrationBuilder.DeleteData(
                table: "items",
                keyColumn: "id",
                keyValue: new Guid("dacdc435-9c15-44f5-af27-8f744ee4acde"));

            migrationBuilder.DeleteData(
                table: "characters",
                keyColumn: "id",
                keyValue: new Guid("308dc115-c571-4646-b044-51288e30886e"));

            migrationBuilder.DeleteData(
                table: "characters",
                keyColumn: "id",
                keyValue: new Guid("42c8ee48-5939-48cb-82cd-d53fb02d5167"));

            migrationBuilder.DeleteData(
                table: "characters",
                keyColumn: "id",
                keyValue: new Guid("7bf3c011-f32b-4d1e-af4e-148ea55812ee"));

            migrationBuilder.DeleteData(
                table: "characters",
                keyColumn: "id",
                keyValue: new Guid("808603ad-738a-4fa0-83c5-299456c77ba7"));

            migrationBuilder.DeleteData(
                table: "characters",
                keyColumn: "id",
                keyValue: new Guid("aa1646cf-6605-4a78-bc60-26a3011a71fe"));

            migrationBuilder.DeleteData(
                table: "classes",
                keyColumn: "id",
                keyValue: new Guid("15dc6b97-75ec-494f-8626-95ee15179df8"));

            migrationBuilder.DeleteData(
                table: "classes",
                keyColumn: "id",
                keyValue: new Guid("8f15218c-eb7a-44b0-9580-e610ff6f6ca1"));

            migrationBuilder.DeleteData(
                table: "classes",
                keyColumn: "id",
                keyValue: new Guid("9547a77e-6af5-47a1-a294-ed29e99f554a"));

            migrationBuilder.DeleteData(
                table: "classes",
                keyColumn: "id",
                keyValue: new Guid("e828e22e-9e02-467d-8daf-9c21881bce09"));

            migrationBuilder.DropColumn(
                name: "created_by",
                table: "characters");

            migrationBuilder.InsertData(
                table: "classes",
                columns: new[] { "id", "description", "name" },
                values: new object[,]
                {
                    { new Guid("1309b85f-e0bc-4754-abd8-8b11e13b61ac"), "Cumque mollitia rerum necessitatibus quasi facere tempora.", "Rogue" },
                    { new Guid("27847584-1797-484f-a31b-fc1011eebb09"), "Id dolorem recusandae commodi commodi voluptatibus totam.", "Warrior" },
                    { new Guid("5332f2f4-5116-42eb-9d1a-c6b395ac3818"), "Vero eveniet alias ipsum qui et eveniet qui qui sapiente.", "Elf" },
                    { new Guid("53f96b8f-be67-4890-ac5b-f82867612726"), "Beatae omnis sint aspernatur quia ipsum deleniti ad magni.", "Mage" },
                    { new Guid("ee252b1b-3539-48b2-b792-b8da3042839f"), "Dolore eos rerum vel dolorum soluta dolorem ea cum suscipit.", "Priest" },
                    { new Guid("f0925ea0-3ac6-4458-8dce-aea903a23333"), "Nobis perferendis ea pariatur.", "Necromancer" }
                });

            migrationBuilder.InsertData(
                table: "characters",
                columns: new[] { "id", "base_agility", "base_faith", "base_intelligence", "base_strength", "class_id", "health", "mana", "name" },
                values: new object[,]
                {
                    { new Guid("00bd5ca7-efa2-4937-baae-232f5f5c4929"), 21, 43, 28, 21, new Guid("53f96b8f-be67-4890-ac5b-f82867612726"), 1118, 336, "CarterTheNational Program Planner" },
                    { new Guid("1cabccc7-0242-4c8d-bd8e-b39c388be554"), 17, 31, 26, 29, new Guid("1309b85f-e0bc-4754-abd8-8b11e13b61ac"), 802, 102, "KayleeTheCorporate Paradigm Coordinator" },
                    { new Guid("2a388228-c79d-4194-bbea-c1d43e83559f"), 26, 17, 11, 17, new Guid("27847584-1797-484f-a31b-fc1011eebb09"), 1211, 349, "DorisTheDynamic Factors Planner" },
                    { new Guid("abac6546-b5dd-4722-bd15-edbd7582f58f"), 28, 24, 29, 24, new Guid("f0925ea0-3ac6-4458-8dce-aea903a23333"), 1160, 171, "JeffTheChief Interactions Manager" },
                    { new Guid("ae9c7d2e-1c09-4a66-9516-a15dc28f1a6e"), 33, 21, 42, 13, new Guid("5332f2f4-5116-42eb-9d1a-c6b395ac3818"), 810, 251, "MoisesTheInternational Security Consultant" }
                });

            migrationBuilder.InsertData(
                table: "items",
                columns: new[] { "id", "bonus_agility", "bonus_faith", "bonus_intelligence", "bonus_strength", "character_id", "description", "name" },
                values: new object[,]
                {
                    { new Guid("0ef4f863-23cc-444a-91cf-9ba65c54138a"), 31, 19, 29, 17, new Guid("2a388228-c79d-4194-bbea-c1d43e83559f"), "Eum neque eaque expedita provident eaque.", "orchid" },
                    { new Guid("9d7ea528-4e31-47f7-83d0-44bc93ae6727"), 11, 40, 21, 40, new Guid("1cabccc7-0242-4c8d-bd8e-b39c388be554"), "Aliquid maiores voluptate minima dignissimos qui ut sit vel.", "dagon" },
                    { new Guid("9f1482b0-2177-4adb-a536-65f5664fd99c"), 33, 37, 49, 31, new Guid("abac6546-b5dd-4722-bd15-edbd7582f58f"), "Voluptatibus sapiente temporibus occaecati.", "black_king_bar" },
                    { new Guid("e21235bc-261a-4780-b54e-0a774be5f5bb"), 14, 29, 50, 42, new Guid("ae9c7d2e-1c09-4a66-9516-a15dc28f1a6e"), "Totam necessitatibus illo qui.", "monkey_king_bar" },
                    { new Guid("eecb8993-8477-4adb-893c-6b5fd1f1f69a"), 27, 39, 26, 23, new Guid("00bd5ca7-efa2-4937-baae-232f5f5c4929"), "Molestiae ratione et odit necessitatibus accusantium.", "force_staff" }
                });
        }
    }
}
