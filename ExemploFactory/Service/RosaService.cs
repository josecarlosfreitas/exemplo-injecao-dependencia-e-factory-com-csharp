using ExemploFactory.Domain;
using ExemploFactory.Domain.Entities;

namespace ExemploFactory.Service
{
    class RosaService : IRosaService
    {
        public Flor _flor;

        public RosaService(Flor flor)
        {
            _flor = flor;
        }

        public Flor CriarFlor()
        {
            _flor.Nome = TipoFlorEnum.ROSA.ToString();
            _flor.tipoFlor = TipoFlorEnum.ROSA;

            return _flor;
        }
    }
}
