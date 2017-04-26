using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GasPump
{
    class PaidState : State
    {
        MDAEFSM mEP = MDAEFSM.Instance;
        OutputProcessor oPP;

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

        }

        public override void reject()
        {

        }

        public override void cancel()
        {
            mEP.changeState(0);
            oPP.cancelMsg();
            oPP.returnCash();
        }

        public override void premium()
        {
            mEP.changeState(4);
            oPP.setPrice(2);
        }

        public override void super()
        {
            mEP.changeState(4);
            oPP.setPrice(1);
        }

        public override void regular()
        {
            mEP.changeState(4);
            oPP.setPrice(0);
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
