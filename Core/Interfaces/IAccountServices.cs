using Model;
using Enum;

namespace Core.Interfaces
{
    public interface IAccountServices
    {
        AccountDetails CreateAccount(AccountType AccountType, decimal Deposit, string AccountNumber);
        Customer RegisterCustomer(string fullname,string Password, string sex, string email);
    }
}