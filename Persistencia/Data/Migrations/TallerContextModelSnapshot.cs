﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Persistencia;

#nullable disable

namespace Persistencia.Data.Migrations
{
    [DbContext(typeof(TallerContext))]
    partial class TallerContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Dominio.Entities.Principales.Ciudad", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("IdDepartamentoFk")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("IdDepartamentoFk");

                    b.ToTable("ciudad", (string)null);
                });

            modelBuilder.Entity("Dominio.Entities.Principales.Departamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("IdPaisFk")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("IdPaisFk");

                    b.ToTable("departamento", (string)null);
                });

            modelBuilder.Entity("Dominio.Entities.Principales.Diagnostico", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<int>("IdEmpleadoFk")
                        .HasColumnType("int");

                    b.Property<int>("IdOrdenFk")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdEmpleadoFk");

                    b.HasIndex("IdOrdenFk");

                    b.ToTable("diagnostico", (string)null);
                });

            modelBuilder.Entity("Dominio.Entities.Principales.Email", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<int>("IdPersonaFk")
                        .HasColumnType("int");

                    b.Property<int>("IdTipoEmailFk")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdPersonaFk");

                    b.HasIndex("IdTipoEmailFk");

                    b.ToTable("email", (string)null);
                });

            modelBuilder.Entity("Dominio.Entities.Principales.Factura", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("IdClienteFk")
                        .HasColumnType("int");

                    b.Property<int>("IdOrdenFk")
                        .HasColumnType("int");

                    b.Property<decimal>("Iva")
                        .HasColumnType("decimal");

                    b.Property<decimal>("ManoObra")
                        .HasColumnType("decimal");

                    b.Property<decimal>("Subtotal")
                        .HasColumnType("decimal");

                    b.Property<decimal>("Total")
                        .HasColumnType("decimal");

                    b.HasKey("Id");

                    b.HasIndex("IdClienteFk");

                    b.HasIndex("IdOrdenFk");

                    b.ToTable("factura", (string)null);
                });

            modelBuilder.Entity("Dominio.Entities.Principales.Orden", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("DiagnosticoCliente")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<int>("IdClienteFk")
                        .HasColumnType("int");

                    b.Property<int>("IdManagerFk")
                        .HasColumnType("int");

                    b.Property<int>("IdVehiculoFk")
                        .HasColumnType("int");

                    b.Property<DateTime>("Registro")
                        .HasColumnType("DateTime");

                    b.HasKey("Id");

                    b.HasIndex("IdClienteFk");

                    b.HasIndex("IdManagerFk");

                    b.HasIndex("IdVehiculoFk");

                    b.ToTable("orden", (string)null);
                });

            modelBuilder.Entity("Dominio.Entities.Principales.Pais", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("pais", (string)null);
                });

            modelBuilder.Entity("Dominio.Entities.Principales.Persona", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<int>("IdCiudadFk")
                        .HasColumnType("int");

                    b.Property<int>("IdTipoPersonaFk")
                        .HasColumnType("int");

                    b.Property<DateTime>("Nacimiento")
                        .HasColumnType("DateTime");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("IdCiudadFk");

                    b.HasIndex("IdTipoPersonaFk");

                    b.ToTable("persona", (string)null);
                });

            modelBuilder.Entity("Dominio.Entities.Principales.PersonaEspecialidad", b =>
                {
                    b.Property<int>("IdEspecialidadFk")
                        .HasColumnType("int");

                    b.Property<int>("IdPersonaFk")
                        .HasColumnType("int");

                    b.HasKey("IdEspecialidadFk", "IdPersonaFk");

                    b.HasIndex("IdPersonaFk");

                    b.ToTable("PersonaEspecialidades");
                });

            modelBuilder.Entity("Dominio.Entities.Principales.Repuesto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<decimal>("PrecioVenta")
                        .HasColumnType("decimal");

                    b.HasKey("Id");

                    b.ToTable("repuesto", (string)null);
                });

            modelBuilder.Entity("Dominio.Entities.Principales.RepuestoDiagnostico", b =>
                {
                    b.Property<int>("IdRepuestoFk")
                        .HasColumnType("int");

                    b.Property<int>("IdDiagnosticoFk")
                        .HasColumnType("int");

                    b.Property<bool>("Aprobado")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("Cantidad")
                        .HasColumnType("int");

                    b.HasKey("IdRepuestoFk", "IdDiagnosticoFk");

                    b.HasIndex("IdDiagnosticoFk");

                    b.ToTable("repuestoDiagnostico", (string)null);
                });

            modelBuilder.Entity("Dominio.Entities.Principales.Telefono", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("IdPersonaFk")
                        .HasColumnType("int");

                    b.Property<int>("IdTipoTelefonoFk")
                        .HasColumnType("int");

                    b.Property<string>("Numero")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("IdPersonaFk");

                    b.HasIndex("IdTipoTelefonoFk");

                    b.ToTable("telefono", (string)null);
                });

            modelBuilder.Entity("Dominio.Entities.Principales.Vehiculo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("IdColorFk")
                        .HasColumnType("int");

                    b.Property<int>("IdPersonaFk")
                        .HasColumnType("int");

                    b.Property<double>("Km")
                        .HasColumnType("double");

                    b.Property<string>("Marca")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Modelo")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Placa")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("IdColorFk");

                    b.HasIndex("IdPersonaFk");

                    b.ToTable("vehiculo", (string)null);
                });

            modelBuilder.Entity("Dominio.Entities.Tipos.Color", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Colores");
                });

            modelBuilder.Entity("Dominio.Entities.Tipos.Especialidad", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Especialidades");
                });

            modelBuilder.Entity("Dominio.Entities.Tipos.TipoEmail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("TipoEmails");
                });

            modelBuilder.Entity("Dominio.Entities.Tipos.TipoPersona", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("TipoPersonas");
                });

            modelBuilder.Entity("Dominio.Entities.Tipos.TipoTelefono", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("TipoTelefonos");
                });

            modelBuilder.Entity("Dominio.Entities.Principales.Ciudad", b =>
                {
                    b.HasOne("Dominio.Entities.Principales.Departamento", "Departamento")
                        .WithMany("Ciudades")
                        .HasForeignKey("IdDepartamentoFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Departamento");
                });

            modelBuilder.Entity("Dominio.Entities.Principales.Departamento", b =>
                {
                    b.HasOne("Dominio.Entities.Principales.Pais", "Pais")
                        .WithMany("Departamentos")
                        .HasForeignKey("IdPaisFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pais");
                });

            modelBuilder.Entity("Dominio.Entities.Principales.Diagnostico", b =>
                {
                    b.HasOne("Dominio.Entities.Principales.Persona", "Empleado")
                        .WithMany("Diagnosticos")
                        .HasForeignKey("IdEmpleadoFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Dominio.Entities.Principales.Orden", "Orden")
                        .WithMany("Diagnosticos")
                        .HasForeignKey("IdOrdenFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Empleado");

                    b.Navigation("Orden");
                });

            modelBuilder.Entity("Dominio.Entities.Principales.Email", b =>
                {
                    b.HasOne("Dominio.Entities.Principales.Persona", "Persona")
                        .WithMany("Emails")
                        .HasForeignKey("IdPersonaFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Dominio.Entities.Tipos.TipoEmail", "TipoEmail")
                        .WithMany("Emails")
                        .HasForeignKey("IdTipoEmailFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Persona");

                    b.Navigation("TipoEmail");
                });

            modelBuilder.Entity("Dominio.Entities.Principales.Factura", b =>
                {
                    b.HasOne("Dominio.Entities.Principales.Persona", "Cliente")
                        .WithMany("Facturas")
                        .HasForeignKey("IdClienteFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Dominio.Entities.Principales.Orden", "Orden")
                        .WithMany("Facturas")
                        .HasForeignKey("IdOrdenFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");

                    b.Navigation("Orden");
                });

            modelBuilder.Entity("Dominio.Entities.Principales.Orden", b =>
                {
                    b.HasOne("Dominio.Entities.Principales.Persona", "Cliente")
                        .WithMany("ClienteOrdenes")
                        .HasForeignKey("IdClienteFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Dominio.Entities.Principales.Persona", "Manager")
                        .WithMany("ManagerOrdenes")
                        .HasForeignKey("IdManagerFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Dominio.Entities.Principales.Vehiculo", "Vehiculo")
                        .WithMany("Ordenes")
                        .HasForeignKey("IdVehiculoFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");

                    b.Navigation("Manager");

                    b.Navigation("Vehiculo");
                });

            modelBuilder.Entity("Dominio.Entities.Principales.Persona", b =>
                {
                    b.HasOne("Dominio.Entities.Principales.Ciudad", "Ciudad")
                        .WithMany("Personas")
                        .HasForeignKey("IdCiudadFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Dominio.Entities.Tipos.TipoPersona", "TipoPersona")
                        .WithMany("Personas")
                        .HasForeignKey("IdTipoPersonaFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ciudad");

                    b.Navigation("TipoPersona");
                });

            modelBuilder.Entity("Dominio.Entities.Principales.PersonaEspecialidad", b =>
                {
                    b.HasOne("Dominio.Entities.Tipos.Especialidad", "Especialidad")
                        .WithMany("PersonaEspecialidades")
                        .HasForeignKey("IdEspecialidadFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Dominio.Entities.Principales.Persona", "Persona")
                        .WithMany("PersonaEspecialidades")
                        .HasForeignKey("IdPersonaFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Especialidad");

                    b.Navigation("Persona");
                });

            modelBuilder.Entity("Dominio.Entities.Principales.RepuestoDiagnostico", b =>
                {
                    b.HasOne("Dominio.Entities.Principales.Diagnostico", "Diagnostico")
                        .WithMany("RepuestoDiagnosticos")
                        .HasForeignKey("IdDiagnosticoFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Dominio.Entities.Principales.Repuesto", "Repuesto")
                        .WithMany("RepuestoDiagnosticos")
                        .HasForeignKey("IdRepuestoFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Diagnostico");

                    b.Navigation("Repuesto");
                });

            modelBuilder.Entity("Dominio.Entities.Principales.Telefono", b =>
                {
                    b.HasOne("Dominio.Entities.Principales.Persona", "Persona")
                        .WithMany("Telefonos")
                        .HasForeignKey("IdPersonaFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Dominio.Entities.Tipos.TipoTelefono", "TipoTelefono")
                        .WithMany("Telefonos")
                        .HasForeignKey("IdTipoTelefonoFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Persona");

                    b.Navigation("TipoTelefono");
                });

            modelBuilder.Entity("Dominio.Entities.Principales.Vehiculo", b =>
                {
                    b.HasOne("Dominio.Entities.Tipos.Color", "Color")
                        .WithMany("Vehiculos")
                        .HasForeignKey("IdColorFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Dominio.Entities.Principales.Persona", "Persona")
                        .WithMany("Vehiculos")
                        .HasForeignKey("IdPersonaFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Color");

                    b.Navigation("Persona");
                });

            modelBuilder.Entity("Dominio.Entities.Principales.Ciudad", b =>
                {
                    b.Navigation("Personas");
                });

            modelBuilder.Entity("Dominio.Entities.Principales.Departamento", b =>
                {
                    b.Navigation("Ciudades");
                });

            modelBuilder.Entity("Dominio.Entities.Principales.Diagnostico", b =>
                {
                    b.Navigation("RepuestoDiagnosticos");
                });

            modelBuilder.Entity("Dominio.Entities.Principales.Orden", b =>
                {
                    b.Navigation("Diagnosticos");

                    b.Navigation("Facturas");
                });

            modelBuilder.Entity("Dominio.Entities.Principales.Pais", b =>
                {
                    b.Navigation("Departamentos");
                });

            modelBuilder.Entity("Dominio.Entities.Principales.Persona", b =>
                {
                    b.Navigation("ClienteOrdenes");

                    b.Navigation("Diagnosticos");

                    b.Navigation("Emails");

                    b.Navigation("Facturas");

                    b.Navigation("ManagerOrdenes");

                    b.Navigation("PersonaEspecialidades");

                    b.Navigation("Telefonos");

                    b.Navigation("Vehiculos");
                });

            modelBuilder.Entity("Dominio.Entities.Principales.Repuesto", b =>
                {
                    b.Navigation("RepuestoDiagnosticos");
                });

            modelBuilder.Entity("Dominio.Entities.Principales.Vehiculo", b =>
                {
                    b.Navigation("Ordenes");
                });

            modelBuilder.Entity("Dominio.Entities.Tipos.Color", b =>
                {
                    b.Navigation("Vehiculos");
                });

            modelBuilder.Entity("Dominio.Entities.Tipos.Especialidad", b =>
                {
                    b.Navigation("PersonaEspecialidades");
                });

            modelBuilder.Entity("Dominio.Entities.Tipos.TipoEmail", b =>
                {
                    b.Navigation("Emails");
                });

            modelBuilder.Entity("Dominio.Entities.Tipos.TipoPersona", b =>
                {
                    b.Navigation("Personas");
                });

            modelBuilder.Entity("Dominio.Entities.Tipos.TipoTelefono", b =>
                {
                    b.Navigation("Telefonos");
                });
#pragma warning restore 612, 618
        }
    }
}
