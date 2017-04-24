using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GasPump
{
    class RegularPrice : PriceStrategy
    {

        public override void getPrice(DataStorage dS)
        {
            return dS.getRegularPrice();
        }
    }
}
