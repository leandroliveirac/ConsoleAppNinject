using ConsoleApp.FechamentoProducao.DamianModel;
using ConsoleApp.FechamentoProducao.DamianModel.Interfaces;
using System;

namespace ConsoleApp
{
    public class BPA
    {
        private readonly IFechamentoProducao _fechamentoProducao;

        public BPA(IFechamentoProducao fechamentoProducao)
        {
            _fechamentoProducao = fechamentoProducao;
        }

        public void Teste()
        {
            Console.WriteLine(_fechamentoProducao.Teste()); 
        }
    }
}
