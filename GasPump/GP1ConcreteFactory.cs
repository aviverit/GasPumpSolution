using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GasPump
{
    class GP1ConcreteFactory : AbstractFactory
    {
        RegularPrice rPrice;
        SuperPrice sPrice;

        public override void setPricePack()
        {
            rPrice.getPrice();
            sPrice.getPrice();
        }
    }
}
