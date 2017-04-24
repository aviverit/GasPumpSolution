using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GasPump
{
    class GP2ConcreteFactory
    {
        RegularPrice rPrice;
        SuperPrice sPrice;
        PremiumPrice pPrice;

        public override void setPricePack()
        {
            rPrice.getPrice();
            sPrice.getPrice();
            pPrice.getPrice();
        }
    }
}
