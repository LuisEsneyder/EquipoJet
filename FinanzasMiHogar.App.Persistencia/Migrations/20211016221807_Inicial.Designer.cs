﻿// <auto-generated />
using System;
using FinanzasMiHogar.App.Persistencia;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FinanzasMiHogar.App.Persistencia.Migrations
{
    [DbContext(typeof(AppContext))]
    [Migration("20211016221807_Inicial")]
    partial class Inicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("FinanzasMiHogar.App.Dominio.Gastos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("TipoGasto")
                        .HasColumnType("int");

                    b.Property<int?>("UsuariosId")
                        .HasColumnType("int");

                    b.Property<DateTime>("fechaPago")
                        .HasColumnType("datetime2");

                    b.Property<int>("montoDinero")
                        .HasColumnType("int");

                    b.Property<string>("nombreGastos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("periodoGastos")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UsuariosId");

                    b.ToTable("gasto");
                });

            modelBuilder.Entity("FinanzasMiHogar.App.Dominio.Usuarios", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("contraseña")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("correoElectronico")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nombreUsuario")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("topeGastos")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("usuario");
                });

            modelBuilder.Entity("FinanzasMiHogar.App.Dominio.Gastos", b =>
                {
                    b.HasOne("FinanzasMiHogar.App.Dominio.Usuarios", null)
                        .WithMany("gasto")
                        .HasForeignKey("UsuariosId");
                });

            modelBuilder.Entity("FinanzasMiHogar.App.Dominio.Usuarios", b =>
                {
                    b.Navigation("gasto");
                });
#pragma warning restore 612, 618
        }
    }
}