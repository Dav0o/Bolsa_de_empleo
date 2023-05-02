﻿// <auto-generated />
using DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataAccess.Migrations
{
    [DbContext(typeof(MyDbContext))]
    [Migration("20230429171724_BaseCandidato")]
    partial class BaseCandidato
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CandidatoHabilidad", b =>
                {
                    b.Property<int>("CandidatosId")
                        .HasColumnType("int");

                    b.Property<int>("HabilidadesId")
                        .HasColumnType("int");

                    b.HasKey("CandidatosId", "HabilidadesId");

                    b.HasIndex("HabilidadesId");

                    b.ToTable("CandidatoHabilidad", (string)null);
                });

            modelBuilder.Entity("DataAccess.Models.Candidato", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Apellido1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Apellido2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Correo_Electronico")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Telefono")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Candidatos");
                });

            modelBuilder.Entity("DataAccess.Models.Experiencia", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CandidatoId")
                        .HasColumnType("int");

                    b.Property<string>("Rol_Desempeñado")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tiempo_Desempeñado")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CandidatoId");

                    b.ToTable("Experiencias");
                });

            modelBuilder.Entity("DataAccess.Models.Formacion_Academica", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CandidatoId")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tipo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CandidatoId");

                    b.ToTable("Formaciones");
                });

            modelBuilder.Entity("DataAccess.Models.Habilidad", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Habilidades");
                });

            modelBuilder.Entity("CandidatoHabilidad", b =>
                {
                    b.HasOne("DataAccess.Models.Candidato", null)
                        .WithMany()
                        .HasForeignKey("CandidatosId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataAccess.Models.Habilidad", null)
                        .WithMany()
                        .HasForeignKey("HabilidadesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DataAccess.Models.Experiencia", b =>
                {
                    b.HasOne("DataAccess.Models.Candidato", "Candidato")
                        .WithMany("Experiencias")
                        .HasForeignKey("CandidatoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Candidato");
                });

            modelBuilder.Entity("DataAccess.Models.Formacion_Academica", b =>
                {
                    b.HasOne("DataAccess.Models.Candidato", "Candidato")
                        .WithMany("Formaciones")
                        .HasForeignKey("CandidatoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Candidato");
                });

            modelBuilder.Entity("DataAccess.Models.Candidato", b =>
                {
                    b.Navigation("Experiencias");

                    b.Navigation("Formaciones");
                });
#pragma warning restore 612, 618
        }
    }
}