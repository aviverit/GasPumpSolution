using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GasPump
{
    class DispensingState : State
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

        }

        public override void reject()
        {

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
            oPP.pumpOnce();
            oPP.gasPumpedMsg();
        }

        public override void stopPump()
        {
            oPP.stopMsg();
            mEP.changeState(6);
        }

        public override void receipt()
        {

        }

        public override void noReceipt()
        {

        }
    }
}
