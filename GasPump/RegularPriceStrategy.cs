﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GasPump
{
    class RegularPriceStrategy : PriceStrategy
    {
        DataStorage dS = DataStorage.Instance;

        public override float getPrice1()
        {
                return dS.get1A();
        }

        public override int getPrice2()
        {
            return dS.get2A();
        }
    }
}
