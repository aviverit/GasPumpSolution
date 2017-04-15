using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GasPump
{
    class MDAEFSM
    {
        State sP;
        State[] lS;

        MDAEFSM()
        {
            lS[0] = new ActivatedState();
            lS[1] = new StartedState();
            lS[2] = new CreditState();
            lS[3] = new PaidState();
            lS[4] = new SelectedState();
            lS[5] = new DispensingState();
            lS[6] = new ReceiptState();
        }

        public void changeState(int s) {
            sP = lS[s];
        }

        public void activate()
        {
            if ((a > 0) && (b > 0))
            {
                mEP.activate();
            }
        }

        public void start()
        {
            mEP.start();
        }

        public void payCredit()
        {
            mEP.payType(1);
        }

        public void reject()
        {
            mEP.reject();
        }

        public void cancel()
        {
            mEP.cancel();
        }

        public void approved()
        {
            mEP.approved();
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

        public void pumpGallon()
        {
            mEP.pumpOnce();
        }

        public void stopPump()
        {
            mEP.stopPump();
            mEP.receipt();
        }

    }
}
