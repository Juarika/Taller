using Dominio.Entities.Tipos;

namespace Dominio.Entities.Principales;

public class Email : BaseEntity
{
    public string Direccion { get; set; }
    public int IdTipoEmailFk { get; set; }
    public TipoEmail TipoEmail { get; set; }
    public int IdPersonaFk { get; set; }
    public Persona Persona { get; set; }
}