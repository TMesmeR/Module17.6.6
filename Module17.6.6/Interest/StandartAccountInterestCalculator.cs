using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module17._6._6.Interest
{
    internal class StandartAccountInterestCalculator : IInterestCalculator
    {
        public double CalcuatorInterest(double balance)
        {
            double interest = balance * 0.4;

            if (balance < 1000)
                interest -= balance * 0.2;

            if (balance >= 1000)
                interest -= balance * 0.3;

            return interest;
        }
    }
}
