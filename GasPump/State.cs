using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GasPump
{
    abstract class State
    {
        MDAEFSM mEP = MDAEFSM.Instance;
        OutputProcessor oPP;

        abstract public void start();
        abstract public void payCash();
        abstract public void payCredit();
        abstract public void reject();
        abstract public void cancel();
        abstract public void approved();
        abstract public void premium();
        abstract public void super();
        abstract public void regular();
        abstract public void startPump();
        abstract public void pumpOnce();
        abstract public void stopPump();
        abstract public void receipt();
        abstract public void noReceipt();
    }
}
