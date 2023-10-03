namespace Dominio.Entities.Principales;

public class Repuesto : BaseEntity
{
    public string Nombre { get; set; }
    public decimal PrecioVenta { get; set;}
    public ICollection<RepuestoDiagnostico> RepuestoDiagnosticos { get; set; }
}