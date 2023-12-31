﻿// <auto-generated />
using System;
using Final___Magix.DataContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Final___Magix.Migrations
{
    [DbContext(typeof(CardContext))]
    [Migration("20230830033729_PopulateListInTradeInDB")]
    partial class PopulateListInTradeInDB
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Final___Magix.Models.BulkData", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)")
                        .HasAnnotation("Relational:JsonPropertyName", "id");

                    b.Property<string>("ImageBorderCrop")
                        .HasColumnType("nvarchar(max)")
                        .HasAnnotation("Relational:JsonPropertyName", "imagebordercrop");

                    b.Property<string>("ImageLarge")
                        .HasColumnType("nvarchar(max)")
                        .HasAnnotation("Relational:JsonPropertyName", "imagelarge");

                    b.Property<string>("ImageNormal")
                        .HasColumnType("nvarchar(max)")
                        .HasAnnotation("Relational:JsonPropertyName", "imagenormal");

                    b.Property<string>("ImageSmall")
                        .HasColumnType("nvarchar(max)")
                        .HasAnnotation("Relational:JsonPropertyName", "imagesmall");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)")
                        .HasAnnotation("Relational:JsonPropertyName", "name");

                    b.Property<string>("Price")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SetCode")
                        .HasColumnType("nvarchar(max)")
                        .HasAnnotation("Relational:JsonPropertyName", "set");

                    b.Property<string>("SetName")
                        .HasColumnType("nvarchar(max)")
                        .HasAnnotation("Relational:JsonPropertyName", "set_name");

                    b.HasKey("Id");

                    b.ToTable("BulkData");
                });

            modelBuilder.Entity("Final___Magix.Models.CardModel", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Condition")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Foil")
                        .HasColumnType("bit");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<string>("Set")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TradeInModelId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TradeInModelId");

                    b.ToTable("Cards");
                });

            modelBuilder.Entity("Final___Magix.Models.Inventory", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ImageBorderCrop")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageLarge")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageNormal")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageSmall")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("StoreInventory");

                    b.HasData(
                        new
                        {
                            Id = "ed4cc273-adc3-4f46-9743-134b552d1d56",
                            ImageBorderCrop = "https://cards.scryfall.io/border_crop/front/e/d/ed4cc273-adc3-4f46-9743-134b552d1d56.jpg?1562632510",
                            ImageLarge = "https://cards.scryfall.io/large/front/e/d/ed4cc273-adc3-4f46-9743-134b552d1d56.jpg?1562632510",
                            ImageNormal = "https://cards.scryfall.io/normal/front/e/d/ed4cc273-adc3-4f46-9743-134b552d1d56.jpg?1562632510",
                            ImageSmall = "https://cards.scryfall.io/small/front/e/d/ed4cc273-adc3-4f46-9743-134b552d1d56.jpg?1562632510",
                            Name = "Balthor the Defiled",
                            Price = 11.89m,
                            Quantity = 2
                        },
                        new
                        {
                            Id = "b0244a1f-e696-4223-9c14-22c2ca3cb738",
                            ImageBorderCrop = "https://cards.scryfall.io/border_crop/front/b/0/b0244a1f-e696-4223-9c14-22c2ca3cb738.jpg?1673307696",
                            ImageLarge = "https://cards.scryfall.io/large/front/b/0/b0244a1f-e696-4223-9c14-22c2ca3cb738.jpg?1673307696",
                            ImageNormal = "https://cards.scryfall.io/normal/front/b/0/b0244a1f-e696-4223-9c14-22c2ca3cb738.jpg?1673307696",
                            ImageSmall = "https://cards.scryfall.io/small/front/b/0/b0244a1f-e696-4223-9c14-22c2ca3cb738.jpg?1673307696",
                            Name = "Herd Migration",
                            Price = 0.10m,
                            Quantity = 18
                        },
                        new
                        {
                            Id = "7bd0e025-7a75-4641-a51a-27df9dcde05f",
                            ImageBorderCrop = "https://cards.scryfall.io/border_crop/front/7/b/7bd0e025-7a75-4641-a51a-27df9dcde05f.jpg?1604264359",
                            ImageLarge = "https://cards.scryfall.io/large/front/7/b/7bd0e025-7a75-4641-a51a-27df9dcde05f.jpg?1604264359",
                            ImageNormal = "https://cards.scryfall.io/normal/front/7/b/7bd0e025-7a75-4641-a51a-27df9dcde05f.jpg?1604264359",
                            ImageSmall = "https://cards.scryfall.io/small/front/7/b/7bd0e025-7a75-4641-a51a-27df9dcde05f.jpg?1604264359",
                            Name = "Crawling Barrens",
                            Price = 0.18m,
                            Quantity = 4
                        },
                        new
                        {
                            Id = "655c489f-bffb-45a4-8e7c-2d1a35220194",
                            ImageBorderCrop = "https://cards.scryfall.io/border_crop/front/6/5/655c489f-bffb-45a4-8e7c-2d1a35220197.jpg?1562023107",
                            ImageLarge = "https://cards.scryfall.io/large/front/6/5/655c489f-bffb-45a4-8e7c-2d1a35220197.jpg?1562023107",
                            ImageNormal = "https://cards.scryfall.io/normal/front/6/5/655c489f-bffb-45a4-8e7c-2d1a35220197.jpg?1562023107",
                            ImageSmall = "https://cards.scryfall.io/small/front/6/5/655c489f-bffb-45a4-8e7c-2d1a35220197.jpg?1562023107",
                            Name = "Smash to Smithereens",
                            Price = 0.22m,
                            Quantity = 10
                        },
                        new
                        {
                            Id = "e6246cf3-76bd-476b-9cd9-789b6ad48887",
                            ImageBorderCrop = "https://cards.scryfall.io/border_crop/front/e/6/e6246cf3-76bd-476b-9cd9-789b6ad48887.jpg?1562626991",
                            ImageLarge = "https://cards.scryfall.io/large/front/e/6/e6246cf3-76bd-476b-9cd9-789b6ad48887.jpg?1562626991",
                            ImageNormal = "https://cards.scryfall.io/normal/front/e/6/e6246cf3-76bd-476b-9cd9-789b6ad48887.jpg?1562626991",
                            ImageSmall = "https://cards.scryfall.io/small/front/e/6/e6246cf3-76bd-476b-9cd9-789b6ad48887.jpg?1562626991",
                            Name = "Kheru Mind-Eater",
                            Price = 0.91m,
                            Quantity = 2
                        },
                        new
                        {
                            Id = "bf42524c-97e5-40b2-8a6d-d2a1f0a9eb65",
                            ImageBorderCrop = "https://cards.scryfall.io/border_crop/front/b/f/bf42524c-97e5-40b2-8a6d-d2a1f0a9eb65.jpg?1618940501",
                            ImageLarge = "https://cards.scryfall.io/large/front/b/f/bf42524c-97e5-40b2-8a6d-d2a1f0a9eb65.jpg?1618940501",
                            ImageNormal = "https://cards.scryfall.io/normal/front/b/f/bf42524c-97e5-40b2-8a6d-d2a1f0a9eb65.jpg?1618940501",
                            ImageSmall = "https://cards.scryfall.io/small/front/b/f/bf42524c-97e5-40b2-8a6d-d2a1f0a9eb65.jpg?1618940501",
                            Name = "Keldon Marauders",
                            Price = 0.09m,
                            Quantity = 20
                        },
                        new
                        {
                            Id = "0e0fa5ab-c4d1-4b2d-ad62-feb651e4b11c",
                            ImageBorderCrop = "https://cards.scryfall.io/border_crop/front/0/e/0e0fa5ab-c4d1-4b2d-ad62-feb651e4b11c.jpg?1591320182",
                            ImageLarge = "https://cards.scryfall.io/large/front/0/e/0e0fa5ab-c4d1-4b2d-ad62-feb651e4b11c.jpg?1591320182",
                            ImageNormal = "https://cards.scryfall.io/normal/front/0/e/0e0fa5ab-c4d1-4b2d-ad62-feb651e4b11c.jpg?1591320182",
                            ImageSmall = "https://cards.scryfall.io/small/front/0/e/0e0fa5ab-c4d1-4b2d-ad62-feb651e4b11c.jpg?1591320182",
                            Name = "Thraben Doomsayer",
                            Price = 0.19m,
                            Quantity = 10
                        },
                        new
                        {
                            Id = "033afbd5-9937-4957-98ba-48e469a490bb",
                            ImageBorderCrop = "https://cards.scryfall.io/border_crop/front/0/3/033afbd5-9937-4957-98ba-48e469a490bb.jpg?1594735579",
                            ImageLarge = "https://cards.scryfall.io/large/front/0/3/033afbd5-9937-4957-98ba-48e469a490bb.jpg?1594735579",
                            ImageNormal = "https://cards.scryfall.io/normal/front/0/3/033afbd5-9937-4957-98ba-48e469a490bb.jpg?1594735579",
                            ImageSmall = "https://cards.scryfall.io/small/front/0/3/033afbd5-9937-4957-98ba-48e469a490bb.jpg?1594735579",
                            Name = "Miscast",
                            Price = 1.19m,
                            Quantity = 2
                        },
                        new
                        {
                            Id = "374b5d57-fd20-4062-9ec2-24ac557d9dde",
                            ImageBorderCrop = "https://cards.scryfall.io/border_crop/front/3/7/374b5d57-fd20-4062-9ec2-24ac557d9dde.jpg?1604195020",
                            ImageLarge = "https://cards.scryfall.io/large/front/3/7/374b5d57-fd20-4062-9ec2-24ac557d9dde.jpg?1604195020",
                            ImageNormal = "https://cards.scryfall.io/normal/front/3/7/374b5d57-fd20-4062-9ec2-24ac557d9dde.jpg?1604195020",
                            ImageSmall = "https://cards.scryfall.io/small/front/3/7/374b5d57-fd20-4062-9ec2-24ac557d9dde.jpg?1604195020",
                            Name = "Mina and Denn, Wildborn",
                            Price = 0.58m,
                            Quantity = 4
                        });
                });

            modelBuilder.Entity("Final___Magix.Models.TradeInModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.HasKey("Id");

                    b.ToTable("TradeIns");
                });

            modelBuilder.Entity("Final___Magix.Models.CardModel", b =>
                {
                    b.HasOne("Final___Magix.Models.TradeInModel", null)
                        .WithMany("Cards")
                        .HasForeignKey("TradeInModelId");
                });

            modelBuilder.Entity("Final___Magix.Models.TradeInModel", b =>
                {
                    b.Navigation("Cards");
                });
#pragma warning restore 612, 618
        }
    }
}
