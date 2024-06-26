using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module17._6._6.Interest
{
    internal class SalaryAccountInterestCalculator : IInterestCalculator
    {
        public double CalcuatorInterest(double balance)
        {
            return balance * 0.5;
        }
    }
}
