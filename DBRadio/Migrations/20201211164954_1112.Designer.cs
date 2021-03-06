﻿// <auto-generated />
using System;
using DBRadio.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DBRadio.Migrations
{
    [DbContext(typeof(DBRadioContext))]
    [Migration("20201211164954_1112")]
    partial class _1112
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("BDRadio.Models.Dolzhnosti", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<string>("Demands")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("JobTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("Position_ID")
                        .HasColumnType("bigint");

                    b.Property<string>("Responsibilities")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Salary")
                        .HasColumnType("int");

                    b.Property<long?>("SotrudnikiID")
                        .HasColumnType("bigint");

                    b.HasKey("ID");

                    b.HasIndex("SotrudnikiID");

                    b.ToTable("Dolzhnosti");
                });

            modelBuilder.Entity("BDRadio.Models.GrafikRaboti", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<long>("RecordID1")
                        .HasColumnType("bigint");

                    b.Property<long>("RecordID2")
                        .HasColumnType("bigint");

                    b.Property<long>("RecordID3")
                        .HasColumnType("bigint");

                    b.Property<long>("StaffID")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("Time1")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Time2")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Time3")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.ToTable("GrafikRaboti");
                });

            modelBuilder.Entity("BDRadio.Models.Ispolniteli", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<string>("Discription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("Perfomer_ID")
                        .HasColumnType("bigint");

                    b.Property<long?>("ZapisiID")
                        .HasColumnType("bigint");

                    b.HasKey("ID");

                    b.HasIndex("ZapisiID");

                    b.ToTable("Ispolniteli");
                });

            modelBuilder.Entity("BDRadio.Models.Sotrudniki", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<string>("Adress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("GrafikRabotiID")
                        .HasColumnType("bigint");

                    b.Property<string>("PassportData")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("PositionID")
                        .HasColumnType("bigint");

                    b.Property<long>("Staff_ID")
                        .HasColumnType("bigint");

                    b.HasKey("ID");

                    b.HasIndex("GrafikRabotiID");

                    b.ToTable("Sotrudniki");
                });

            modelBuilder.Entity("BDRadio.Models.Zapisi", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<string>("Albom")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Duration")
                        .HasColumnType("int");

                    b.Property<long>("GenreID")
                        .HasColumnType("bigint");

                    b.Property<long?>("GrafikRabotiID")
                        .HasColumnType("bigint");

                    b.Property<long?>("GrafikRabotiID1")
                        .HasColumnType("bigint");

                    b.Property<long?>("GrafikRabotiID2")
                        .HasColumnType("bigint");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("PerformerID")
                        .HasColumnType("bigint");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.Property<DateTime>("RecordDate")
                        .HasColumnType("datetime2");

                    b.Property<long>("Record_ID")
                        .HasColumnType("bigint");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("GrafikRabotiID");

                    b.HasIndex("GrafikRabotiID1");

                    b.HasIndex("GrafikRabotiID2");

                    b.ToTable("Zapisi");
                });

            modelBuilder.Entity("BDRadio.Models.Zhanri", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<string>("Discription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("Genre_ID")
                        .HasColumnType("bigint");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("ZapisiID")
                        .HasColumnType("bigint");

                    b.HasKey("ID");

                    b.HasIndex("ZapisiID");

                    b.ToTable("Zhanri");
                });

            modelBuilder.Entity("BDRadio.Models.Dolzhnosti", b =>
                {
                    b.HasOne("BDRadio.Models.Sotrudniki", null)
                        .WithMany("Position_ID")
                        .HasForeignKey("SotrudnikiID");
                });

            modelBuilder.Entity("BDRadio.Models.Ispolniteli", b =>
                {
                    b.HasOne("BDRadio.Models.Zapisi", null)
                        .WithMany("Perfomer_ID")
                        .HasForeignKey("ZapisiID");
                });

            modelBuilder.Entity("BDRadio.Models.Sotrudniki", b =>
                {
                    b.HasOne("BDRadio.Models.GrafikRaboti", null)
                        .WithMany("Staff_ID")
                        .HasForeignKey("GrafikRabotiID");
                });

            modelBuilder.Entity("BDRadio.Models.Zapisi", b =>
                {
                    b.HasOne("BDRadio.Models.GrafikRaboti", null)
                        .WithMany("Record_ID1")
                        .HasForeignKey("GrafikRabotiID");

                    b.HasOne("BDRadio.Models.GrafikRaboti", null)
                        .WithMany("Record_ID2")
                        .HasForeignKey("GrafikRabotiID1");

                    b.HasOne("BDRadio.Models.GrafikRaboti", null)
                        .WithMany("Record_ID3")
                        .HasForeignKey("GrafikRabotiID2");
                });

            modelBuilder.Entity("BDRadio.Models.Zhanri", b =>
                {
                    b.HasOne("BDRadio.Models.Zapisi", null)
                        .WithMany("Genre_ID")
                        .HasForeignKey("ZapisiID");
                });

            modelBuilder.Entity("BDRadio.Models.GrafikRaboti", b =>
                {
                    b.Navigation("Record_ID1");

                    b.Navigation("Record_ID2");

                    b.Navigation("Record_ID3");

                    b.Navigation("Staff_ID");
                });

            modelBuilder.Entity("BDRadio.Models.Sotrudniki", b =>
                {
                    b.Navigation("Position_ID");
                });

            modelBuilder.Entity("BDRadio.Models.Zapisi", b =>
                {
                    b.Navigation("Genre_ID");

                    b.Navigation("Perfomer_ID");
                });
#pragma warning restore 612, 618
        }
    }
}
