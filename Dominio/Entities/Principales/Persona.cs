using Dominio.Entities.Tipos;

namespace Dominio.Entities.Principales;

public class Persona : BaseEntity
{
    public string? Nombre { get; set; }
    public string? Apellido { get; set; }
    public DateTime Nacimiento { get; set; }
    public int IdTipoPersonaFk { get; set; }
    public TipoPersona? TipoPersona { get; set; }
    public int IdCiudadFk { get; set; }
    public Ciudad? Ciudad { get; set; }
    // public ICollection<Producto> Productos { get; set; } = new HashSet<Producto>();
    // public ICollection<ProductoPerson>? ProductosPerson { get; set; }
}