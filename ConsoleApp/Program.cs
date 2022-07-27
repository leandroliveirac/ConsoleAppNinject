using Ninject;
using System.Linq;
using System.Reflection;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var kernel = new StandardKernel();
            kernel.Load(Assembly.GetExecutingAssembly());
            var bpa = kernel.Get<BPA>();
            bpa.Teste();
        }
    }
}
