﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Rent.Web.Data.Entities;

namespace Rent.Web.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20191118133105_new_relacion")]
    partial class new_relacion
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Rent.Web.Data.Entities.MarcaVehiculo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nombre")
                        .IsRequired();

                    b.Property<int?>("VehiculoId");

                    b.HasKey("Id");

                    b.HasIndex("VehiculoId");

                    b.ToTable("MarcaVehiculos");
                });

            modelBuilder.Entity("Rent.Web.Data.Entities.VehiculoCaracteristica", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Estatus")
                        .IsRequired();

                    b.Property<int?>("VehiculoId");

                    b.Property<int?>("VehiculocaracteristicaId");

                    b.HasKey("Id");

                    b.HasIndex("VehiculoId");

                    b.HasIndex("VehiculocaracteristicaId");

                    b.ToTable("VehiculoCaracteristicas");
                });

            modelBuilder.Entity("Rent.Web.Data.Entities.VehiculoPublicacion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Imagen")
                        .IsRequired();

                    b.Property<int?>("VehiculoId");

                    b.HasKey("Id");

                    b.HasIndex("VehiculoId");

                    b.ToTable("vehiculoPublicacions");
                });

            modelBuilder.Entity("Rent.Web.Data.ModeloVehiculo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Marca");

                    b.Property<int?>("VehiculoId");

                    b.HasKey("Id");

                    b.HasIndex("VehiculoId");

                    b.ToTable("ModeloVehiculos");
                });

            modelBuilder.Entity("Rent.Web.Data.TiposVehiculos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Tipo")
                        .IsRequired();

                    b.Property<int?>("VehiculoId");

                    b.HasKey("Id");

                    b.HasIndex("VehiculoId");

                    b.ToTable("TiposVehiculos");
                });

            modelBuilder.Entity("Rent.Web.Data.Vehiculo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Anio_Vehiculo");

                    b.Property<string>("Color");

                    b.Property<string>("Kilometraje");

                    b.Property<string>("NoPlaca");

                    b.Property<string>("No_Chasis");

                    b.Property<string>("NombreVehiculo");

                    b.HasKey("Id");

                    b.ToTable("Vehiculos");
                });

            modelBuilder.Entity("Rent.Web.Data.Entities.MarcaVehiculo", b =>
                {
                    b.HasOne("Rent.Web.Data.Vehiculo", "Vehiculo")
                        .WithMany()
                        .HasForeignKey("VehiculoId");
                });

            modelBuilder.Entity("Rent.Web.Data.Entities.VehiculoCaracteristica", b =>
                {
                    b.HasOne("Rent.Web.Data.Vehiculo")
                        .WithMany("vehiculoCaracteristicas")
                        .HasForeignKey("VehiculoId");

                    b.HasOne("Rent.Web.Data.Entities.VehiculoCaracteristica", "Vehiculocaracteristica")
                        .WithMany()
                        .HasForeignKey("VehiculocaracteristicaId");
                });

            modelBuilder.Entity("Rent.Web.Data.Entities.VehiculoPublicacion", b =>
                {
                    b.HasOne("Rent.Web.Data.Vehiculo", "Vehiculo")
                        .WithMany("vehiculoPublicacions")
                        .HasForeignKey("VehiculoId");
                });

            modelBuilder.Entity("Rent.Web.Data.ModeloVehiculo", b =>
                {
                    b.HasOne("Rent.Web.Data.Vehiculo", "Vehiculo")
                        .WithMany("ModeloVehiculos")
                        .HasForeignKey("VehiculoId");
                });

            modelBuilder.Entity("Rent.Web.Data.TiposVehiculos", b =>
                {
                    b.HasOne("Rent.Web.Data.Vehiculo", "Vehiculo")
                        .WithMany("TiposVehiculos")
                        .HasForeignKey("VehiculoId");
                });
#pragma warning restore 612, 618
        }
    }
}
