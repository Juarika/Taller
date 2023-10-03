using Dominio.Entities.Principales;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configurations;

public class PersonaConfiguration : IEntityTypeConfiguration<Persona>
{
    public void Configure(EntityTypeBuilder<Persona> builder)
    {
        builder.ToTable("persona");

        builder.Property(p => p.Nombre)
        .IsRequired()
        .HasMaxLength(50);

        builder.Property(p => p.Apellido)
        .IsRequired()
        .HasMaxLength(50);

        builder.Property(p => p.Nacimiento)
        .IsRequired()
        .HasColumnType("DateTime");

        builder.HasOne(p => p.TipoPersona)
        .WithMany(p => p.Personas)
        .HasForeignKey(p => p.IdTipoPersonaFk);

        builder.HasOne(p => p.Ciudad)
        .WithMany(p => p.Personas)
        .HasForeignKey(p => p.IdCiudadFk);

         builder
        .HasMany(p => p.Especialidades)
        .WithMany(p => p.Personas)
        .UsingEntity<PersonaEspecialidad>(
            j => j
                .HasOne(pt => pt.Especialidad)
                .WithMany(t => t.PersonaEspecialidades)
                .HasForeignKey(pt => pt.IdEspecialidadFk),
            j => j
                .HasOne(pt => pt.Persona)
                .WithMany(p => p.PersonaEspecialidades)
                .HasForeignKey(pt => pt.IdPersonaFk),
            j => 
            {
                j.HasKey(pt => new { pt.IdEspecialidadFk, pt.IdPersonaFk });
            }
        );
    }
}