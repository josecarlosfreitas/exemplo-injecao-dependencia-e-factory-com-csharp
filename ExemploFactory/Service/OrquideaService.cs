using ExemploFactory.Domain;
using ExemploFactory.Domain.Entities;

namespace ExemploFactory.Service
{
    class OrquideaService : IOrquideaService
    {
        public Flor _flor;

        public OrquideaService(Flor flor)
        {
            _flor = flor;
        }
        public Flor CriarFlor()
        {
            _flor.Nome = TipoFlorEnum.ORQUIDEA.ToString();
            _flor.tipoFlor = TipoFlorEnum.ORQUIDEA;

            return _flor;
        }
    }
}
