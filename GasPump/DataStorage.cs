﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GasPump
{
    class DataStorage
    {
        float a1, b1;
        int a2, b2, c2, cash;

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

        public void set2Cash(int c)
        {
            cash = c;
        }
    }
}
