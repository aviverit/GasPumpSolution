using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GasPump
{
    abstract class State
    {
        MDAEFSM * mEP;

        abstract public void start();
        abstract public void payCash(int c);
        abstract public void payCredit();
        abstract public void Reject();
        abstract public void cancel();
        abstract public void approved();
        abstract public void premium();
        abstract public void super();
        abstract public void regular();
        abstract public void startPump();
        abstract public void pumpLiter();
        abstract public void pumpGallon();
        abstract public void stopPump();
        abstract public void receipt();
        abstract public void noReceipt();
    }
}
