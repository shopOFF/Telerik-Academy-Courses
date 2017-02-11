namespace BankAccounts.AccountTypes
{
    using System;
    using CustomerTypes;
    using Interfaces;

    public class Loan : Bank, IDepositable
    {
        public Loan(CustomerType customer, decimal balance, decimal interestRate)
            : base(customer, balance, interestRate)
        {
        }

        public void DepositMoney(decimal deposit)
        {
            base.Balance += deposit;
            Console.WriteLine("${0:F2} Deposited To Your Loant Account! \nYour Current Loan Account Balance Is: {1:F2}", deposit, base.Balance);
        }

        public override decimal CalculateInterest(int numberOfMonths)
        {
            decimal interestAmount = 0;
            if (base.CustomerType == CustomerType.Individual && numberOfMonths > 3) //Number of months should be greater than 3
            {
                interestAmount = (numberOfMonths - 3) * (base.InterestRate / 100);
            }
            else if (base.CustomerType == CustomerType.Company && numberOfMonths > 2)     //Number of months should be greater than 2
            {
                interestAmount = (numberOfMonths - 2) * (base.InterestRate / 100);
            }
            return interestAmount;
        }
    }
}
