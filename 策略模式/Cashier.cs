﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 策略模式
{
    abstract class Cashier
    {
        public abstract double DiscountMoney(double money);
    }
}
