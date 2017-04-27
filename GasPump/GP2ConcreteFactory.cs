using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GasPump
{
    class GP2ConcreteFactory : AbstractFactory
    {

        public override PriceStrategy getPriceStrat(int gT)
        {
            if (gT == 0)
            {
                return new RegularPriceStrategy();
            }
            else if (gT == 1)
            {
                return new SuperPriceStrategy();
            }
            else
            {
                return new PremiumPriceStrategy();
            }
        }
    }
}
