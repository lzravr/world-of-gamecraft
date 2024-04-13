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
                    created_by = table.Column<Guid>(type: "uuid", nullable: false),
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
                    character_id = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_items", x => x.id);
                    table.ForeignKey(
                        name: "fk_items_characters_character_id",
                        column: x => x.character_id,
                        principalTable: "characters",
                        principalColumn: "id");
                });

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
