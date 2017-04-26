using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GasPump
{
    class DataStorage
    {
        private static DataStorage instance;

        private DataStorage() { }

        public static DataStorage Instance {
            get {
                if (instance == null) {
                    instance = new DataStorage();
                }
                return instance;
            }
        }

        float a1, b1; //GP1: Regular and Super
        int a2, b2, c2, gQ, price, cash, literAmount, gallonAmount; //GP2: Regular, Premium, Super

        public void set1A(float a) {
            a1 = a;
        }

        public void set1B(float b)
        {
            b1 = b;
        }

        public void set2A(int a)
        {
            a2 = a;
        }

        public void set2B(int b)
        {
            b2 = b;
        }

        public void set2C(int c)
        {
            c2 = c;
        }

        public void setGQ(int q) {
            gQ = q;
        }

        public void setPrice(int p) {
            price = p;
        }

        public void set2Cash(int c)
        {
            cash = c;
        }

        public void set2Liter(int l)
        {
            literAmount = l;
        }

        public void set1Gallon(int g)
        {
            gallonAmount = g;
        }

        public float get1A()
        {
            return a1;
        }

        public float get1B()
        {
            return b1;
        }

        public int get2A()
        {
            return a2;
        }

        public int get2B()
        {
            return b2;
        }

        public int get2C()
        {
            return c2;
        }

        public int getGQ() {
            return gQ;
        }

        public int getPrice() {
            return price;
        }

        public int get2Cash()
        {
            return cash;
        }

        public int get2Liter()
        {
            return literAmount;
        }

        public int get1Gallon()
        {
            return gallonAmount;
        }
    }
}
