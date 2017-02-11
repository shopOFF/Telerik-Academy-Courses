namespace BankAccounts.AccountTypes
{
    using System;
    using CustomerTypes;
    using Interfaces;

    public class Mortgage : Bank, IDepositable
    {
        public Mortgage(CustomerType customer, decimal balance, decimal interestRate) :
            base(customer, balance, interestRate)
        {
        }

        public void DepositMoney(decimal deposit)
        {
            base.Balance += deposit;
            Console.WriteLine("${0:F2} Deposited To Your Mortgage Account! \nYour Current Mortgage Account Balance Is: ${1:F2}", deposit, base.Balance);
        }

        public override decimal CalculateInterest(int numberOfMonths)
        {
            decimal interestAmount = 0;
            if (base.CustomerType == CustomerType.Individual && numberOfMonths > 6) //Number of months should be greater than 6
            {
                //No interest for the first 6 months
                interestAmount = (numberOfMonths - 6) * (base.InterestRate / 100);
            }
            else if (base.CustomerType == CustomerType.Company && numberOfMonths > 12)     //Number of months should be greater than 12
            {
                //No interest for the first 12 months
                interestAmount = ((base.InterestRate / 100 * 12) / 2) + ((numberOfMonths - 12) * (base.InterestRate / 100));
            }
            return interestAmount;
        }
    }
}
