using ExemploFactory.Domain;
using ExemploFactory.Domain.Entities;

namespace ExemploFactory.Service
{
    public class MargaridaService : IMargaridaService
    {
        public Flor _flor;

        public MargaridaService(Flor flor)
        {
            _flor = flor;
        }
        public Flor CriarFlor()
        {
            _flor.Nome = TipoFlorEnum.MARGARIDA.ToString();
            _flor.tipoFlor = TipoFlorEnum.MARGARIDA;

            return _flor;
        }
    }
}
