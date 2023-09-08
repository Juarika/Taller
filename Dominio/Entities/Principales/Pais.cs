namespace Dominio.Entities.Principales;

public class Pais : BaseEntity
{
    public string Nombre { get; set; }
    public ICollection<Departamento> Departamentos{ get; set; }
}