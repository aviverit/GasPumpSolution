using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GasPump
{
    class GP2ConcreteFactory : AbstractFactory
    {
        RegularPrice rPrice;
        SuperPrice sPrice;
        PremiumPrice pPrice;

        int rP, sP, pP;

        DataStorage dS = DataStorage.Instance;

        public override void setPricePack()
        {
            rP = rPrice.getPrice(dS,2);
            sP = sPrice.getPrice(dS,2);
            pP = pPrice.getPrice(dS,2);
        }

        public float getPrice(int gT)
        {
            if (gT == 0)
            {
                return rP;
            }
            else if (gT == 1)
            {
                return sP;
            }
            else {
                return pP;
            }
        }
    }
}
