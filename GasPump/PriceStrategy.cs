using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GasPump
{
    abstract class PriceStrategy
    {
        abstract public float getPrice1();
        abstract public int getPrice2();
    }
}
