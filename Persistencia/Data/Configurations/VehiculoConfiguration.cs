using Dominio.Entities.Principales;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configurations;

public class VehiculoConfiguration : IEntityTypeConfiguration<Vehiculo>
{
    public void Configure(EntityTypeBuilder<Vehiculo> builder)
    {
        builder.ToTable("vehiculo");

        builder.Property(p => p.Placa)
        .IsRequired()
        .HasMaxLength(50);


        builder.Property(p => p.Marca)
        .IsRequired()
        .HasMaxLength(50);


        builder.Property(p => p.Modelo)
        .IsRequired()
        .HasMaxLength(50);

        builder.Property(p => p.Km)
        .IsRequired()
        .HasColumnType("double");

        builder.HasOne(p => p.Persona)
        .WithMany(p => p.Vehiculos)
        .HasForeignKey(p => p.IdPersonaFk);

        builder.HasOne(p => p.Color)
        .WithMany(p => p.Vehiculos)
        .HasForeignKey(p => p.IdColorFk);
    }
}