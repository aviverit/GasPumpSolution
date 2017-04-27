using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GasPump
{
    public sealed class MDAEFSM //This class is a singleton for the purpose of facilitating state change.
    {
        private State sP;
        State[] lS;

        private static MDAEFSM instance = new MDAEFSM();

        static MDAEFSM() { }

        private MDAEFSM() {
            ActivatedState aS = new ActivatedState();
            StartedState sS = new StartedState();
            CreditState cS = new CreditState();
            PaidState pS = new PaidState();
            SelectedState selS = new SelectedState();
            DispensingState dS = new DispensingState();
            ReceiptState rS = new ReceiptState();

            lS = new State[7] { aS,
                                sS,
                                cS,
                                pS,
                                selS,
                                dS,
                                rS};
            
        }   

        public static MDAEFSM Instance
        {
            get { return instance; }
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
