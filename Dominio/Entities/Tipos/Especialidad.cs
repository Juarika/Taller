using Dominio.Entities.Principales;

namespace Dominio.Entities.Tipos;

public class Especialidad : BaseEntityTipo
{
    public ICollection<PersonaEspecialidad> PersonaEspecialidades { get; set; }
    public ICollection<Persona> Personas { get; set; } = new HashSet<Persona>();
}