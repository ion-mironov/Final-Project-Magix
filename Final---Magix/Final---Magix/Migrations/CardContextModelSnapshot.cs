﻿// <auto-generated />
using System;
using Final___Magix.DataContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Final___Magix.Migrations
{
    [DbContext(typeof(CardContext))]
    partial class CardContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

                    b.Property<string>("PriceId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("PriceId");

                    b.ToTable("BulkData");
                });

            modelBuilder.Entity("Final___Magix.Models.CardModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

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

                    b.Property<string>("Print")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

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

                    b.Property<string>("PriceId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int?>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PriceId");

                    b.ToTable("StoreInventory");

                    b.HasData(
                        new
                        {
                            Id = "655c489f-bffb-45a4-8e7c-2d1a35220197",
                            ImageBorderCrop = "https://cards.scryfall.io/border_crop/front/6/5/655c489f-bffb-45a4-8e7c-2d1a35220197.jpg?1562023107",
                            ImageLarge = "https://cards.scryfall.io/large/front/6/5/655c489f-bffb-45a4-8e7c-2d1a35220197.jpg?1562023107",
                            ImageNormal = "https://cards.scryfall.io/normal/front/6/5/655c489f-bffb-45a4-8e7c-2d1a35220197.jpg?1562023107",
                            ImageSmall = "https://cards.scryfall.io/small/front/6/5/655c489f-bffb-45a4-8e7c-2d1a35220197.jpg?1562023107",
                            Name = "Smash to Smithereens",
                            Quantity = 10
                        },
                        new
                        {
                            Id = "655c489f-bffb-45a4-8e7c-2d1a35220196",
                            ImageBorderCrop = "https://cards.scryfall.io/border_crop/front/6/5/655c489f-bffb-45a4-8e7c-2d1a35220197.jpg?1562023107",
                            ImageLarge = "https://cards.scryfall.io/large/front/6/5/655c489f-bffb-45a4-8e7c-2d1a35220197.jpg?1562023107",
                            ImageNormal = "https://cards.scryfall.io/normal/front/6/5/655c489f-bffb-45a4-8e7c-2d1a35220197.jpg?1562023107",
                            ImageSmall = "https://cards.scryfall.io/small/front/6/5/655c489f-bffb-45a4-8e7c-2d1a35220197.jpg?1562023107",
                            Name = "Smash to Smithereens",
                            Quantity = 10
                        },
                        new
                        {
                            Id = "655c489f-bffb-45a4-8e7c-2d1a35220195",
                            ImageBorderCrop = "https://cards.scryfall.io/border_crop/front/6/5/655c489f-bffb-45a4-8e7c-2d1a35220197.jpg?1562023107",
                            ImageLarge = "https://cards.scryfall.io/large/front/6/5/655c489f-bffb-45a4-8e7c-2d1a35220197.jpg?1562023107",
                            ImageNormal = "https://cards.scryfall.io/normal/front/6/5/655c489f-bffb-45a4-8e7c-2d1a35220197.jpg?1562023107",
                            ImageSmall = "https://cards.scryfall.io/small/front/6/5/655c489f-bffb-45a4-8e7c-2d1a35220197.jpg?1562023107",
                            Name = "Smash to Smithereens",
                            Quantity = 10
                        },
                        new
                        {
                            Id = "655c489f-bffb-45a4-8e7c-2d1a35220194",
                            ImageBorderCrop = "https://cards.scryfall.io/border_crop/front/6/5/655c489f-bffb-45a4-8e7c-2d1a35220197.jpg?1562023107",
                            ImageLarge = "https://cards.scryfall.io/large/front/6/5/655c489f-bffb-45a4-8e7c-2d1a35220197.jpg?1562023107",
                            ImageNormal = "https://cards.scryfall.io/normal/front/6/5/655c489f-bffb-45a4-8e7c-2d1a35220197.jpg?1562023107",
                            ImageSmall = "https://cards.scryfall.io/small/front/6/5/655c489f-bffb-45a4-8e7c-2d1a35220197.jpg?1562023107",
                            Name = "Smash to Smithereens",
                            Quantity = 10
                        },
                        new
                        {
                            Id = "655c489f-bffb-45a4-8e7c-2d1a35220193",
                            ImageBorderCrop = "https://cards.scryfall.io/border_crop/front/6/5/655c489f-bffb-45a4-8e7c-2d1a35220197.jpg?1562023107",
                            ImageLarge = "https://cards.scryfall.io/large/front/6/5/655c489f-bffb-45a4-8e7c-2d1a35220197.jpg?1562023107",
                            ImageNormal = "https://cards.scryfall.io/normal/front/6/5/655c489f-bffb-45a4-8e7c-2d1a35220197.jpg?1562023107",
                            ImageSmall = "https://cards.scryfall.io/small/front/6/5/655c489f-bffb-45a4-8e7c-2d1a35220197.jpg?1562023107",
                            Name = "Smash to Smithereens",
                            Quantity = 10
                        },
                        new
                        {
                            Id = "655c489f-bffb-45a4-8e7c-2d1a35220192",
                            ImageBorderCrop = "https://cards.scryfall.io/border_crop/front/6/5/655c489f-bffb-45a4-8e7c-2d1a35220197.jpg?1562023107",
                            ImageLarge = "https://cards.scryfall.io/large/front/6/5/655c489f-bffb-45a4-8e7c-2d1a35220197.jpg?1562023107",
                            ImageNormal = "https://cards.scryfall.io/normal/front/6/5/655c489f-bffb-45a4-8e7c-2d1a35220197.jpg?1562023107",
                            ImageSmall = "https://cards.scryfall.io/small/front/6/5/655c489f-bffb-45a4-8e7c-2d1a35220197.jpg?1562023107",
                            Name = "Smash to Smithereens",
                            Quantity = 10
                        },
                        new
                        {
                            Id = "655c489f-bffb-45a4-8e7c-2d1a35220191",
                            ImageBorderCrop = "https://cards.scryfall.io/border_crop/front/6/5/655c489f-bffb-45a4-8e7c-2d1a35220197.jpg?1562023107",
                            ImageLarge = "https://cards.scryfall.io/large/front/6/5/655c489f-bffb-45a4-8e7c-2d1a35220197.jpg?1562023107",
                            ImageNormal = "https://cards.scryfall.io/normal/front/6/5/655c489f-bffb-45a4-8e7c-2d1a35220197.jpg?1562023107",
                            ImageSmall = "https://cards.scryfall.io/small/front/6/5/655c489f-bffb-45a4-8e7c-2d1a35220197.jpg?1562023107",
                            Name = "Smash to Smithereens",
                            Quantity = 10
                        },
                        new
                        {
                            Id = "655c489f-bffb-45a4-8e7c-2d1a35220190",
                            ImageBorderCrop = "https://cards.scryfall.io/border_crop/front/6/5/655c489f-bffb-45a4-8e7c-2d1a35220197.jpg?1562023107",
                            ImageLarge = "https://cards.scryfall.io/large/front/6/5/655c489f-bffb-45a4-8e7c-2d1a35220197.jpg?1562023107",
                            ImageNormal = "https://cards.scryfall.io/normal/front/6/5/655c489f-bffb-45a4-8e7c-2d1a35220197.jpg?1562023107",
                            ImageSmall = "https://cards.scryfall.io/small/front/6/5/655c489f-bffb-45a4-8e7c-2d1a35220197.jpg?1562023107",
                            Name = "Smash to Smithereens",
                            Quantity = 10
                        },
                        new
                        {
                            Id = "655c489f-bffb-45a4-8e7c-2d1a352201788",
                            ImageBorderCrop = "https://cards.scryfall.io/border_crop/front/6/5/655c489f-bffb-45a4-8e7c-2d1a35220197.jpg?1562023107",
                            ImageLarge = "https://cards.scryfall.io/large/front/6/5/655c489f-bffb-45a4-8e7c-2d1a35220197.jpg?1562023107",
                            ImageNormal = "https://cards.scryfall.io/normal/front/6/5/655c489f-bffb-45a4-8e7c-2d1a35220197.jpg?1562023107",
                            ImageSmall = "https://cards.scryfall.io/small/front/6/5/655c489f-bffb-45a4-8e7c-2d1a35220197.jpg?1562023107",
                            Name = "Smash to Smithereens",
                            Quantity = 11
                        });
                });

            modelBuilder.Entity("Final___Magix.Models.InventoryPrice", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<decimal>("Usd")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("StoreInventoryPrice");

                    b.HasData(
                        new
                        {
                            Id = "655c489f-bffb-45a4-8e7c-2d1a35220197",
                            Usd = 0.22m
                        },
                        new
                        {
                            Id = "655c489f-bffb-45a4-8e7c-2d1a35220196",
                            Usd = 0.22m
                        },
                        new
                        {
                            Id = "655c489f-bffb-45a4-8e7c-2d1a35220195",
                            Usd = 0.22m
                        },
                        new
                        {
                            Id = "655c489f-bffb-45a4-8e7c-2d1a35220194",
                            Usd = 0.22m
                        },
                        new
                        {
                            Id = "655c489f-bffb-45a4-8e7c-2d1a35220193",
                            Usd = 0.22m
                        },
                        new
                        {
                            Id = "655c489f-bffb-45a4-8e7c-2d1a35220192",
                            Usd = 0.22m
                        },
                        new
                        {
                            Id = "655c489f-bffb-45a4-8e7c-2d1a35220191",
                            Usd = 0.22m
                        },
                        new
                        {
                            Id = "655c489f-bffb-45a4-8e7c-2d1a35220190",
                            Usd = 0.22m
                        },
                        new
                        {
                            Id = "655c489f-bffb-45a4-8e7c-2d1a352201788",
                            Usd = 0.25m
                        });
                });

            modelBuilder.Entity("Final___Magix.Models.Price", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)")
                        .HasAnnotation("Relational:JsonPropertyName", "id");

                    b.Property<decimal>("Usd")
                        .HasColumnType("decimal(18,2)")
                        .HasAnnotation("Relational:JsonPropertyName", "usd");

                    b.HasKey("Id");

                    b.ToTable("BulkPrice");

                    b.HasAnnotation("Relational:JsonPropertyName", "prices");
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

            modelBuilder.Entity("Final___Magix.Models.BulkData", b =>
                {
                    b.HasOne("Final___Magix.Models.Price", "Prices")
                        .WithMany()
                        .HasForeignKey("PriceId");

                    b.Navigation("Prices");
                });

            modelBuilder.Entity("Final___Magix.Models.CardModel", b =>
                {
                    b.HasOne("Final___Magix.Models.TradeInModel", null)
                        .WithMany("Cards")
                        .HasForeignKey("TradeInModelId");
                });

            modelBuilder.Entity("Final___Magix.Models.Inventory", b =>
                {
                    b.HasOne("Final___Magix.Models.Price", "Prices")
                        .WithMany()
                        .HasForeignKey("PriceId");

                    b.Navigation("Prices");
                });

            modelBuilder.Entity("Final___Magix.Models.InventoryPrice", b =>
                {
                    b.HasOne("Final___Magix.Models.Inventory", "Inventory")
                        .WithOne("InventoryPrice")
                        .HasForeignKey("Final___Magix.Models.InventoryPrice", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Inventory");
                });

            modelBuilder.Entity("Final___Magix.Models.Inventory", b =>
                {
                    b.Navigation("InventoryPrice")
                        .IsRequired();
                });

            modelBuilder.Entity("Final___Magix.Models.TradeInModel", b =>
                {
                    b.Navigation("Cards");
                });
#pragma warning restore 612, 618
        }
    }
}
