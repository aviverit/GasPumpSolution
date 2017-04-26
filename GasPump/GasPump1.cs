using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GasPump
{
    class GasPump1
    {
        MDAEFSM mEP = MDAEFSM.Instance;
        DataStorage dSP = DataStorage.Instance;

        GasPump1()
        {
            
        }

        public void activate(float a, float b) {
            if ((a > 0) && (b > 0)) {
                dSP.set1A(a);
                dSP.set1B(b);
                mEP.activate();
            }
        }

        public void start() {
            mEP.start();
        }

        public void payCredit() {
            mEP.payType(1);
        }

        public void reject() {
            mEP.reject();
        }

        public void cancel() {
            mEP.cancel();
        }

        public void approved() {
            mEP.approved();
        }

        public void super() {
            mEP.selectGas(1);
        }

        public void regular() {
            mEP.selectGas(0);
        }

        public void startPump() {
            mEP.startPump();
        }

        public void pumpGallon() {
            mEP.pumpOnce();
        }

        public void stopPump() {
            mEP.stopPump();
            mEP.receipt();
        }
    }
}

