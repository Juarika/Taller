namespace Dominio.Entities.Principales;

public class Ciudad : BaseEntity
{
    public string? Nombre { get; set; }
    public int IdDepartamentoFk { get; set; }
    public Departamento? Departamento{ get; set; }
    public ICollection<Persona>? Personas { get; set; }
}