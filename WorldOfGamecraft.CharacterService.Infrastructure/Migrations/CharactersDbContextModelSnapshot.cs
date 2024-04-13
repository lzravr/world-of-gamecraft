﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using WorldOfGamecraft.CharacterService.Infrastructure;

#nullable disable

namespace WorldOfGamecraft.CharacterService.Infrastructure.Migrations
{
    [DbContext(typeof(CharactersDbContext))]
    partial class CharactersDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("WorldOfGamecraft.CharacterService.Domain.CharacterClasses.Class", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("description");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.HasKey("Id")
                        .HasName("pk_classes");

                    b.HasIndex("Name")
                        .IsUnique()
                        .HasDatabaseName("ix_classes_name");

                    b.ToTable("classes", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("3d30bf8c-4e53-4f47-9eef-33701e3a7b19"),
                            Description = "Assumenda nobis qui delectus corporis placeat laboriosam modi rerum velit.",
                            Name = "Warrior"
                        },
                        new
                        {
                            Id = new Guid("9d0e44fd-4577-43f7-b158-1737ab1c795f"),
                            Description = "Aliquid consequatur in veritatis fugiat numquam ducimus neque.",
                            Name = "Rogue"
                        },
                        new
                        {
                            Id = new Guid("c75551bc-d02c-4e82-b17d-00fa5f16fa36"),
                            Description = "Vel delectus commodi et accusamus accusamus vero perferendis eos et.",
                            Name = "Mage"
                        },
                        new
                        {
                            Id = new Guid("8cc132e6-52f0-4f16-83b5-f29e43ca3abd"),
                            Description = "Nisi nobis nihil et reprehenderit aut laudantium vero perspiciatis.",
                            Name = "Priest"
                        },
                        new
                        {
                            Id = new Guid("72f3e124-ebca-45f7-9882-c9ed4eee7c06"),
                            Description = "Et soluta eos rerum voluptates.",
                            Name = "Elf"
                        },
                        new
                        {
                            Id = new Guid("b158dd00-8b10-44c4-b5f9-87e8641d3dec"),
                            Description = "Natus nulla eum recusandae ex id ut quo corporis id.",
                            Name = "Necromancer"
                        });
                });

            modelBuilder.Entity("WorldOfGamecraft.CharacterService.Domain.Characters.Character", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<int>("BaseAgility")
                        .HasColumnType("integer")
                        .HasColumnName("base_agility");

                    b.Property<int>("BaseFaith")
                        .HasColumnType("integer")
                        .HasColumnName("base_faith");

                    b.Property<int>("BaseIntelligence")
                        .HasColumnType("integer")
                        .HasColumnName("base_intelligence");

                    b.Property<int>("BaseStrength")
                        .HasColumnType("integer")
                        .HasColumnName("base_strength");

                    b.Property<Guid>("ClassId")
                        .HasColumnType("uuid")
                        .HasColumnName("class_id");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uuid")
                        .HasColumnName("created_by");

                    b.Property<int>("Health")
                        .HasColumnType("integer")
                        .HasColumnName("health");

                    b.Property<int>("Mana")
                        .HasColumnType("integer")
                        .HasColumnName("mana");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.HasKey("Id")
                        .HasName("pk_characters");

                    b.HasIndex("ClassId")
                        .HasDatabaseName("ix_characters_class_id");

                    b.HasIndex("Name")
                        .IsUnique()
                        .HasDatabaseName("ix_characters_name");

                    b.ToTable("characters", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("f6a496af-d9da-432d-be7c-2bc0f00604fc"),
                            BaseAgility = 22,
                            BaseFaith = 17,
                            BaseIntelligence = 31,
                            BaseStrength = 33,
                            ClassId = new Guid("9d0e44fd-4577-43f7-b158-1737ab1c795f"),
                            CreatedBy = new Guid("00000000-0000-0000-0000-000000000000"),
                            Health = 928,
                            Mana = 311,
                            Name = "BennyTheForward Brand Architect"
                        },
                        new
                        {
                            Id = new Guid("8023da36-f5dc-4314-9c56-79bcf21ca876"),
                            BaseAgility = 44,
                            BaseFaith = 30,
                            BaseIntelligence = 20,
                            BaseStrength = 20,
                            ClassId = new Guid("8cc132e6-52f0-4f16-83b5-f29e43ca3abd"),
                            CreatedBy = new Guid("00000000-0000-0000-0000-000000000000"),
                            Health = 1020,
                            Mana = 130,
                            Name = "NedraTheChief Operations Developer"
                        },
                        new
                        {
                            Id = new Guid("b16e8485-d109-453d-8b03-d51883a821f8"),
                            BaseAgility = 48,
                            BaseFaith = 28,
                            BaseIntelligence = 24,
                            BaseStrength = 45,
                            ClassId = new Guid("c75551bc-d02c-4e82-b17d-00fa5f16fa36"),
                            CreatedBy = new Guid("00000000-0000-0000-0000-000000000000"),
                            Health = 1242,
                            Mana = 316,
                            Name = "NoeTheCentral Security Producer"
                        },
                        new
                        {
                            Id = new Guid("21f9c31a-490d-4eda-a5b7-cc237f45a889"),
                            BaseAgility = 17,
                            BaseFaith = 47,
                            BaseIntelligence = 20,
                            BaseStrength = 30,
                            ClassId = new Guid("b158dd00-8b10-44c4-b5f9-87e8641d3dec"),
                            CreatedBy = new Guid("00000000-0000-0000-0000-000000000000"),
                            Health = 1068,
                            Mana = 331,
                            Name = "BrayanTheInternational Intranet Strategist"
                        },
                        new
                        {
                            Id = new Guid("a86c1c30-f798-493f-9576-fa031d4e293c"),
                            BaseAgility = 10,
                            BaseFaith = 23,
                            BaseIntelligence = 45,
                            BaseStrength = 38,
                            ClassId = new Guid("c75551bc-d02c-4e82-b17d-00fa5f16fa36"),
                            CreatedBy = new Guid("00000000-0000-0000-0000-000000000000"),
                            Health = 1167,
                            Mana = 124,
                            Name = "AlfredaTheHuman Response Developer"
                        });
                });

            modelBuilder.Entity("WorldOfGamecraft.CharacterService.Domain.Items.Item", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<int>("BonusAgility")
                        .HasColumnType("integer")
                        .HasColumnName("bonus_agility");

                    b.Property<int>("BonusFaith")
                        .HasColumnType("integer")
                        .HasColumnName("bonus_faith");

                    b.Property<int>("BonusIntelligence")
                        .HasColumnType("integer")
                        .HasColumnName("bonus_intelligence");

                    b.Property<int>("BonusStrength")
                        .HasColumnType("integer")
                        .HasColumnName("bonus_strength");

                    b.Property<Guid?>("CharacterId")
                        .HasColumnType("uuid")
                        .HasColumnName("character_id");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("description");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.HasKey("Id")
                        .HasName("pk_items");

                    b.HasIndex("CharacterId")
                        .HasDatabaseName("ix_items_character_id");

                    b.ToTable("items", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("75d3df17-6ff6-4dfc-8e69-dd55f314c768"),
                            BonusAgility = 33,
                            BonusFaith = 17,
                            BonusIntelligence = 47,
                            BonusStrength = 34,
                            CharacterId = new Guid("f6a496af-d9da-432d-be7c-2bc0f00604fc"),
                            Description = "Repudiandae dolorem rem culpa.",
                            Name = "assault"
                        },
                        new
                        {
                            Id = new Guid("7435e0fd-a0aa-407c-9bb8-0467e0396bd3"),
                            BonusAgility = 38,
                            BonusFaith = 16,
                            BonusIntelligence = 21,
                            BonusStrength = 29,
                            CharacterId = new Guid("8023da36-f5dc-4314-9c56-79bcf21ca876"),
                            Description = "Voluptatibus ratione dolor repellendus impedit debitis odio deserunt soluta.",
                            Name = "shivas_guard"
                        },
                        new
                        {
                            Id = new Guid("2c256179-eabb-4b16-90d3-7444a8ae533e"),
                            BonusAgility = 10,
                            BonusFaith = 37,
                            BonusIntelligence = 18,
                            BonusStrength = 40,
                            CharacterId = new Guid("b16e8485-d109-453d-8b03-d51883a821f8"),
                            Description = "Molestiae corrupti delectus id.",
                            Name = "hood_of_defiance"
                        },
                        new
                        {
                            Id = new Guid("9f4f0103-699e-48a0-8908-1a62c0438883"),
                            BonusAgility = 15,
                            BonusFaith = 42,
                            BonusIntelligence = 38,
                            BonusStrength = 32,
                            CharacterId = new Guid("21f9c31a-490d-4eda-a5b7-cc237f45a889"),
                            Description = "Consectetur repellendus omnis.",
                            Name = "refresher"
                        },
                        new
                        {
                            Id = new Guid("15afbf36-1847-44d6-b5f6-fc32f2804cdb"),
                            BonusAgility = 50,
                            BonusFaith = 39,
                            BonusIntelligence = 25,
                            BonusStrength = 22,
                            CharacterId = new Guid("a86c1c30-f798-493f-9576-fa031d4e293c"),
                            Description = "Autem voluptates eum adipisci.",
                            Name = "soul_booster"
                        });
                });

            modelBuilder.Entity("WorldOfGamecraft.CharacterService.Domain.Characters.Character", b =>
                {
                    b.HasOne("WorldOfGamecraft.CharacterService.Domain.CharacterClasses.Class", "Class")
                        .WithMany("Characters")
                        .HasForeignKey("ClassId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_characters_classes_class_id");

                    b.Navigation("Class");
                });

            modelBuilder.Entity("WorldOfGamecraft.CharacterService.Domain.Items.Item", b =>
                {
                    b.HasOne("WorldOfGamecraft.CharacterService.Domain.Characters.Character", null)
                        .WithMany("Items")
                        .HasForeignKey("CharacterId")
                        .HasConstraintName("fk_items_characters_character_id");
                });

            modelBuilder.Entity("WorldOfGamecraft.CharacterService.Domain.CharacterClasses.Class", b =>
                {
                    b.Navigation("Characters");
                });

            modelBuilder.Entity("WorldOfGamecraft.CharacterService.Domain.Characters.Character", b =>
                {
                    b.Navigation("Items");
                });
#pragma warning restore 612, 618
        }
    }
}
