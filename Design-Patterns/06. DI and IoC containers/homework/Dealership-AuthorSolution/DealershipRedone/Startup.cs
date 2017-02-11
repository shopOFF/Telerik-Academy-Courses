using Dealership.Engine;
using DealershipRedone;
using Ninject;

namespace Dealership
{
    public class Startup
    {
        public static void Main()
        {
            IKernel kernel = new StandardKernel(new DealershipModule());

            IEngine dealerEngine = kernel.Get<IEngine>();
            dealerEngine.Start();
        }
    }
}
