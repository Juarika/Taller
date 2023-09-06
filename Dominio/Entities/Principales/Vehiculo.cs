using System.Drawing;

namespace Dominio.Entities.Principales;

public class Vehiculo : BaseEntity
{
    public string? Placa { get; set; }
    public string? Marca { get; set; }
    public string? Modelo { get; set; }
    public double? Km { get; set; }
    public int IdPersonaFk { get; set; }
    public Persona? Persona { get; set; }
    public int IdColorFk { get; set; }
    public Color? Color { get; set; }
}