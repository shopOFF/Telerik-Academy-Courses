namespace BankAccounts
{
    using System;
    using AccountTypes;

    public class BankAccountsStartUp
    {
        public static void Main()
        {
            // Individual Deposit test
            var individualDepositAccount = new Deposit(CustomerTypes.CustomerType.Individual, 2685, 6.6m);

            Console.WriteLine("Type of Customer: {0}", individualDepositAccount.CustomerType);
            Console.WriteLine("Balance of {0} Account: ${1:F2}", individualDepositAccount.GetType().Name, individualDepositAccount.Balance);
            Console.WriteLine("Interest Amount ({0} Months): ${1:F2}", individualDepositAccount.InterestRate, individualDepositAccount.CalculateInterest(16));

            individualDepositAccount.WithdrawMoney(2250);
            Console.WriteLine();

            // Company Loan test
            var companyLoanAccount = new Loan(CustomerTypes.CustomerType.Company, 233333, 3m);

            Console.WriteLine("Type of Customer: {0}", companyLoanAccount.CustomerType);
            Console.WriteLine("Balance of {0} Account: ${1:F2}", companyLoanAccount.GetType().Name, companyLoanAccount.Balance);
            Console.WriteLine("Interest Amount ({0} Months): ${1:F2}", companyLoanAccount.InterestRate, companyLoanAccount.CalculateInterest(3));

            companyLoanAccount.DepositMoney(6666666);
            Console.WriteLine();

            // Company Mortgage test
            var companyMortgageAccount = new Mortgage(CustomerTypes.CustomerType.Company, 123456, 9m);
            Console.WriteLine("Type of Customer: {0}", companyMortgageAccount.CustomerType);
            Console.WriteLine("Balance of {0} Account: ${1:F2}", companyMortgageAccount.GetType().Name, companyMortgageAccount.Balance);
            Console.WriteLine("Interest Amount ({0} Months): ${1:F2}", companyMortgageAccount.InterestRate, companyMortgageAccount.CalculateInterest(3));

            companyMortgageAccount.DepositMoney(1234549);
            Console.WriteLine();
        }
    }
}
