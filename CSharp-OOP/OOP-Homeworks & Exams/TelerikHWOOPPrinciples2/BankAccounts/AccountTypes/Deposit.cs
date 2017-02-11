namespace BankAccounts.AccountTypes
{
    using System;
    using CustomerTypes;
    using Interfaces;

    public class Deposit : Bank, IDepositable, IWithdrawable
    {
        public Deposit(CustomerType customer, decimal balance, decimal interestRate)
            : base(customer, balance, interestRate)
        {
        }

        public void DepositMoney(decimal deposit)
        {
            base.Balance += deposit;
            Console.WriteLine("${0:F2} deposited to your deposit account! \nYour Current Account Balance Is: ${1:F2}", deposit, base.Balance);
        }

        public void WithdrawMoney(decimal withdraw)
        {
            base.Balance -= withdraw;
            Console.WriteLine("${0:F2} Withdrawn From Your Deposit Account! \nYour Current Deposit Account Balance Is: ${1:F2}", withdraw, base.Balance);
        }

        public override decimal CalculateInterest(int numberOfMonths)
        {
            decimal interestAmount = 0;
            if (base.Balance > 0 && base.Balance < 1000)  //When the balance if greater than 0 and less than $1000
            {
                interestAmount = 0m;
            }
            else                    //If balance is $1000 or more
            {
                interestAmount = (base.InterestRate / 100) * numberOfMonths;
            }
            return interestAmount;
        }
    }
}
