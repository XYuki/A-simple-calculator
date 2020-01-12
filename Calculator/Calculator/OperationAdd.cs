﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    /// <summary>
    /// 加法类，继承自Operation运算类基类
    /// </summary>
    public class OperationAdd : Operation
    {
        /// <summary>
        /// 重写父方法:GetResult
        /// </summary>
        /// <returns></returns>
        public override double GetResult()
        {
            double result = 0;
            result = NumberA + NumnberB;
            return result;
        }
    }
}
