using Dominio.Entities.Principales;
using Dominio.Interfaces;
using Persistencia;

namespace Aplicacion.Repository;

public class PaisRepository : GenericRepository<Pais>, IPais
{
    private readonly TallerContext _context;

    public PaisRepository(TallerContext context) : base(context)
    {
        _context = context;
    }
}