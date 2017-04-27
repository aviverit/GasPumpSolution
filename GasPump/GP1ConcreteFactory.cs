using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GasPump
{
    class GP1ConcreteFactory : AbstractFactory
    {

        public override PriceStrategy getPriceStrat(int gT)
        {
            if (gT == 0)
            {
                return new RegularPriceStrategy();
            }
            else
            {
                return new SuperPriceStrategy();
            }
        }
    }
}
