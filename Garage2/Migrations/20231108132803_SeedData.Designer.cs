﻿// <auto-generated />
using System;
using Garage2.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Garage2.Migrations
{
    [DbContext(typeof(Garage2Context))]
    [Migration("20231108132803_SeedData")]
    partial class SeedData
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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
                            TimeOfArrival = new DateTime(2023, 11, 8, 13, 13, 3, 681, DateTimeKind.Local).AddTicks(3348),
                            VehicleType = 2,
                            Year = 2022
                        },
                        new
                        {
                            ParkedVehicleId = 2,
                            Color = "White",
                            Make = "Saab",
                            Model = "Airbus",
                            NumberOfWheels = 5,
                            RegistrationNumber = "BCD234",
                            TimeOfArrival = new DateTime(2023, 11, 8, 12, 58, 3, 681, DateTimeKind.Local).AddTicks(3355),
                            VehicleType = 0,
                            Year = 2011
                        },
                        new
                        {
                            ParkedVehicleId = 3,
                            Color = "Silver",
                            Make = "Boeing",
                            Model = "747",
                            NumberOfWheels = 18,
                            RegistrationNumber = "CDE345",
                            TimeOfArrival = new DateTime(2023, 11, 8, 12, 58, 3, 681, DateTimeKind.Local).AddTicks(3360),
                            VehicleType = 0,
                            Year = 1970
                        },
                        new
                        {
                            ParkedVehicleId = 4,
                            Color = "Red",
                            Make = "Yamaha",
                            Model = "AR210",
                            NumberOfWheels = 0,
                            RegistrationNumber = "DEF456",
                            TimeOfArrival = new DateTime(2023, 11, 8, 12, 43, 3, 681, DateTimeKind.Local).AddTicks(3364),
                            VehicleType = 4,
                            Year = 2021
                        },
                        new
                        {
                            ParkedVehicleId = 5,
                            Color = "Green",
                            Make = "Mercedes-Benz",
                            Model = "Citaro",
                            NumberOfWheels = 6,
                            RegistrationNumber = "GHI789",
                            TimeOfArrival = new DateTime(2023, 11, 8, 12, 28, 3, 681, DateTimeKind.Local).AddTicks(3369),
                            VehicleType = 3,
                            Year = 2018
                        },
                        new
                        {
                            ParkedVehicleId = 6,
                            Color = "Black",
                            Make = "Toyota",
                            Model = "Camry",
                            NumberOfWheels = 4,
                            RegistrationNumber = "JKL012",
                            TimeOfArrival = new DateTime(2023, 11, 8, 12, 13, 3, 681, DateTimeKind.Local).AddTicks(3374),
                            VehicleType = 2,
                            Year = 2019
                        },
                        new
                        {
                            ParkedVehicleId = 7,
                            Color = "Blue",
                            Make = "Harley-Davidson",
                            Model = "Iron 883",
                            NumberOfWheels = 2,
                            RegistrationNumber = "MNO345",
                            TimeOfArrival = new DateTime(2023, 11, 8, 11, 58, 3, 681, DateTimeKind.Local).AddTicks(3379),
                            VehicleType = 1,
                            Year = 2020
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
