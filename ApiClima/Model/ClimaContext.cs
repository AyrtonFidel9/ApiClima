using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace ApiClima.Model
{
    public partial class ClimaContext : DbContext
    {
        public ClimaContext()
        {

        }

        public ClimaContext(DbContextOptions<ClimaContext> options)
            : base(options)
        {

        }

        public virtual DbSet<Clima> Climas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=localhost;Database=dbClima;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Modern_Spanish_CI_AS");

            modelBuilder.Entity<Clima>(entity =>
            {
                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Ciudad)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ciudad");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("descripcion")
                    .HasComputedColumnSql("(case when [Temperatura]>(20) then 'Calido' else 'Frio' end)", false);

                entity.Property(e => e.Humedad).HasColumnName("humedad");

                entity.Property(e => e.Pais)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("pais");

                entity.Property(e => e.ProbPrecipitaciones).HasColumnName("probPrecipitaciones");

                entity.Property(e => e.Sensacion)
                    .HasColumnName("sensacion")
                    .HasComputedColumnSql("((((13.12)+(0.6215)*[Temperatura])-(11.37)*power([VIENTO],(0.16)))+((0.3965)*[Temperatura])*power([VIENTO],(0.16)))", false);

                entity.Property(e => e.Temperatura).HasColumnName("temperatura");

                entity.Property(e => e.Viento).HasColumnName("viento");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
