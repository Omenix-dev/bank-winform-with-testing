using Model;
namespace Core.Interfaces
{
    public interface IUserServices
    {
        ValidTransactions Deposit(string Description, string AccountNumber,
                                      decimal Amount, decimal balance);
        ValidTransactions Withdrawal(string Description, string AccountNumber,
                                         decimal Amount, decimal balance);
    }
}