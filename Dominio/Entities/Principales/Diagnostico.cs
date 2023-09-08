namespace Dominio.Entities.Principales;

public class Diagnostico : BaseEntity
{
    public string Descripcion { get; set; }
    public int IdOrdenFk { get; set; }
    public Orden Orden { get; set; }
    public int IdEmpleadoFk { get; set; }
    public Persona Empleado { get; set; }
    public ICollection<RepuestoDiagnostico> RepuestoDiagnosticos { get; set; }
}