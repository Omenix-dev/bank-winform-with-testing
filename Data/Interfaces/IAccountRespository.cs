using System.Threading.Tasks;
using Model;

namespace Data.Interfaces
{
    public interface IAccountRespository
    {
         Task<bool> Retrieve(int type, decimal Deposit,string accountNumber);
    }
}