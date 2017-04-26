using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GasPump
{
    class CreditState : State
    {

        MDAEFSM mEP = MDAEFSM.Instance;
        OutputProcessor oPP = new OutputProcessor();

        public override void start()
        {

        }

        public override void payCash()
        {

        }

        public override void payCredit()
        {

        }

        public override void approved()
        {
            oPP.displayMenu();
            mEP.changeState(3);
        }

        public override void reject()
        {
            oPP.rejectMsg();
            mEP.changeState(0);
        }

        public override void cancel()
        {

        }

        public override void premium()
        {

        }

        public override void super()
        {

        }

        public override void regular()
        {

        }

        public override void startPump()
        {

        }

        public override void pumpOnce()
        {

        }

        public override void stopPump()
        {

        }

        public override void receipt()
        {

        }

        public override void noReceipt()
        {

        }
    }
}
