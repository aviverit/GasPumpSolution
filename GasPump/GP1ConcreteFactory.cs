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

        DataStorage dS = DataStorage.Instance;

        public override void setPricePack()
        {
            rPrice.getPrice(dS,1);
            sPrice.getPrice(dS,1);
        }
    }
}
