using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

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

            migrationBuilder.CreateIndex(
                name: "ix_characters_class_id",
                table: "characters",
                column: "class_id");

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
