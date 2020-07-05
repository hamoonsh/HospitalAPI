﻿// <auto-generated />
using System;
using HospitalAPI.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HospitalAPI.Migrations
{
    [DbContext(typeof(HospitalDBContext))]
    [Migration("20200705072851_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HospitalAPI.Models.Entities.Doctor", b =>
                {
                    b.Property<int>("DoctorID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Family")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.HasKey("DoctorID");

                    b.ToTable("Doctor","pmwebsit_HospitalDB");

                    b.HasData(
                        new
                        {
                            DoctorID = 1,
                            Family = "Javadi",
                            Name = "Javad"
                        },
                        new
                        {
                            DoctorID = 2,
                            Family = "Javidi",
                            Name = "Javid"
                        },
                        new
                        {
                            DoctorID = 3,
                            Family = "Mahdavi",
                            Name = "Mahdi"
                        },
                        new
                        {
                            DoctorID = 4,
                            Family = "kamrani",
                            Name = "Kamran"
                        },
                        new
                        {
                            DoctorID = 5,
                            Family = "Soheili",
                            Name = "Soheil"
                        },
                        new
                        {
                            DoctorID = 6,
                            Family = "Alavi",
                            Name = "Ali"
                        });
                });

            modelBuilder.Entity("HospitalAPI.Models.Entities.Hospital", b =>
                {
                    b.Property<int>("HospitalID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.Property<int>("levelFourVisitingTime")
                        .HasColumnType("int");

                    b.Property<int>("levelOneVisitingTime")
                        .HasColumnType("int");

                    b.Property<int>("levelThreeVisitingTime")
                        .HasColumnType("int");

                    b.Property<int>("levelTwoVisitingTime")
                        .HasColumnType("int");

                    b.Property<int>("levelZeroVisitingTime")
                        .HasColumnType("int");

                    b.HasKey("HospitalID");

                    b.ToTable("Hospital","pmwebsit_HospitalDB");

                    b.HasData(
                        new
                        {
                            HospitalID = 1,
                            Name = "Hospital A",
                            levelFourVisitingTime = 38,
                            levelOneVisitingTime = 7,
                            levelThreeVisitingTime = 30,
                            levelTwoVisitingTime = 16,
                            levelZeroVisitingTime = 5
                        },
                        new
                        {
                            HospitalID = 2,
                            Name = " Hospital B",
                            levelFourVisitingTime = 29,
                            levelOneVisitingTime = 11,
                            levelThreeVisitingTime = 20,
                            levelTwoVisitingTime = 15,
                            levelZeroVisitingTime = 10
                        },
                        new
                        {
                            HospitalID = 3,
                            Name = "Hospital C",
                            levelFourVisitingTime = 30,
                            levelOneVisitingTime = 18,
                            levelThreeVisitingTime = 20,
                            levelTwoVisitingTime = 20,
                            levelZeroVisitingTime = 15
                        },
                        new
                        {
                            HospitalID = 4,
                            Name = "Hospital D",
                            levelFourVisitingTime = 28,
                            levelOneVisitingTime = 10,
                            levelThreeVisitingTime = 20,
                            levelTwoVisitingTime = 15,
                            levelZeroVisitingTime = 10
                        },
                        new
                        {
                            HospitalID = 5,
                            Name = "Hospital E",
                            levelFourVisitingTime = 32,
                            levelOneVisitingTime = 20,
                            levelThreeVisitingTime = 25,
                            levelTwoVisitingTime = 20,
                            levelZeroVisitingTime = 18
                        },
                        new
                        {
                            HospitalID = 6,
                            Name = "Hospital F",
                            levelFourVisitingTime = 38,
                            levelOneVisitingTime = 20,
                            levelThreeVisitingTime = 32,
                            levelTwoVisitingTime = 30,
                            levelZeroVisitingTime = 12
                        });
                });

            modelBuilder.Entity("HospitalAPI.Models.Entities.HospitalDoctor", b =>
                {
                    b.Property<int>("HospitalDoctorID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DoctorID")
                        .HasColumnType("int");

                    b.Property<int>("HospitalID")
                        .HasColumnType("int");

                    b.HasKey("HospitalDoctorID");

                    b.HasIndex("DoctorID");

                    b.HasIndex("HospitalID");

                    b.ToTable("HospitalDoctor","pmwebsit_HospitalDB");

                    b.HasData(
                        new
                        {
                            HospitalDoctorID = 1,
                            DoctorID = 1,
                            HospitalID = 1
                        },
                        new
                        {
                            HospitalDoctorID = 2,
                            DoctorID = 2,
                            HospitalID = 2
                        },
                        new
                        {
                            HospitalDoctorID = 3,
                            DoctorID = 3,
                            HospitalID = 3
                        },
                        new
                        {
                            HospitalDoctorID = 4,
                            DoctorID = 4,
                            HospitalID = 4
                        },
                        new
                        {
                            HospitalDoctorID = 5,
                            DoctorID = 5,
                            HospitalID = 5
                        },
                        new
                        {
                            HospitalDoctorID = 6,
                            DoctorID = 6,
                            HospitalID = 6
                        });
                });

            modelBuilder.Entity("HospitalAPI.Models.Entities.Patient", b =>
                {
                    b.Property<int>("PatientID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DoctorID")
                        .HasColumnType("int");

                    b.Property<int>("HospitalID")
                        .HasColumnType("int");

                    b.Property<string>("IsVisited")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Level")
                        .HasColumnType("int");

                    b.Property<string>("MobileNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("RegTime")
                        .HasColumnType("datetime2");

                    b.HasKey("PatientID");

                    b.HasIndex("DoctorID");

                    b.HasIndex("HospitalID");

                    b.ToTable("Patient","pmwebsit_HospitalDB");
                });

            modelBuilder.Entity("HospitalAPI.Models.Entities.HospitalDoctor", b =>
                {
                    b.HasOne("HospitalAPI.Models.Entities.Doctor", "Doctor")
                        .WithMany()
                        .HasForeignKey("DoctorID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HospitalAPI.Models.Entities.Hospital", "Hospital")
                        .WithMany()
                        .HasForeignKey("HospitalID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("HospitalAPI.Models.Entities.Patient", b =>
                {
                    b.HasOne("HospitalAPI.Models.Entities.Doctor", "Doctor")
                        .WithMany()
                        .HasForeignKey("DoctorID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HospitalAPI.Models.Entities.Hospital", "Hospital")
                        .WithMany()
                        .HasForeignKey("HospitalID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
