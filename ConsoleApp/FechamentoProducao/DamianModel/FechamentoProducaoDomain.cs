using ConsoleApp.FechamentoProducao.DamianModel.Interfaces;
using ConsoleApp.FechamentoProducao.DamianModel.Interfaces.Repositories;

namespace ConsoleApp.FechamentoProducao.DamianModel
{
    public class FechamentoProducaoDomain : IFechamentoProducao
    {
        private readonly IFechamentoProducaoRepository _fechamentoProducaoRepository;

        public FechamentoProducaoDomain(IFechamentoProducaoRepository fechamentoProducaoRepository)
        {
            _fechamentoProducaoRepository = fechamentoProducaoRepository;
        }

        public string Teste()
        {
            return _fechamentoProducaoRepository.Teste();
        }
    }
}
