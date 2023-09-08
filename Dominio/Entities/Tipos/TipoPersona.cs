using Dominio.Entities.Principales;

namespace Dominio.Entities.Tipos;

public class TipoPersona : BaseEntityTipo
{
    public ICollection<Persona> Personas { get; set; }
}