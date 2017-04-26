using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GasPump
{
    class ActivatedState : State
    {
        MDAEFSM mEP = MDAEFSM.Instance;
        OutputProcessor oPP;

        public override void start()
        {
            oPP.payMsg();
            mEP.changeState(1);
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
