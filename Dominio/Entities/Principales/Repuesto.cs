namespace Dominio.Entities.Principales;

public class Repuesto : BaseEntity
{
    public decimal PrecioVenta { get; set;}
    public ICollection<RepuestoDiagnostico> RepuestoDiagnostico { get; set; }
}