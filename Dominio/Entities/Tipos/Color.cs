using Dominio.Entities.Principales;

namespace Dominio.Entities.Tipos;

public class Color : BaseEntityTipo
{
    public ICollection<Vehiculo> Vehiculos { get; set; }
}