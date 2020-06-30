using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DbFirst2.Models
{
    public partial class CLINICAContext : DbContext
    {
        public CLINICAContext()
        {
        }

        public CLINICAContext(DbContextOptions<CLINICAContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Doctores> Doctores { get; set; }
        public virtual DbSet<Pacientes> Pacientes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-H11UTOL\\SSQLEXPRESS;Initial Catalog=CLINICA;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<Doctores>(entity =>
            {
                entity.HasKey(e => e.IdDoctores)
                    .HasName("PK__DOCTORES__47BEEDF8A1309A2B");

                entity.ToTable("DOCTORES");

                entity.Property(e => e.IdDoctores)
                    .HasColumnName("id_doctores")
                    .ValueGeneratedNever();

                entity.Property(e => e.Apellidos)
                    .IsRequired()
                    .HasColumnName("apellidos")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Especialidad)
                    .IsRequired()
                    .HasColumnName("especialidad")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.HospitalTrabajo)
                    .IsRequired()
                    .HasColumnName("hospital_trabajo")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Nombres)
                    .IsRequired()
                    .HasColumnName("nombres")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroCredencial).HasColumnName("numero_credencial");
            });

            modelBuilder.Entity<Pacientes>(entity =>
            {
                entity.HasKey(e => e.IdPacientes)
                    .HasName("PK__PACIENTE__D80336DA13532BC3");

                entity.ToTable("PACIENTES");

                entity.Property(e => e.IdPacientes)
                    .HasColumnName("id_pacientes")
                    .ValueGeneratedNever();

                entity.Property(e => e.Apellidos)
                    .IsRequired()
                    .HasColumnName("apellidos")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoPostal).HasColumnName("codigo_postal");

                entity.Property(e => e.Direccion)
                    .IsRequired()
                    .HasColumnName("direccion")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Edad).HasColumnName("edad");

                entity.Property(e => e.Genero)
                    .IsRequired()
                    .HasColumnName("genero")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.IdDoctores).HasColumnName("id_doctores");

                entity.Property(e => e.Nombres)
                    .IsRequired()
                    .HasColumnName("nombres")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroSeguroSocial).HasColumnName("numero_seguro_social");

                entity.Property(e => e.TelefonoContacto).HasColumnName("telefono_contacto");
            });
        }
    }
}
