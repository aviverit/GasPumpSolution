using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GasPump
{
    class RegularPriceStrategy : PriceStrategy
    {

        public override float getPrice(DataStorage dS, int gPT)
        {
            if (gPT==1) {
                return dS.get1A();
            } else if (gPT==2) {
                return dS.get2A();
            }
            
        }
    }
}
