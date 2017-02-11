namespace BankAccounts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using CustomerTypes;
    public abstract class Bank
    {
        private CustomerType customerType;
        private decimal balance;
        private decimal interestRate;

        public Bank(CustomerType customer, decimal balance, decimal interestRate)
        {
            this.CustomerType = customer;
            this.Balance = balance;
            this.InterestRate = interestRate;
        }
        public CustomerType CustomerType
        {
            get { return this.customerType; }
            protected set { this.customerType = value; }
        }

        public decimal Balance
        {
            get { return this.balance; }
            protected set {
                if (value<0)
                {
                    throw new ArgumentException("Balance can not be a negative number!");
                }
               this.balance = value; }
        }

        public decimal InterestRate
        {
            get { return this.interestRate; }
            protected set {
                if (value<0)
                {
                    throw new ArgumentException("Interest rate can not be a negative number!");
                }
                this.interestRate = value; }
        }

        public virtual decimal CalculateInterest(int numberOfMonths)
        {
            return (decimal)InterestRate * numberOfMonths;
        }
        
        

    }
}
