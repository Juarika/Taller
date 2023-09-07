using System.Reflection;
using Dominio.Entities.Principales;
using Dominio.Entities.Tipos;
using Microsoft.EntityFrameworkCore;

namespace Persistencia;

public class TallerContext : DbContext
{
    public TallerContext(DbContextOptions<TallerContext> options) : base(options)
    {}

    public DbSet<Pais> Paises { get; set; }
    public DbSet<Departamento> Departamentos { get; set; }
    public DbSet<Ciudad> Ciudades { get; set; }
    public DbSet<Diagnostico> Diagnosticos { get; set; }
    public DbSet<Email> Emails { get; set; }
    public DbSet<Factura> Facturas { get; set; }
    public DbSet<Orden> Ordenes { get; set; }
    public DbSet<Persona> Personas { get; set; }
    public DbSet<Repuesto> Repuestos { get; set; }
    public DbSet<PersonaEspecialidad> PersonaEspecialidades { get; set; }
    public DbSet<RepuestoDiagnostico> RepuestoDiagnosticos { get; set; }
    public DbSet<Telefono> Telefonos { get; set; }
    public DbSet<Vehiculo> Vehiculos { get; set; }
    public DbSet<Color> Colores { get; set; }
    public DbSet<TipoEmail> TipoEmails { get; set; }
    public DbSet<TipoPersona> TipoPersonas { get; set; }
    public DbSet<TipoTelefono> TipoTelefonos { get; set; }
    public DbSet<Especialidad> Especialidades { get; set; }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}