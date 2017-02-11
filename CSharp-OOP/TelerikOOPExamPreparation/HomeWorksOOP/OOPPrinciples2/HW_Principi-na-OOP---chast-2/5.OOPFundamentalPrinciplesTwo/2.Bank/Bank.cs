//  2.A bank holds different types of accounts for its customers: deposit accounts, loan accounts and mortgage accounts. 
//  Customers could be individuals or companies.
//      All accounts have customer, balance and interest rate (monthly based). 
//   Deposit accounts are allowed to deposit and with draw money. 
//  Loan and mortgage accounts can only deposit money.
//  All accounts can calculate their interest amount for a given period (in months). In the common case its is calculated 
//  as follows: number_of_months * interest_rate.
//  Loan accounts have no interest for the first 3 months if are held by individuals and for the first 2 months if are held by a company.
//  Deposit accounts have no interest if their balance is positive and less than 1000.
//  Mortgage accounts have ½ interest for the first 12 months for companies and no interest for the first 6 months for individuals.
//  Your task is to write a program to model the bank system by classes and interfaces. You should identify the classes, interfaces,
//  base classes and abstract actions and implement the calculation of the interest functionality through overridden methods.



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Bank
{
    class Bank
    {
        static void Main()
        {
            //Make two customers - one company and one individual
            Company bulsat = new Company("Bulsat");
            Individual angel = new Individual("Angel Petrov");

            //Make deposite account for individual and company and test it
            DepositAccount angelDepositAcount = new DepositAccount(angel, 555m, 0.05m);
            DepositAccount bulsatDepositAcount = new DepositAccount(bulsat, 500m, 0.05m);
            angelDepositAcount.Draw(111m);
            Console.WriteLine(angelDepositAcount.Balance);
            angelDepositAcount.AddDeposit(200);
            Console.WriteLine(angelDepositAcount.Balance);

            Console.WriteLine("The {0} of the {1}-{2} have interest amount for next six mounths: {3} "
                , angelDepositAcount.GetType().Name, angelDepositAcount.Customer.GetType().Name, angelDepositAcount.Customer.Name, angelDepositAcount.InterestAmountForPeriod(6));
            Console.WriteLine("The {0} of the {1}-{2} have interest amount for next six mounths: {3} "
                , bulsatDepositAcount.GetType().Name, bulsatDepositAcount.Customer.GetType().Name, bulsatDepositAcount.Customer.Name, bulsatDepositAcount.InterestAmountForPeriod(6));
            Console.WriteLine("---------------");


            //Make loan account for individual and company and test it
            LoanAccount angelLoanAccount = new LoanAccount(angel,333m, 0.03m);
            Console.WriteLine("The {0} of the {1}-{2} have interest amount for next six mounths: {3} "
                , angelLoanAccount.GetType().Name, angelLoanAccount.Customer.GetType().Name, angelLoanAccount.Customer.Name, angelLoanAccount.InterestAmountForPeriod(6));

            LoanAccount bulsatLoanAccount = new LoanAccount(bulsat, 666m, 0.06m);
            Console.WriteLine("The {0} of the {1}-{2} have interest amount for next twelve mounths: {3} "
                , bulsatLoanAccount.GetType().Name, bulsatLoanAccount.Customer.GetType().Name, bulsatLoanAccount.Customer.Name, bulsatLoanAccount.InterestAmountForPeriod(12));
            Console.WriteLine("---------------");


            //Make Mortage account for individual and company and test the account functionalities
            MortageAccount angelMortageAccount = new MortageAccount(angel, 500m, 0.05m);
            Console.WriteLine("The {0} of the {1}-{2} have interest amount for next three years: {3} "
                , angelMortageAccount.GetType().Name, angelMortageAccount.Customer.GetType().Name, angelMortageAccount.Customer.Name, angelMortageAccount.InterestAmountForPeriod(36));
            MortageAccount bulsatMortageAccount = new MortageAccount(bulsat, 1111m, 0.05m);
            Console.WriteLine("The {0} of the {1}-{2} have interest amount for next two years: {3} "
                , bulsatMortageAccount.GetType().Name, bulsatMortageAccount.Customer.GetType().Name, bulsatMortageAccount.Customer.Name, bulsatMortageAccount.InterestAmountForPeriod(24));

        }
    }

}
