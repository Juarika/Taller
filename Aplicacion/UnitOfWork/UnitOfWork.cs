using Aplicacion.Repository;
using Dominio.Interfaces;
using Persistencia;

namespace Aplicacion.UnitOfWork;

public class UnitOfWork : IUnitOfWork, IDisposable
{
    private readonly TallerContext context;
    private PaisRepository _paises;
    private DepartamentoRepository _departamentos;
    private CiudadRepository _ciudades;
    private PersonaRepository _personas;
    private DiagnosticoRepository _diagnosticos;
    private EspecialidadRepository _especialidades;
    private OrdenRepository _ordenes;
    private RepuestoRepository _repuestos;
    private VehiculoRepository _vehiculos;

    public UnitOfWork(TallerContext _context)
    {
        context = _context;
    }

    public IPais Paises
    {
        get 
        {
            if (_paises == null)
            {
                _paises = new PaisRepository(context);
            }
            return _paises;
        }
    }

    public IDepartamento Departamentos
    {
        get 
        {
            if (_departamentos == null)
            {
                _departamentos = new DepartamentoRepository(context);
            }
            return _departamentos;
        }
    }

    public ICiudad Ciudades
    {
        get 
        {
            if (_ciudades == null)
            {
                _ciudades = new CiudadRepository(context);
            }
            return _ciudades;
        }
    }
    public IPersona Personas
    {
        get 
        {
            if (_personas == null)
            {
                _personas = new PersonaRepository(context);
            }
            return _personas;
        }
    }

    public IDiagnostico Diagnosticos
    {
        get 
        {
            if (_diagnosticos == null)
            {
                _diagnosticos = new DiagnosticoRepository(context);
            }
            return _diagnosticos;
        }
    }

    public IEspecialidad Especialidades
    {
        get 
        {
            if (_especialidades == null)
            {
                _especialidades = new EspecialidadRepository(context);
            }
            return _especialidades;
        }
    }

    public IOrden Ordenes
    {
        get 
        {
            if (_ordenes == null)
            {
                _ordenes = new OrdenRepository(context);
            }
            return _ordenes;
        }
    }

    public IRepuesto Repuestos
    {
        get 
        {
            if (_repuestos == null)
            {
                _repuestos = new RepuestoRepository(context);
            }
            return _repuestos;
        }
    }

    public IVehiculo Vehiculos
    {
        get 
        {
            if (_vehiculos == null)
            {
                _vehiculos = new VehiculoRepository(context);
            }
            return _vehiculos;
        }
    }

    public int Save()
    {
        return context.SaveChanges();
    }
    
    public void Dispose()
    {
        context.Dispose();
    }

    public async Task<int> SaveAsync()
    {
        return await context.SaveChangesAsync(); 
    }
}