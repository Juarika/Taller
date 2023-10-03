namespace Dominio.Interfaces;

public interface IUnitOfWork
{
    IPais Paises { get; }
    ICiudad Ciudades { get; }
    IDepartamento Departamentos { get; }
    IDiagnostico Diagnosticos { get; }
    IEspecialidad Especialidades { get; }
    IOrden Ordenes { get; }
    IRepuesto Repuestos { get; }
    IVehiculo Vehiculos { get; }
    Task<int> SaveAsync();
}