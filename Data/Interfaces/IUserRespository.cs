using System.Threading.Tasks;

namespace Data.Interfaces
{
    public interface IUserRespository
    {
        Task<bool> RetrieveDeposit(string Description, decimal Deposit, string AccountNumber);
        Task<bool> RetrieveWithdrawal(string Description, decimal Deposit, string AccountNumber);
        Task<bool> TransferRetrieval(string Description, string SenderAccountNO, string RecipientAccountNO, decimal Amount);
    }
}