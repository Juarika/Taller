using Dominio.Entities.Principales;
using Dominio.Interfaces;
using Persistencia;

namespace Aplicacion.Repository;

internal class OrdenRepository : GenericRepository<Orden>, IOrden
{
    private readonly TallerContext _context;

    public OrdenRepository(TallerContext context) : base(context)
    {
        _context = context;
    }
}