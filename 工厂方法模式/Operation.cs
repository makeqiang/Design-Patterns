﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 工厂方法模式
{
    class Operation
    {
        public double NumberA { get; set; }
        public double NumberB { get; set; }
        public virtual double GetResult()
        {
            double res = 0;
            return res;
        }
    }
}
