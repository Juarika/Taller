using Dominio.Entities.Principales;
using Dominio.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistencia;

namespace Aplicacion.Repository;

public class PaisRepository : GenericRepository<Pais>, IPais
{
    private readonly TallerContext _context;

    public PaisRepository(TallerContext context) : base(context)
    {
        _context = context;
    }

    public override async Task<IEnumerable<Pais>> GetAllAsync()
    {
        return await _context.Paises
                                .Include(p => p.Departamentos)
                                .ToListAsync();
    }
}