using System.Collections.Generic;
using System.Threading.Tasks;
using Model;
using Data.Repositories;

namespace Data.Interfaces
{
    public interface IWriteToFile
    {
        Task<bool> save(IProtocols protocols, AccountDetails value);
        Task<bool> SaveCustomer(BankRepository Bank, Customer value);
        Task fileLoader(BankRepository Bank);
    }
}
