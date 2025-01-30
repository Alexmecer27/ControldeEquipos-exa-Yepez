﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ControldeEquipos.Migrations
{
    [DbContext(typeof(AppDBContext))]
    partial class AppDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Departamento", b =>
                {
                    b.Property<int>("ID_Departamento")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID_Departamento"));

                    b.Property<string>("Nombre_Departamento")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID_Departamento");

                    b.ToTable("Departamentos");
                });

            modelBuilder.Entity("Equipo", b =>
                {
                    b.Property<int>("ID_Equipo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID_Equipo"));

                    b.Property<int>("DepartamentoID_Departamento")
                        .HasColumnType("int");

                    b.Property<int>("Departamento_ID")
                        .HasColumnType("int");

                    b.Property<DateTime>("Fecha_Adquisicion")
                        .HasColumnType("datetime2");

                    b.Property<string>("Marca")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Modelo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre_Equipo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Numero_Serial")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID_Equipo");

                    b.HasIndex("DepartamentoID_Departamento");

                    b.ToTable("Equipos");
                });

            modelBuilder.Entity("Mantenimiento", b =>
                {
                    b.Property<int>("ID_Mantenimiento")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID_Mantenimiento"));

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EquipoID_Equipo")
                        .HasColumnType("int");

                    b.Property<int>("Equipo_ID")
                        .HasColumnType("int");

                    b.Property<DateTime>("Fecha_Mantenimiento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Tecnico")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID_Mantenimiento");

                    b.HasIndex("EquipoID_Equipo");

                    b.ToTable("Mantenimientos");
                });

            modelBuilder.Entity("Equipo", b =>
                {
                    b.HasOne("Departamento", "Departamento")
                        .WithMany("Equipos")
                        .HasForeignKey("DepartamentoID_Departamento")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Departamento");
                });

            modelBuilder.Entity("Mantenimiento", b =>
                {
                    b.HasOne("Equipo", "Equipo")
                        .WithMany("Mantenimientos")
                        .HasForeignKey("EquipoID_Equipo")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Equipo");
                });

            modelBuilder.Entity("Departamento", b =>
                {
                    b.Navigation("Equipos");
                });

            modelBuilder.Entity("Equipo", b =>
                {
                    b.Navigation("Mantenimientos");
                });
#pragma warning restore 612, 618
        }
    }
}
