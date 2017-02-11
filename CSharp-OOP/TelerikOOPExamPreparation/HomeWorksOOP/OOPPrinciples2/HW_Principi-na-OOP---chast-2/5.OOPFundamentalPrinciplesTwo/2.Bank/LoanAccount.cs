using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Bank
{
    class LoanAccount : Account, IDeposit
    {
        //Constructor
        public LoanAccount(Customer customer, decimal balance, decimal interestRate)
            : base(customer, balance, interestRate)
        { }


        //Methods
        public void AddDeposit(decimal deposit)
        {
            if (deposit < 0)
            {
                throw new ArgumentOutOfRangeException("The deposit must be a positive number!");
            }
            else
            {
                this.Balance += deposit;
            }
        }

        public override decimal InterestAmountForPeriod(uint mounts)
        {
            if (this.Customer.GetType().ToString() == "Individual")
            {
                if (mounts <= 3)
                {
                    return 0;
                }
                else
                {
                    return (this.Balance * this.InterestRate) * (mounts - 3);
                }
            }
            else
            {
                if (mounts <= 2)
                {
                    return 0;
                }
                else
                {
                    return (this.Balance * this.InterestRate) * (mounts - 2);
                }
            }
        }
    }
}
