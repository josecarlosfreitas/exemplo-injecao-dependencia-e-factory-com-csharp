using ExemploFactory.Domain;
using ExemploFactory.Domain.Entities;
using ExemploFactory.Service;

namespace ExemploFactory.Factory
{
    public class FlorFactory
    {
        public readonly IRosaService _rosaService;
        public readonly IMargaridaService _margaridaService;
        public readonly IOrquideaService _orquideaService;

        public FlorFactory(IRosaService rosaService, IMargaridaService margaridaService, IOrquideaService orquideaService)
        {
            _rosaService = rosaService;
            _margaridaService = margaridaService;
            _orquideaService = orquideaService;
        }

        public Flor gerarFlor(TipoFlorEnum tipoFlor)
        {
            switch (tipoFlor)
            {
                case TipoFlorEnum.ROSA:
                    
                    return _rosaService.CriarFlor();
                    
                case TipoFlorEnum.ORQUIDEA:
                    
                    return _orquideaService.CriarFlor();

                case TipoFlorEnum.MARGARIDA:
                    
                    return _margaridaService.CriarFlor();

                default:
                    break;
            }

            return null;
        }
    }
}
