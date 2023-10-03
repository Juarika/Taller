using Dominio.Entities.Principales;
using Dominio.Interfaces;
using Persistencia;

namespace Aplicacion.Repository;

public class DepartamentoRepository : GenericRepository<Departamento>, IDepartamento
{
    private readonly TallerContext _context;

    public DepartamentoRepository(TallerContext context) : base(context)
    {
        _context = context;
    }
}