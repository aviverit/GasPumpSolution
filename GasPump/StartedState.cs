using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GasPump
{
    class StartedState : State
    {
        MDAEFSM mEP = MDAEFSM.Instance;
        OutputProcessor oPP = new OutputProcessor();

        public override void start()
        {

        }

        public override void payCash()
        {
            oPP.displayMenu();
            mEP.changeState(3);
        }

        public override void payCredit()
        {
            mEP.changeState(2);
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
