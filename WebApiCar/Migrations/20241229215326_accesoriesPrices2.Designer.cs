﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApiCar.Database;

#nullable disable

namespace WebApiCar.Migrations
{
    [DbContext(typeof(WebApiCarDbContext))]
    [Migration("20241229215326_accesoriesPrices2")]
    partial class accesoriesPrices2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CarCarAccesories", b =>
                {
                    b.Property<int>("AccesoriesCarAccesoriesId")
                        .HasColumnType("int");

                    b.Property<int>("CarscarId")
                        .HasColumnType("int");

                    b.HasKey("AccesoriesCarAccesoriesId", "CarscarId");

                    b.HasIndex("CarscarId");

                    b.ToTable("CarCarAccesories");
                });

            modelBuilder.Entity("CarCarOptions", b =>
                {
                    b.Property<int>("CarscarId")
                        .HasColumnType("int");

                    b.Property<int>("OptionsCarOptionsId")
                        .HasColumnType("int");

                    b.HasKey("CarscarId", "OptionsCarOptionsId");

                    b.HasIndex("OptionsCarOptionsId");

                    b.ToTable("CarCarOptions");
                });

            modelBuilder.Entity("WebApiCar.Model.Car", b =>
                {
                    b.Property<int>("carId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("carId"));

                    b.Property<int>("CarPriceId")
                        .HasColumnType("int");

                    b.Property<int>("CarPriceId1")
                        .HasColumnType("int");

                    b.Property<string>("decripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("familia")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("modelo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("carId");

                    b.HasIndex("CarPriceId1");

                    b.ToTable("Cars");
                });

            modelBuilder.Entity("WebApiCar.Model.CarAccesories", b =>
                {
                    b.Property<int>("CarAccesoriesId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CarAccesoriesId"));

                    b.Property<string>("AccesoryDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AccesoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CarAccesoriesPricesId")
                        .HasColumnType("int");

                    b.Property<int?>("CarAccesoriesPricesId1")
                        .HasColumnType("int");

                    b.HasKey("CarAccesoriesId");

                    b.HasIndex("CarAccesoriesPricesId1");

                    b.ToTable("CarAccesories");
                });

            modelBuilder.Entity("WebApiCar.Model.CarAccesoriesPrices", b =>
                {
                    b.Property<int>("CarAccesoriesPricesId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CarAccesoriesPricesId"));

                    b.Property<int>("CarAccesoriesId")
                        .HasColumnType("int");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.HasKey("CarAccesoriesPricesId");

                    b.ToTable("CarAccesoriesPrices");
                });

            modelBuilder.Entity("WebApiCar.Model.CarOptions", b =>
                {
                    b.Property<int>("CarOptionsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CarOptionsId"));

                    b.Property<string>("OptionDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OptionName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CarOptionsId");

                    b.ToTable("CarOptions");
                });

            modelBuilder.Entity("WebApiCar.Model.CarPrice", b =>
                {
                    b.Property<int>("CarPriceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CarPriceId"));

                    b.Property<double>("IGIC")
                        .HasColumnType("float");

                    b.Property<double>("IVA")
                        .HasColumnType("float");

                    b.Property<double>("Listprice")
                        .HasColumnType("float");

                    b.Property<double>("Totalprice")
                        .HasColumnType("float");

                    b.Property<int>("carId")
                        .HasColumnType("int");

                    b.HasKey("CarPriceId");

                    b.ToTable("CarsPrices");
                });

            modelBuilder.Entity("CarCarAccesories", b =>
                {
                    b.HasOne("WebApiCar.Model.CarAccesories", null)
                        .WithMany()
                        .HasForeignKey("AccesoriesCarAccesoriesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApiCar.Model.Car", null)
                        .WithMany()
                        .HasForeignKey("CarscarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CarCarOptions", b =>
                {
                    b.HasOne("WebApiCar.Model.Car", null)
                        .WithMany()
                        .HasForeignKey("CarscarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApiCar.Model.CarOptions", null)
                        .WithMany()
                        .HasForeignKey("OptionsCarOptionsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WebApiCar.Model.Car", b =>
                {
                    b.HasOne("WebApiCar.Model.CarPrice", "carPrice")
                        .WithMany()
                        .HasForeignKey("CarPriceId1")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("carPrice");
                });

            modelBuilder.Entity("WebApiCar.Model.CarAccesories", b =>
                {
                    b.HasOne("WebApiCar.Model.CarAccesoriesPrices", "carAccesoriesPrices")
                        .WithMany()
                        .HasForeignKey("CarAccesoriesPricesId1");

                    b.Navigation("carAccesoriesPrices");
                });
#pragma warning restore 612, 618
        }
    }
}
