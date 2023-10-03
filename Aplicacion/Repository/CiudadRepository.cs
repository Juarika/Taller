using Dominio.Entities.Principales;
using Dominio.Interfaces;
using Persistencia;

namespace Aplicacion.Repository;

public class CiudadRepository : GenericRepository<Ciudad>, ICiudad
{
    private readonly TallerContext _context;

    public CiudadRepository(TallerContext context) : base(context)
    {
        _context = context;
    }
}