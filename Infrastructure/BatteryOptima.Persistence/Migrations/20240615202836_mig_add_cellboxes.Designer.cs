﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProductionOptima.Persistence.Context;

#nullable disable

namespace BatteryOptima.Persistence.Migrations
{
    [DbContext(typeof(ProductionOptimaContext))]
    [Migration("20240615202836_mig_add_cellboxes")]
    partial class mig_add_cellboxes
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BatteryOptima.Domain.Entities.CellBox", b =>
                {
                    b.Property<int>("CellBoxId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CellBoxId"));

                    b.Property<string>("CellBoxNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CellBoxId");

                    b.ToTable("CellBoxes");
                });

            modelBuilder.Entity("BatteryOptima.Domain.Entities.Location", b =>
                {
                    b.Property<int>("LocationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LocationId"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LocationId");

                    b.ToTable("Locations");
                });

            modelBuilder.Entity("BatteryOptima.Domain.Entities.UseACell", b =>
                {
                    b.Property<int>("UseACellId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UseACellId"));

                    b.Property<bool>("Available")
                        .HasColumnType("bit");

                    b.Property<int>("BatteryCellId")
                        .HasColumnType("int");

                    b.Property<int>("LocationId")
                        .HasColumnType("int");

                    b.Property<int>("PickUpLocationId")
                        .HasColumnType("int");

                    b.HasKey("UseACellId");

                    b.HasIndex("BatteryCellId");

                    b.HasIndex("LocationId");

                    b.ToTable("UseACells");
                });

            modelBuilder.Entity("ProductionOptima.Domain.Entities.BatteryCell", b =>
                {
                    b.Property<int>("BatteryCellId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BatteryCellId"));

                    b.Property<bool>("Available")
                        .HasColumnType("bit");

                    b.Property<string>("CellSerialNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateOfMesurementDate")
                        .HasColumnType("datetime2");

                    b.Property<double>("InternalResistance")
                        .HasColumnType("float");

                    b.Property<double>("Voltage")
                        .HasColumnType("float");

                    b.HasKey("BatteryCellId");

                    b.ToTable("BatteryCells");
                });

            modelBuilder.Entity("ProductionOptima.Domain.Entities.CellDetail", b =>
                {
                    b.Property<int>("CellDetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CellDetailId"));

                    b.Property<bool>("Available")
                        .HasColumnType("bit");

                    b.Property<int>("BatteryCellId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateOfTest")
                        .HasColumnType("datetime2");

                    b.Property<int>("ProducerId")
                        .HasColumnType("int");

                    b.Property<double>("TestIR")
                        .HasColumnType("float");

                    b.Property<double>("TestVoltage")
                        .HasColumnType("float");

                    b.HasKey("CellDetailId");

                    b.HasIndex("BatteryCellId");

                    b.HasIndex("ProducerId");

                    b.ToTable("CellDetails");
                });

            modelBuilder.Entity("ProductionOptima.Domain.Entities.Producer", b =>
                {
                    b.Property<int>("ProducerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProducerId"));

                    b.Property<string>("ProducerCountry")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProducerName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProducerNo")
                        .HasColumnType("int");

                    b.HasKey("ProducerId");

                    b.ToTable("Producers");
                });

            modelBuilder.Entity("BatteryOptima.Domain.Entities.UseACell", b =>
                {
                    b.HasOne("ProductionOptima.Domain.Entities.BatteryCell", "BatteryCell")
                        .WithMany("UseACells")
                        .HasForeignKey("BatteryCellId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BatteryOptima.Domain.Entities.Location", "Location")
                        .WithMany("UseACells")
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BatteryCell");

                    b.Navigation("Location");
                });

            modelBuilder.Entity("ProductionOptima.Domain.Entities.CellDetail", b =>
                {
                    b.HasOne("ProductionOptima.Domain.Entities.BatteryCell", "BatteryCell")
                        .WithMany("CellDetails")
                        .HasForeignKey("BatteryCellId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProductionOptima.Domain.Entities.Producer", "Producer")
                        .WithMany("CellDetails")
                        .HasForeignKey("ProducerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BatteryCell");

                    b.Navigation("Producer");
                });

            modelBuilder.Entity("BatteryOptima.Domain.Entities.Location", b =>
                {
                    b.Navigation("UseACells");
                });

            modelBuilder.Entity("ProductionOptima.Domain.Entities.BatteryCell", b =>
                {
                    b.Navigation("CellDetails");

                    b.Navigation("UseACells");
                });

            modelBuilder.Entity("ProductionOptima.Domain.Entities.Producer", b =>
                {
                    b.Navigation("CellDetails");
                });
#pragma warning restore 612, 618
        }
    }
}
