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

        DataStorage dS = DataStorage.Instance;

        public override void setPricePack()
        {
            rPrice.getPrice(dS,2);
            sPrice.getPrice(dS,2);
            pPrice.getPrice(dS,2);
        }
    }
}
