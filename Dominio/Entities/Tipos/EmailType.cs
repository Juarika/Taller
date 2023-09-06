using Dominio.Entities.Principales;

namespace Dominio.Entities.Tipos;

public class TipoEmail : BaseEntityTipo
{
    public ICollection<Email>? Emails { get; set; }
}