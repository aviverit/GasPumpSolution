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

        private static MDAEFSM instance;

        private MDAEFSM() {
            lS[0] = new ActivatedState();
            lS[1] = new StartedState();
            lS[2] = new CreditState();
            lS[3] = new PaidState();
            lS[4] = new SelectedState();
            lS[5] = new DispensingState();
            lS[6] = new ReceiptState();
        }

        public static MDAEFSM Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new MDAEFSM();
                }
                return instance;
            }
        }



        public void changeState(int s) {
            sP = lS[s];
        }

        public void activate()
        {
            sP = lS[0];
        }

        public void start()
        {
            sP.start();
        }

        public void payType(int ct)
        {
            if (ct == 0)
            {
                sP.payCash();
            }
            else if (ct == 1) {
                sP.payCredit();
            }
        }

        public void reject()
        {
            sP.reject();
        }

        public void cancel()
        {
            sP.cancel();
        }

        public void approved()
        {
            sP.approved();
        }

        public void selectGas(int gt)
        {
            if (gt == 0)
            {
                sP.regular();
            }
            else if (gt == 1)
            {
                sP.super();
            }
            else if (gt == 2)
            {
                sP.premium();
            } 
        }

        public void startPump()
        {
            sP.startPump();
        }

        public void pumpOnce()
        {
            sP.pumpOnce();
        }

        public void stopPump()
        {
            sP.stopPump();
        }

        public void receipt() {
            sP.receipt();
        }

        public void noReceipt() {
            sP.noReceipt();
        }
    }
}
