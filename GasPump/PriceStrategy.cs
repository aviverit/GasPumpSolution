using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GasPump
{
    abstract class PriceStrategy
    {
        abstract public void forwardPriceRequest();
        abstract public float getPriceStrat1();
        abstract public int getPriceStrat2();
    }
}
