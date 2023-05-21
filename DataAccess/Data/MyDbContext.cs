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

        //Many to many config

        public DbSet<CandidatoHabilidad> CandidatoHabilidad { get; set; } = default!;
        public DbSet<OfertaHabilidad> OfertaHabilidad { get; set; } = default!;
        public DbSet<CandidatoOferta> CandidatoOferta { get; set; } = default!;

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



            // One to Many
            //Empresa -> Ofertas_Labo
            modelBuilder.Entity<Oferta_Laboral>()
            .HasOne<Empresa>(ofertas => ofertas.Empresa)
            .WithMany(empresa => empresa.Ofertas)
            .HasForeignKey(k => k.EmpresaId);

            // CandidatoHabilidad

            modelBuilder.Entity<CandidatoHabilidad>()
            .HasKey(ch => new { ch.CandidatoId, ch.HabilidadId });

            modelBuilder.Entity<CandidatoHabilidad>()
                .HasOne(ch => ch.Candidato)
                .WithMany(c => c.CandidatoHabilidades)
                .HasForeignKey(ch => ch.CandidatoId);

            modelBuilder.Entity<CandidatoHabilidad>()
                .HasOne(ch => ch.Habilidad)
                .WithMany(h => h.CandidatoHabilidades)
                .HasForeignKey(ch => ch.HabilidadId);

            // OfertaHabilidad

            modelBuilder.Entity<OfertaHabilidad>()
            .HasKey(ch => new { ch.OfertaId, ch.HabilidadId });

            modelBuilder.Entity<OfertaHabilidad>()
                .HasOne(ch => ch.Oferta)
                .WithMany(c => c.OfertaHabilidades)
                .HasForeignKey(ch => ch.OfertaId);

            modelBuilder.Entity<OfertaHabilidad>()
                .HasOne(ch => ch.Habilidad)
                .WithMany(h => h.OfertaHabilidades)
                .HasForeignKey(ch => ch.HabilidadId);

            // CandidatoOferta

            modelBuilder.Entity<CandidatoOferta>()
            .HasKey(ch => new { ch.CandidatoId, ch.OfertaId });

            modelBuilder.Entity<CandidatoOferta>()
                .HasOne(ch => ch.Candidato)
                .WithMany(c => c.CandidatoOfertas)
                .HasForeignKey(ch => ch.CandidatoId);

            modelBuilder.Entity<CandidatoOferta>()
                .HasOne(ch => ch.Oferta)
                .WithMany(h => h.CandidatoOfertas)
                .HasForeignKey(ch => ch.OfertaId);
        

        }
    }
}
