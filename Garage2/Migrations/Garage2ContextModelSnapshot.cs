﻿// <auto-generated />
using System;
using Garage2.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Garage2.Migrations
{
    [DbContext(typeof(Garage2Context))]
    partial class Garage2ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Garage2.Models.ParkedVehicle", b =>
                {
                    b.Property<int>("ParkedVehicleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ParkedVehicleId"));

                    b.Property<string>("Color")
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("Make")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<int?>("NumberOfWheels")
                        .HasColumnType("int");

                    b.Property<string>("RegistrationNumber")
                        .IsRequired()
                        .HasMaxLength(6)
                        .HasColumnType("nvarchar(6)");

                    b.Property<DateTime>("TimeOfArrival")
                        .HasColumnType("datetime2");

                    b.Property<int>("VehicleType")
                        .HasColumnType("int");

                    b.Property<int?>("Year")
                        .HasColumnType("int");

                    b.HasKey("ParkedVehicleId");

                    b.ToTable("ParkedVehicle");

                    b.HasData(
                        new
                        {
                            ParkedVehicleId = 1,
                            Color = "White",
                            Make = "Volvo",
                            Model = "V70",
                            NumberOfWheels = 4,
                            RegistrationNumber = "ABC123",
                            TimeOfArrival = new DateTime(2023, 11, 8, 12, 9, 39, 99, DateTimeKind.Local).AddTicks(8056),
                            VehicleType = 2,
                            Year = 2022
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
