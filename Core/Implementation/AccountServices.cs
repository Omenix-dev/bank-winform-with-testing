using Core.Interfaces;
using Model;
using Enum;


namespace Core.Implementation
{
    public class AccountServices : IAccountServices
    {
        public AccountDetails CreateAccount(AccountType AccountType, decimal Deposit, string AccountNumber)
        {
            var AccountCreated = new AccountDetails(AccountType, Deposit, AccountNumber);
            return AccountCreated;
        }

       
        public Customer RegisterCustomer(string fullname, string Password,string sex, string email)
        {
            // get the personal details for the customer
            var item = new Customer(fullname, Password,sex, email);
            return item;
        }

    }
}
