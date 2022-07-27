using ConsoleApp.FechamentoProducao.DamianModel;
using ConsoleApp.FechamentoProducao.DamianModel.Interfaces;
using ConsoleApp.FechamentoProducao.DamianModel.Interfaces.Repositories;
using ConsoleApp.FechamentoProducao.Data.Repositories;
using Ninject.Modules;

namespace ConsoleApp
{
    public class DI : NinjectModule
    {
        public override void Load()
        {
            Bind<IFechamentoProducaoRepository>().To<FechamentoProducaoRepository>();
            Bind<IFechamentoProducao>().To<FechamentoProducaoDomain>();
        }
    }
}
