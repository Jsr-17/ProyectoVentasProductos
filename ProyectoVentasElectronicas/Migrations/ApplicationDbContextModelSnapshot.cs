﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProyectoVentasElectronicas.Data;

#nullable disable

namespace ProyectoVentasElectronicas.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0-preview.3.24172.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ProyectoVentasElectronicas.Models.Categories", b =>
                {
                    b.Property<int>("Category_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Category_id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Category_id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Category_id = 1,
                            Name = "Computers"
                        },
                        new
                        {
                            Category_id = 2,
                            Name = "Smartphones"
                        },
                        new
                        {
                            Category_id = 3,
                            Name = "Accesory"
                        });
                });

            modelBuilder.Entity("ProyectoVentasElectronicas.Models.Clients", b =>
                {
                    b.Property<int>("Client_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Client_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Client_id"));

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Direction")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telephone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("admin")
                        .HasColumnType("bit");

                    b.HasKey("Client_id");

                    b.ToTable("Clients");

                    b.HasData(
                        new
                        {
                            Client_id = 1,
                            City = "Buenos Aires",
                            Country = "Argentina",
                            Direction = "Calle Falsa 123",
                            Email = "juan.perez@example.com",
                            Name = "Juan",
                            Password = "1234",
                            Surname = "Pérez",
                            Telephone = "+5491145678901",
                            Username = "test"
                        },
                        new
                        {
                            Client_id = 2,
                            City = "Buenos Aires",
                            Country = "Argentina",
                            Direction = "Calle Falsa 123",
                            Email = "Juan.perez@example.com",
                            Name = "Maria",
                            Password = "1234",
                            Surname = "Gonzalez",
                            Telephone = "+5491145678901",
                            Username = "test"
                        },
                        new
                        {
                            Client_id = 3,
                            City = "Lima",
                            Country = "Perú",
                            Direction = "Calle Larga 789",
                            Email = "pedro.martinez@example.com",
                            Name = "Pedro",
                            Password = "1234",
                            Surname = "Martínez",
                            Telephone = "+5491145678903",
                            Username = "test"
                        },
                        new
                        {
                            Client_id = 4,
                            City = "Alhendin",
                            Country = "El barrio no tan bajo",
                            Direction = "Calle Tiesa 789",
                            Email = "Minabo.Tieso@example.com",
                            Name = "Minabo",
                            Password = "1234",
                            Surname = "Tieso",
                            Telephone = "+YoLaConociEnunTaxi",
                            Username = "test"
                        },
                        new
                        {
                            Client_id = 5,
                            City = "Durcal",
                            Country = "Japon",
                            Direction = "Al Lao de un Parque",
                            Email = "Elver_gaCorta_ElTerrorDeLasnennas@example.com",
                            Name = "Elver",
                            Password = "1234",
                            Surname = "Gacorta",
                            Telephone = "QueBuenosEstanLoskebabsDeDurcal",
                            Username = "test"
                        });
                });

            modelBuilder.Entity("ProyectoVentasElectronicas.Models.DetailsOrders", b =>
                {
                    b.Property<int>("Detail_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Detail_id"));

                    b.Property<int>("Order_id")
                        .HasColumnType("int");

                    b.Property<decimal>("Prize")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Product_id")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Detail_id");

                    b.HasIndex("Order_id");

                    b.HasIndex("Product_id");

                    b.ToTable("DetailsOrder");

                    b.HasData(
                        new
                        {
                            Detail_id = 1,
                            Order_id = 1,
                            Prize = 1200.00m,
                            Product_id = 1,
                            Quantity = 1
                        },
                        new
                        {
                            Detail_id = 2,
                            Order_id = 2,
                            Prize = 1000.00m,
                            Product_id = 2,
                            Quantity = 1
                        },
                        new
                        {
                            Detail_id = 3,
                            Order_id = 3,
                            Prize = 300.00m,
                            Product_id = 3,
                            Quantity = 1
                        },
                        new
                        {
                            Detail_id = 4,
                            Order_id = 1,
                            Prize = 80.00m,
                            Product_id = 4,
                            Quantity = 2
                        });
                });

            modelBuilder.Entity("ProyectoVentasElectronicas.Models.Orders", b =>
                {
                    b.Property<int>("Order_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Order_id"));

                    b.Property<int>("Client_id")
                        .HasColumnType("int");

                    b.Property<DateTime>("Order_date")
                        .HasColumnType("datetime2");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Order_id");

                    b.HasIndex("Client_id");

                    b.ToTable("Orders");

                    b.HasData(
                        new
                        {
                            Order_id = 1,
                            Client_id = 1,
                            Order_date = new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            State = "Processing"
                        },
                        new
                        {
                            Order_id = 2,
                            Client_id = 2,
                            Order_date = new DateTime(2024, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            State = "Send"
                        },
                        new
                        {
                            Order_id = 3,
                            Client_id = 3,
                            Order_date = new DateTime(2024, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            State = "Delivered"
                        });
                });

            modelBuilder.Entity("ProyectoVentasElectronicas.Models.Products", b =>
                {
                    b.Property<int>("Product_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Product_id"));

                    b.Property<int>("Category_id")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Suplier_id")
                        .HasColumnType("int");

                    b.HasKey("Product_id");

                    b.HasIndex("Category_id");

                    b.HasIndex("Suplier_id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Product_id = 1,
                            Category_id = 1,
                            Description = "Laptop Dell  8GB RAM",
                            Name = "Laptop Dell",
                            Price = 1200.00m,
                            Suplier_id = 1
                        },
                        new
                        {
                            Product_id = 2,
                            Category_id = 2,
                            Description = "Smartphone Apple iPhone 13",
                            Name = "iPhone 13",
                            Price = 1000.00m,
                            Suplier_id = 2
                        },
                        new
                        {
                            Product_id = 3,
                            Category_id = 1,
                            Description = "Monitor Samsung 27'' ",
                            Name = "Monitor Samsung",
                            Price = 300.00m,
                            Suplier_id = 1
                        },
                        new
                        {
                            Product_id = 4,
                            Category_id = 3,
                            Description = "Keyboard mechanic Logitech",
                            Name = "Teclado Logitech",
                            Price = 80.00m,
                            Suplier_id = 3
                        });
                });

            modelBuilder.Entity("ProyectoVentasElectronicas.Models.Supliers", b =>
                {
                    b.Property<int>("Suplier_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Suplier_id"));

                    b.Property<string>("Direction")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telephone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Suplier_id");

                    b.ToTable("Supliers");

                    b.HasData(
                        new
                        {
                            Suplier_id = 1,
                            Direction = "1 Dell Way, Round Rock",
                            Name = "Dell Inc.",
                            Telephone = "+18005555555"
                        },
                        new
                        {
                            Suplier_id = 2,
                            Direction = "1 Infinite Loop, Cupertino",
                            Name = "Apple Inc",
                            Telephone = "+18006565432"
                        },
                        new
                        {
                            Suplier_id = 3,
                            Direction = "7600 Gateway Blvd, Newark",
                            Name = "Logitech Inc.",
                            Telephone = "+18001234567"
                        });
                });

            modelBuilder.Entity("ProyectoVentasElectronicas.Models.DetailsOrders", b =>
                {
                    b.HasOne("ProyectoVentasElectronicas.Models.Orders", "Order")
                        .WithMany()
                        .HasForeignKey("Order_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProyectoVentasElectronicas.Models.Products", "Product")
                        .WithMany()
                        .HasForeignKey("Product_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("ProyectoVentasElectronicas.Models.Orders", b =>
                {
                    b.HasOne("ProyectoVentasElectronicas.Models.Clients", "Client")
                        .WithMany()
                        .HasForeignKey("Client_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");
                });

            modelBuilder.Entity("ProyectoVentasElectronicas.Models.Products", b =>
                {
                    b.HasOne("ProyectoVentasElectronicas.Models.Categories", "Category")
                        .WithMany()
                        .HasForeignKey("Category_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProyectoVentasElectronicas.Models.Supliers", "Suplier")
                        .WithMany()
                        .HasForeignKey("Suplier_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Suplier");
                });
#pragma warning restore 612, 618
        }
    }
}
