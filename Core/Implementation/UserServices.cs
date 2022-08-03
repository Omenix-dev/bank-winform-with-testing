using Core.Interfaces;
using Model;


namespace Core.Implementation
{
    public class UserServices : IUserServices
    {
        public ValidTransactions Withdrawal(string Description, string AccountNumber,decimal Amount, decimal balance)
        {
            var Details = new ValidTransactions(Description, AccountNumber, Amount, -1, balance - Amount);
            return Details;
        }// end of the withdrawal method

        public ValidTransactions Deposit(string Description, string AccountNumber,decimal Amount, decimal balance)
        {
            var Details = new ValidTransactions(Description, AccountNumber, Amount, 1, balance + Amount);
            return Details;
        }


    }
}
