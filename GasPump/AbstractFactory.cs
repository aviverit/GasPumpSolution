using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GasPump
{
    abstract class AbstractFactory
    {
        abstract public PriceStrategy getPriceStrat(int gT);

    }
}
