using Dominio.Entities.Tipos;

namespace Dominio.Entities.Principales;

public class PersonaEspecialidad
{
    public int IdPersonaFk { get; set; }
    public Persona Persona { get; set; }
    public int IdEspecialidadFk { get; set; }
    public Especialidad Especialidad { get; set; }
}