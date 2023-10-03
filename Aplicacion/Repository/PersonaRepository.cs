using Dominio.Entities.Principales;
using Dominio.Interfaces;
using Persistencia;

namespace Aplicacion.Repository;

internal class PersonaRepository : GenericRepository<Persona>, IPersona
{
    private readonly TallerContext _context;

    public PersonaRepository(TallerContext context) : base(context)
    {
        _context = context;
    }
}