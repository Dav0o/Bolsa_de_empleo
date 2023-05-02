using DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Data
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options)
            : base(options)
        {

        }

        public DbSet<Candidato> Candidatos { get; set; }

        public DbSet<Formacion_Academica> Formaciones { get; set; }

        public DbSet<Experiencia> Experiencias { get; set; }

        public DbSet<Habilidad> Habilidades { get; set;}

        public DbSet<Empresa> Empresas { get; set; }

        public DbSet<Oferta_Laboral> Ofertas_Laborales { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // One to Many
            //Candidato -> Formacion_Academica
            modelBuilder.Entity<Formacion_Academica>()
            .HasOne<Candidato>(formaciones => formaciones.Candidato)
            .WithMany(candidato => candidato.Formaciones)
            .HasForeignKey(k => k.CandidatoId);

            //Candidato -> Experiencia

            modelBuilder.Entity<Experiencia>()
             .HasOne<Candidato>(experiencias => experiencias.Candidato)
             .WithMany(candidato => candidato.Experiencias)
             .HasForeignKey(k => k.CandidatoId);


            // Many to Many

            //Candidato -> Habilidad

            modelBuilder.Entity<Candidato>()
                .HasMany(candidato => candidato.Habilidades)
                .WithMany(habilidades => habilidades.Candidatos)
                .UsingEntity(j => j.ToTable("CandidatoHabilidad"));


            // One to Many
            //Empresa -> Ofertas_Labo
            modelBuilder.Entity<Oferta_Laboral>()
            .HasOne<Empresa>(ofertas => ofertas.Empresa)
            .WithMany(empresa => empresa.Ofertas)
            .HasForeignKey(k => k.EmpresaId);

        }
    }
}
