using Dominio.Entities.Principales;

namespace Dominio.Entities.Tipos;

public class TipoTelefono : BaseEntityTipo
{
    public ICollection<Telefono>? Telefonos { get; set; }
}