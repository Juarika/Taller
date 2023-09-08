namespace Dominio.Entities.Principales;

public class Factura : BaseEntity
{
    public decimal Subtotal { get; set; }
    public decimal Iva { get; set; }
    public decimal ManoObra { get; set; }
    public decimal Total { get; set; }
    public int IdClienteFk { get; set; }
    public Persona Cliente { get; set; }
    public int IdOrdenFk { get; set; }
    public Orden Orden { get; set; }
}