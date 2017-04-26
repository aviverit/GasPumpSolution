using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GasPump
{
    class GP1ConcreteFactory : AbstractFactory
    {
        //RegularPriceStrategy rPrice;
        //SuperPriceStrategy sPrice;

        //float rP, sP;

        //DataStorage dS = DataStorage.Instance;

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

        /*public override void setPricePack()
        {
            rP = rPrice.getPrice(dS,1);
            sP = sPrice.getPrice(dS,1);
        }*/


        /*public float getPriceStrat(int gT) {
            if (gT == 0)
            {
                return rP;
            }else  {
                return sP;
            }
        }*/

        public override PayStrategy getPayStrat() {
            return new CreditPaymentStrategy();
        }
    }
}
