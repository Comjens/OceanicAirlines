﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OceanicAirlines.Data;

namespace OceanicAirlines.Migrations
{
    [DbContext(typeof(ParcelContext))]
    [Migration("20200109124350_Initialfix")]
    partial class Initialfix
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("OceanicAirlines.Model.LocationModel", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("datetime2");

                    b.Property<double>("Latitude")
                        .HasColumnType("float");

                    b.Property<double>("Longitude")
                        .HasColumnType("float");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Location");
                });

            modelBuilder.Entity("OceanicAirlines.Model.RouteModel", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("datetime2");

                    b.Property<double>("Duration")
                        .HasColumnType("float");

                    b.Property<long?>("FromId")
                        .HasColumnType("bigint");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price1")
                        .HasColumnType("float");

                    b.Property<double>("Price2")
                        .HasColumnType("float");

                    b.Property<double>("Price3")
                        .HasColumnType("float");

                    b.Property<long?>("ShipmentModelId")
                        .HasColumnType("bigint");

                    b.Property<long?>("ToId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("UpdatedTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("FromId");

                    b.HasIndex("ShipmentModelId");

                    b.HasIndex("ToId");

                    b.ToTable("Route");
                });

            modelBuilder.Entity("OceanicAirlines.Model.ShipmentModel", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("datetime2");

                    b.Property<long?>("FromId")
                        .HasColumnType("bigint");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("NavId")
                        .HasColumnType("bigint");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<long?>("ToId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("UpdatedTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("FromId");

                    b.HasIndex("ToId");

                    b.ToTable("Shipment");
                });

            modelBuilder.Entity("OceanicAirlines.Model.ShipmentTypeModel", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Additional")
                        .HasColumnType("float");

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Rate")
                        .HasColumnType("float");

                    b.Property<long?>("ShipmentModelId")
                        .HasColumnType("bigint");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("ShipmentModelId");

                    b.ToTable("ShipmentType");
                });

            modelBuilder.Entity("OceanicAirlines.Model.RouteModel", b =>
                {
                    b.HasOne("OceanicAirlines.Model.LocationModel", "From")
                        .WithMany()
                        .HasForeignKey("FromId");

                    b.HasOne("OceanicAirlines.Model.ShipmentModel", null)
                        .WithMany("Routes")
                        .HasForeignKey("ShipmentModelId");

                    b.HasOne("OceanicAirlines.Model.LocationModel", "To")
                        .WithMany()
                        .HasForeignKey("ToId");
                });

            modelBuilder.Entity("OceanicAirlines.Model.ShipmentModel", b =>
                {
                    b.HasOne("OceanicAirlines.Model.LocationModel", "From")
                        .WithMany()
                        .HasForeignKey("FromId");

                    b.HasOne("OceanicAirlines.Model.LocationModel", "To")
                        .WithMany()
                        .HasForeignKey("ToId");
                });

            modelBuilder.Entity("OceanicAirlines.Model.ShipmentTypeModel", b =>
                {
                    b.HasOne("OceanicAirlines.Model.ShipmentModel", null)
                        .WithMany("ForsendelseTypes")
                        .HasForeignKey("ShipmentModelId");
                });
#pragma warning restore 612, 618
        }
    }
}
