namespace Dominio.Entities.Principales;

public class Orden : BaseEntity 
{
    public DateTime Registro { get; set; } = DateTime.Now;
    public string? DiagnosticoCliente { get; set; }
    public string? Estado { get; set;}
    public int IdClienteFk { get; set; }
    public Persona? Cliente { get; set; }
    public int IdManagerFk { get; set; }
    public Persona? Manager { get; set; }
    public int IdVehiculoFk { get; set; }
    public Vehiculo? Vehiculo { get; set; }
}