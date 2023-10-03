using Dominio.Entities.Principales;
using Dominio.Interfaces;
using Persistencia;

namespace Aplicacion.Repository;

public class DiagnosticoRepository : GenericRepository<Diagnostico>, IDiagnostico
{
    private readonly TallerContext _context;

    public DiagnosticoRepository(TallerContext context) : base(context)
    {
        _context = context;
    }
}