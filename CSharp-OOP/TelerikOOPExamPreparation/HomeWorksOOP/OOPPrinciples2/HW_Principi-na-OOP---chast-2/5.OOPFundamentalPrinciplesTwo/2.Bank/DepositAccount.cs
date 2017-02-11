using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Bank
{
    public class DepositAccount : Account, IDeposit, IDraw
    {
        //Constructor
        public DepositAccount(Customer customer, decimal balance, decimal interestRate)
            : base(customer, balance, interestRate)
        { }

        //Methods
        public void AddDeposit(decimal deposit)
        {
            if (deposit < 0)
            {
                throw new ArgumentOutOfRangeException("The money must be positive number!");
            }
            else
            {
                this.Balance += deposit;
            }
        }
        public void Draw(decimal drawMoney)
        {
            if (drawMoney < 0)
            {
                throw new ArgumentOutOfRangeException("The deposit must be a positive number!");
            }
            else
            {
                this.Balance -= drawMoney;
            }
        }
        public override decimal InterestAmountForPeriod(uint mounts)
        {
            if (this.Balance <= 1000 && this.Balance >= 0)
            {
                return 0;
            }
            else
            {
                return (this.Balance * this.InterestRate) * mounts;
            }
        }
    }
}