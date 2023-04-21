﻿// <auto-generated />
using System;
using Backend.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Backend.Migrations
{
    [DbContext(typeof(GestaoContext))]
    partial class GestaoContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Backend.Models.Entities.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Complement")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("District")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("Backend.Models.Entities.Brand", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Brands");
                });

            modelBuilder.Entity("Backend.Models.Entities.Diary", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("End")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Start")
                        .HasColumnType("datetime2");

                    b.Property<int>("VehicleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("VehicleId");

                    b.ToTable("Diaries");
                });

            modelBuilder.Entity("Backend.Models.Entities.Event", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DiaryId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DiaryId");

                    b.ToTable("Events");
                });

            modelBuilder.Entity("Backend.Models.Entities.Garage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AddressId")
                        .HasColumnType("int");

                    b.Property<int>("Slots")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AddressId");

                    b.ToTable("Garages");
                });

            modelBuilder.Entity("Backend.Models.Entities.Model", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BrandId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("BrandId");

                    b.ToTable("Models");
                });

            modelBuilder.Entity("Backend.Models.Entities.Slot", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("GarageId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("GarageId");

                    b.ToTable("Slots");
                });

            modelBuilder.Entity("Backend.Models.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("Admin")
                        .HasColumnType("bit");

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.UseTptMappingStrategy();
                });

            modelBuilder.Entity("Backend.Models.Entities.UserDiary", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("UsersDiaries");
                });

            modelBuilder.Entity("Backend.Models.Entities.Vehicle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("DriverId")
                        .HasColumnType("int");

                    b.Property<int>("EntryDate")
                        .HasColumnType("int");

                    b.Property<int>("ModelId")
                        .HasColumnType("int");

                    b.Property<int>("Plate")
                        .HasColumnType("int");

                    b.Property<string>("Renavam")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SlotId")
                        .HasColumnType("int");

                    b.Property<int>("VehicleTypeId")
                        .HasColumnType("int");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DriverId");

                    b.HasIndex("ModelId");

                    b.HasIndex("SlotId");

                    b.HasIndex("VehicleTypeId");

                    b.ToTable("Vehicles");
                });

            modelBuilder.Entity("Backend.Models.Entities.VehicleType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("VehiclesTypes");
                });

            modelBuilder.Entity("Backend.Models.Entities.Driver", b =>
                {
                    b.HasBaseType("Backend.Models.Entities.User");

                    b.Property<string>("CNH")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("Drivers");
                });

            modelBuilder.Entity("Backend.Models.Entities.Diary", b =>
                {
                    b.HasOne("Backend.Models.Entities.Vehicle", "Vehicle")
                        .WithMany()
                        .HasForeignKey("VehicleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Vehicle");
                });

            modelBuilder.Entity("Backend.Models.Entities.Event", b =>
                {
                    b.HasOne("Backend.Models.Entities.Diary", "Diary")
                        .WithMany()
                        .HasForeignKey("DiaryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Diary");
                });

            modelBuilder.Entity("Backend.Models.Entities.Garage", b =>
                {
                    b.HasOne("Backend.Models.Entities.Address", "Address")
                        .WithMany()
                        .HasForeignKey("AddressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Address");
                });

            modelBuilder.Entity("Backend.Models.Entities.Model", b =>
                {
                    b.HasOne("Backend.Models.Entities.Brand", "Brand")
                        .WithMany()
                        .HasForeignKey("BrandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Brand");
                });

            modelBuilder.Entity("Backend.Models.Entities.Slot", b =>
                {
                    b.HasOne("Backend.Models.Entities.Garage", "Garage")
                        .WithMany()
                        .HasForeignKey("GarageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Garage");
                });

            modelBuilder.Entity("Backend.Models.Entities.UserDiary", b =>
                {
                    b.HasOne("Backend.Models.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Backend.Models.Entities.Vehicle", b =>
                {
                    b.HasOne("Backend.Models.Entities.Driver", "Driver")
                        .WithMany()
                        .HasForeignKey("DriverId");

                    b.HasOne("Backend.Models.Entities.Model", "Model")
                        .WithMany()
                        .HasForeignKey("ModelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Backend.Models.Entities.Slot", "Slot")
                        .WithMany()
                        .HasForeignKey("SlotId");

                    b.HasOne("Backend.Models.Entities.VehicleType", "VehicleType")
                        .WithMany()
                        .HasForeignKey("VehicleTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Driver");

                    b.Navigation("Model");

                    b.Navigation("Slot");

                    b.Navigation("VehicleType");
                });

            modelBuilder.Entity("Backend.Models.Entities.Driver", b =>
                {
                    b.HasOne("Backend.Models.Entities.User", null)
                        .WithOne()
                        .HasForeignKey("Backend.Models.Entities.Driver", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
