using System.Threading.Tasks;
using Model;
using Newtonsoft.Json;
using System.IO;
using Data.Interfaces;
using System.Collections.Generic;
using Data.Repositories;


namespace Data.Repositories
{
    public class WriteToFile : IWriteToFile
    {
        public async Task<bool> save(IProtocols protocols, AccountDetails value)
        {
            try
            {
                protocols.SESSIONS.SESSION.CustomerAccountDetails.Add(value);// add the list account details to the customer account details created

                // writes new content to file database once it has been created
                string fileContent = JsonConvert.SerializeObject(protocols.CustomerRepository.Database);
                await Task.Run(() => File.WriteAllText(protocols.CustomerRepository.FileLocation, fileContent));
                return true;
            }
            catch
            {
                return false;
            }
        }

        public async Task<bool> SaveCustomer(BankRepository Bank,Customer value)
        {
            try
            {
                Bank.Database.Add(value);
                string fileContent = JsonConvert.SerializeObject(Bank.Database);
                await Task.Run(() => File.WriteAllText(Bank.FileLocation, fileContent));
                return true;
            }
            catch
            {
                return false;
            }
        }
        public async Task fileLoader(BankRepository Bank)
        {
            string FileContent;
            FileContent = File.Exists(Bank.FileLocation) ? await Task.Run(() => File.ReadAllText(Bank.FileLocation)) : "";
            Bank.Database = FileContent != "" ? JsonConvert.DeserializeObject<List<Customer>>(FileContent) : new();
        }
    }
}
