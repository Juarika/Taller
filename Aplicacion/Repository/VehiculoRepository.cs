using Dominio.Entities.Principales;
using Dominio.Interfaces;
using Persistencia;

namespace Aplicacion.Repository;

internal class VehiculoRepository : GenericRepository<Vehiculo>, IVehiculo
{
    private readonly TallerContext _context;

    public VehiculoRepository(TallerContext context) : base(context)
    {
        _context = context;
    }
}