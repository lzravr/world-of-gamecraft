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
                            Id = new Guid("ad877dbc-2e11-4eaf-8780-354da5049866"),
                            Description = "Eum eum excepturi quo minima quo necessitatibus.",
                            Name = "Warrior"
                        },
                        new
                        {
                            Id = new Guid("b92e7572-3e16-48ff-bd1c-ea44c6ac3bfd"),
                            Description = "Necessitatibus placeat suscipit velit sit autem sunt libero.",
                            Name = "Rogue"
                        },
                        new
                        {
                            Id = new Guid("07e36e47-634b-4934-aa26-fbfb8695f208"),
                            Description = "Quas error sapiente nihil.",
                            Name = "Mage"
                        },
                        new
                        {
                            Id = new Guid("53be613f-fff6-49b0-a7c5-0826b5640a27"),
                            Description = "Numquam voluptatem omnis pariatur.",
                            Name = "Priest"
                        },
                        new
                        {
                            Id = new Guid("fff77fc2-ff65-4a72-ad2c-d5c6b2f38e9d"),
                            Description = "Quia et doloremque nemo veritatis soluta.",
                            Name = "Elf"
                        },
                        new
                        {
                            Id = new Guid("b061d3b8-3a9f-4e97-9026-073e77a8797b"),
                            Description = "Similique facere repellat adipisci laborum exercitationem dolorem aut rerum.",
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
                            Id = new Guid("c6b7ac57-164d-4b42-93e5-46fc9203e6a4"),
                            BaseAgility = 26,
                            BaseFaith = 41,
                            BaseIntelligence = 34,
                            BaseStrength = 49,
                            ClassId = new Guid("53be613f-fff6-49b0-a7c5-0826b5640a27"),
                            CreatedBy = new Guid("00000000-0000-0000-0000-000000000000"),
                            Health = 913,
                            Mana = 464,
                            Name = "ShannyTheDynamic Marketing Supervisor"
                        },
                        new
                        {
                            Id = new Guid("c7e0d399-18c0-4e31-8a56-fae75368baac"),
                            BaseAgility = 15,
                            BaseFaith = 36,
                            BaseIntelligence = 50,
                            BaseStrength = 24,
                            ClassId = new Guid("fff77fc2-ff65-4a72-ad2c-d5c6b2f38e9d"),
                            CreatedBy = new Guid("00000000-0000-0000-0000-000000000000"),
                            Health = 927,
                            Mana = 203,
                            Name = "CarmelTheDistrict Assurance Officer"
                        },
                        new
                        {
                            Id = new Guid("2b137709-4991-4225-b4f1-0ff871d14b3b"),
                            BaseAgility = 48,
                            BaseFaith = 33,
                            BaseIntelligence = 45,
                            BaseStrength = 21,
                            ClassId = new Guid("ad877dbc-2e11-4eaf-8780-354da5049866"),
                            CreatedBy = new Guid("00000000-0000-0000-0000-000000000000"),
                            Health = 1221,
                            Mana = 343,
                            Name = "TaureanTheCorporate Web Specialist"
                        },
                        new
                        {
                            Id = new Guid("16cffa98-7ee4-4f43-9a84-0934040448f0"),
                            BaseAgility = 47,
                            BaseFaith = 36,
                            BaseIntelligence = 30,
                            BaseStrength = 24,
                            ClassId = new Guid("b92e7572-3e16-48ff-bd1c-ea44c6ac3bfd"),
                            CreatedBy = new Guid("00000000-0000-0000-0000-000000000000"),
                            Health = 1021,
                            Mana = 174,
                            Name = "JeanTheDynamic Directives Coordinator"
                        },
                        new
                        {
                            Id = new Guid("88ca59a7-9250-4eb1-ad4e-8593f13c098d"),
                            BaseAgility = 41,
                            BaseFaith = 17,
                            BaseIntelligence = 24,
                            BaseStrength = 13,
                            ClassId = new Guid("b061d3b8-3a9f-4e97-9026-073e77a8797b"),
                            CreatedBy = new Guid("00000000-0000-0000-0000-000000000000"),
                            Health = 1256,
                            Mana = 350,
                            Name = "FranciscoTheFuture Infrastructure Producer"
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

                    b.Property<uint>("Version")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("xid")
                        .HasColumnName("xmin");

                    b.HasKey("Id")
                        .HasName("pk_items");

                    b.HasIndex("CharacterId")
                        .HasDatabaseName("ix_items_character_id");

                    b.ToTable("items", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("ba21837b-b9e9-4bb8-b184-10544d6b9bbe"),
                            BonusAgility = 17,
                            BonusFaith = 35,
                            BonusIntelligence = 38,
                            BonusStrength = 33,
                            CharacterId = new Guid("c6b7ac57-164d-4b42-93e5-46fc9203e6a4"),
                            Description = "Eveniet quis ut et aliquid ut porro sit ratione.",
                            Name = "sphere"
                        },
                        new
                        {
                            Id = new Guid("a5fa475f-69f9-454e-9e10-fcaf05a6a402"),
                            BonusAgility = 32,
                            BonusFaith = 37,
                            BonusIntelligence = 46,
                            BonusStrength = 33,
                            CharacterId = new Guid("c7e0d399-18c0-4e31-8a56-fae75368baac"),
                            Description = "Veniam et deleniti labore et fugiat sed officiis.",
                            Name = "soul_booster"
                        },
                        new
                        {
                            Id = new Guid("25bffd38-ee4f-4814-a8e2-0131ca637fc5"),
                            BonusAgility = 37,
                            BonusFaith = 13,
                            BonusIntelligence = 35,
                            BonusStrength = 49,
                            CharacterId = new Guid("2b137709-4991-4225-b4f1-0ff871d14b3b"),
                            Description = "Quam sequi eaque consectetur quisquam.",
                            Name = "hood_of_defiance"
                        },
                        new
                        {
                            Id = new Guid("0a4912e5-5ba0-40ee-8e81-d8b780a49923"),
                            BonusAgility = 28,
                            BonusFaith = 17,
                            BonusIntelligence = 40,
                            BonusStrength = 44,
                            CharacterId = new Guid("16cffa98-7ee4-4f43-9a84-0934040448f0"),
                            Description = "Voluptas dolores porro illo sed eum error excepturi.",
                            Name = "soul_booster"
                        },
                        new
                        {
                            Id = new Guid("a671f269-edae-4469-a9cf-4654a2a697b8"),
                            BonusAgility = 27,
                            BonusFaith = 37,
                            BonusIntelligence = 35,
                            BonusStrength = 47,
                            CharacterId = new Guid("88ca59a7-9250-4eb1-ad4e-8593f13c098d"),
                            Description = "Distinctio quia laboriosam nostrum ad quo.",
                            Name = "assault"
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
