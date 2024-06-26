using Module17._6._6.Interest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module17._6._6
{
    internal class Account
    {
        public string Type { get; set; }
        public double Balance { get; set; }
        public double Interest { get; set; }

        private IInterestCalculator _interestCalculator;

        public void CalculateInterest()
        {
            if (Type == "Обычный")
                _interestCalculator = new StandartAccountInterestCalculator();
            else if (Type == "Зарплатный")
                _interestCalculator = new SalaryAccountInterestCalculator();
            else
                throw new ArgumentException($"Неизвестный тип учетной записи: {Type}");

            Interest = _interestCalculator.CalcuatorInterest(Balance);
            Balance += Interest;
        }
    }
}
