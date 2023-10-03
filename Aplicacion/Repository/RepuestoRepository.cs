using Dominio.Entities.Principales;
using Dominio.Interfaces;
using Persistencia;

namespace Aplicacion.Repository;

internal class RepuestoRepository : GenericRepository<Repuesto>, IRepuesto
{
    private readonly TallerContext _context;

    public RepuestoRepository(TallerContext context) : base(context)
    {
        _context = context;
    }
}