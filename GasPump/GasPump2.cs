using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GasPump
{
    class GasPump2
    {
        MDEFSM mEP;
        DataStorage dSP;

        GasPump1()
        {

        }

        public void activate(int a, int b, int c)
        {
            if ((a > 0) && (b > 0) && (c>0))
            {
                dSP.set2A(a);
                dSP.set2B(b);
                dSP.set2C(c);
                mEP.activate();
            }
        }

        public void start()
        {
            mEP.start();
        }

        public void payCash(int c)
        {
            dSP.set2Cash(c);
            mEP.payType(0);
        }

        public void cancel()
        {
            mEP.cancel();
        }

        public void premium()
        {
            mEP.selectGas(2);
        }

        public void super()
        {
            mEP.selectGas(1);
        }

        public void regular()
        {
            mEP.selectGas(0);
        }

        public void startPump()
        {
            mEP.startPump();
        }

        public void pumpLiter()
        {
            if (dSP.get2Cash() < (dSP.get2L() + 1) * dSP.get2Price()) {
                mEP.stopPump();
            }
            mEP.pumpOnce();
        }

        public void stop()
        {
            mEP.stopPump();
        }

        public void receipt() {
            mEP.receipt();
        }

        public void noReceipt() {
            mEP.noReceipt();
        }
    }
}
