﻿using System;
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
            oPP.cancelMsg();
            oPP.returnCash();
            mEP.changeState(0);
        }

        public override void premium()
        {
            oPP.setPrice(2);
            mEP.changeState(4);
        }

        public override void super()
        {
            oPP.setPrice(1);
            mEP.changeState(4);
        }

        public override void regular()
        {
            oPP.setPrice(0);
            mEP.changeState(4);
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
