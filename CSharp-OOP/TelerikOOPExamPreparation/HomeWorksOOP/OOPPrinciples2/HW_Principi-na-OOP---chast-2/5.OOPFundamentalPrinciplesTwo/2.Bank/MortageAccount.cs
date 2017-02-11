using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Bank
{
    class MortageAccount : Account, IDeposit
    {
        //Constructor
        public MortageAccount(Customer customer, decimal balance, decimal interestRate)
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
                if (mounts <= 6)
                {
                    return 0;
                }
                else
                {
                    return (this.Balance * this.InterestRate) * (mounts - 6);
                }
            }
            else
            {
                if (mounts <= 12)
                {
                    return (this.Balance * (this.InterestRate / 2)) * (mounts);
                }
                else
                {
                    return (this.Balance * (this.InterestRate / 2)) * (mounts) + (this.Balance * this.InterestRate) * (mounts - 12);
                }
            }
        }
    }
}
