﻿// <auto-generated />
using System;
using CarRentalApp.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace CarRentalApp.Domain.Migrations
{
    [DbContext(typeof(CarRentalAppDbContext))]
    partial class CarRentalAppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("CarRentalApp.Domain.Car", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("color");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("model");

                    b.Property<string>("Number")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("number");

                    b.HasKey("Id");

                    b.ToTable("Car");
                });

            modelBuilder.Entity("CarRentalApp.Domain.Client", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateOnly>("BirthDate")
                        .HasColumnType("date")
                        .HasColumnName("birth_date");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("full_name");

                    b.Property<int>("PassportNumber")
                        .HasColumnType("integer")
                        .HasColumnName("pusport_number");

                    b.HasKey("Id");

                    b.ToTable("Client");
                });

            modelBuilder.Entity("CarRentalApp.Domain.RentalPlace", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("address");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("RentalPlace");
                });

            modelBuilder.Entity("CarRentalApp.Domain.RentedCar", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("IssueTime")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("issue_time");

                    b.Property<TimeSpan?>("RentalPeriod")
                        .HasColumnType("interval")
                        .HasColumnName("rental_period");

                    b.Property<DateTime?>("ReturnTime")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("return_time");

                    b.Property<int>("car")
                        .HasColumnType("integer");

                    b.Property<int>("client")
                        .HasColumnType("integer");

                    b.Property<int>("rentalPlace")
                        .HasColumnType("integer");

                    b.Property<int?>("returnRentalPlace")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("car");

                    b.HasIndex("client");

                    b.HasIndex("rentalPlace");

                    b.HasIndex("returnRentalPlace");

                    b.ToTable("RentedCar");
                });

            modelBuilder.Entity("CarRentalApp.Domain.RentedCar", b =>
                {
                    b.HasOne("CarRentalApp.Domain.Car", "Car")
                        .WithMany()
                        .HasForeignKey("car")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CarRentalApp.Domain.Client", "Client")
                        .WithMany()
                        .HasForeignKey("client")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CarRentalApp.Domain.RentalPlace", "RentalPlace")
                        .WithMany()
                        .HasForeignKey("rentalPlace")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CarRentalApp.Domain.RentalPlace", "ReturnRentalPlace")
                        .WithMany()
                        .HasForeignKey("returnRentalPlace")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("Car");

                    b.Navigation("Client");

                    b.Navigation("RentalPlace");

                    b.Navigation("ReturnRentalPlace");
                });
#pragma warning restore 612, 618
        }
    }
}
