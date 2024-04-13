using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WorldOfGamecraft.CharacterService.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "classes",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    name = table.Column<string>(type: "text", nullable: false),
                    description = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_classes", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "characters",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    name = table.Column<string>(type: "text", nullable: false),
                    health = table.Column<int>(type: "integer", nullable: false),
                    mana = table.Column<int>(type: "integer", nullable: false),
                    base_strength = table.Column<int>(type: "integer", nullable: false),
                    base_agility = table.Column<int>(type: "integer", nullable: false),
                    base_intelligence = table.Column<int>(type: "integer", nullable: false),
                    base_faith = table.Column<int>(type: "integer", nullable: false),
                    class_id = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_characters", x => x.id);
                    table.ForeignKey(
                        name: "fk_characters_classes_class_id",
                        column: x => x.class_id,
                        principalTable: "classes",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "items",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    name = table.Column<string>(type: "text", nullable: false),
                    description = table.Column<string>(type: "text", nullable: false),
                    bonus_strength = table.Column<int>(type: "integer", nullable: false),
                    bonus_agility = table.Column<int>(type: "integer", nullable: false),
                    bonus_intelligence = table.Column<int>(type: "integer", nullable: false),
                    bonus_faith = table.Column<int>(type: "integer", nullable: false),
                    character_id = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_items", x => x.id);
                    table.ForeignKey(
                        name: "fk_items_characters_character_id",
                        column: x => x.character_id,
                        principalTable: "characters",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "ix_characters_class_id",
                table: "characters",
                column: "class_id");

            migrationBuilder.CreateIndex(
                name: "ix_characters_name",
                table: "characters",
                column: "name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "ix_classes_name",
                table: "classes",
                column: "name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "ix_items_character_id",
                table: "items",
                column: "character_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "items");

            migrationBuilder.DropTable(
                name: "characters");

            migrationBuilder.DropTable(
                name: "classes");
        }
    }
}
