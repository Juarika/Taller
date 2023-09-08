using Dominio.Entities.Tipos;

namespace Dominio.Entities.Principales;

public class Telefono : BaseEntity
{
    public string Numero { get; set; }
    public int IdTipoTelefonoFk { get; set; }
    public TipoTelefono TipoTelefono { get; set; }
    public int IdPersonaFk { get; set; }
    public Persona Persona { get; set; }
}