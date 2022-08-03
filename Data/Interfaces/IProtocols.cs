using Enum;
using Model;

namespace Data.Interfaces
{
    public interface IProtocols
    {
        IBankRepository CustomerRepository { get; }
        ISESSIONS SESSIONS { get; set; }
        AccountDetails CheckAccountability(decimal Withdrawal, string AccountNumber);
        bool IsAuthenticated(string Email, string Password);
        AccountDetails IsAValidAccount(string AccountNumber);
        bool IsValid(decimal Deposit, AccountType AccountType);
    }
}