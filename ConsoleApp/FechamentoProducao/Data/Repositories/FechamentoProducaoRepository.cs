using ConsoleApp.FechamentoProducao.DamianModel.Interfaces.Repositories;

namespace ConsoleApp.FechamentoProducao.Data.Repositories
{
    public class FechamentoProducaoRepository : IFechamentoProducaoRepository
    {

        public string Teste()
        {
            return "Injeção de dependencia com Ninject";
        }
    }
}
