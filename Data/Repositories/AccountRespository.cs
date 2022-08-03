using Core.Interfaces;
using Data.Interfaces;
using Enum;
using Utility;
using Model;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.IO;
using System.Threading.Tasks;


namespace Data.Repositories
{
    public class AccountRespository : IAccountRespository
    {
        private IUserServices UserServices;
        private IAccountServices AccountServices;
        IProtocols Protocols;
        IWriteToFile Write;
        public string accountNumber;
        public AccountDetails IsCreated;
        public ValidTransactions CreateRecord;
        public AccountRespository(IProtocols Protocol, IUserServices Users,IAccountServices AccountServices,IWriteToFile Write)
        {
            this.Protocols = Protocol;
            this.UserServices = Users;
            this.Write = Write;
            this.AccountServices = AccountServices;
        }

        public async Task<bool> Retrieve(int type, decimal Deposit,string accountNumber)
        {
            if (Protocols.SESSIONS.IsLogged && Protocols.IsValid(Deposit, (AccountType)type))
            {
                //accountNumber = AccountGenerator.Generate();
                IsCreated = AccountServices.CreateAccount((AccountType)type, Deposit,accountNumber);

                //instantiated the customer account details below
                CreateRecord = UserServices.Deposit("Account was Created", accountNumber, Deposit, 0.0M);
                IsCreated.ValidTransactions.Add(CreateRecord);// update the list with transcation details
                return await Task.Run(()=>Write.save(Protocols, IsCreated));
                
            }
            return false;
        }

        
    }
}
