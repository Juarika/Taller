namespace Dominio.Entities.Principales;

public class RepuestoDiagnostico
{
    public int IdDiagnosticoFk { get; set; }
    public Diagnostico Diagnostico { get; set; }
    public int IdRepuestoFk { get; set; }
    public Repuesto Repuesto { get; set; }
    public int Cantidad { get; set; }
    public bool Aprobado { get; set; } = false;
}