using Dominio.Entities.Tipos;
using Dominio.Interfaces;
using Persistencia;

namespace Aplicacion.Repository;

public class EspecialidadRepository : GenericTypeRepository<Especialidad>, IEspecialidad
{
    private readonly TallerContext _context;

    public EspecialidadRepository(TallerContext context) : base(context)
    {
        _context = context;
    }
}