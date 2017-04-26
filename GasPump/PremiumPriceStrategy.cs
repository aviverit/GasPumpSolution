using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GasPump
{
    class PremiumPriceStrategy : PriceStrategy
    {
        DataStorage dS = DataStorage.Instance;

        public override float getPrice1()
        {
            return -1.00f;
        }

        public override int getPrice2()
        {
            return dS.get2B();
        }
    }
}
