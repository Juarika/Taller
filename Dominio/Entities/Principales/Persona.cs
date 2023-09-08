using Dominio.Entities.Tipos;

namespace Dominio.Entities.Principales;

public class Persona : BaseEntity
{
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public DateTime Nacimiento { get; set; }
    public int IdTipoPersonaFk { get; set; }
    public TipoPersona TipoPersona { get; set; }
    public int IdCiudadFk { get; set; }
    public Ciudad Ciudad { get; set; }
    public ICollection<Diagnostico> Diagnosticos { get; set; }
    public ICollection<Email> Emails { get; set; }
    public ICollection<Factura> Facturas { get; set; }
    public ICollection<Telefono> Telefonos { get; set; }
    public ICollection<Vehiculo> Vehiculos { get; set; }
    public ICollection<Orden> Ordenes { get; set; }
    public ICollection<PersonaEspecialidad> PersonaEspecialidades { get; set; }
    public ICollection<Especialidad> Especialidades { get; set; } = new HashSet<Especialidad>();
}