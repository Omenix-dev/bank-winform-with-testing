using Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Data.Interfaces
{
    public interface IBankRepository
    {
        string FileLocation { get; set; }
        List<Customer> Database{ get; set; }
        (string, string) _Temp { get; set; }
        Task<bool> CreateCustomer(string fullname,string Password, string Sex, string email);
    }
}