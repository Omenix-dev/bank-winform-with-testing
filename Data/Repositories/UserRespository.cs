using Core.Interfaces;
using Data.Interfaces;
using Newtonsoft.Json;
using System.IO;
using System.Threading.Tasks;
using Model;
using System.Collections.Generic;
using System.Linq;
namespace Data.Repositories
{
    public class UserRespository : IUserRespository
    {
        private IUserServices UserServices;
        private IProtocols Protocols;
        IBankRepository BankRepository;
        public UserRespository(IUserServices Users,IProtocols protocols,IBankRepository bank)
        {
            Protocols = protocols;
            UserServices = Users;
            BankRepository = bank;
        }
        public async Task<bool> RetrieveWithdrawal(string Description, decimal Deposit, string AccountNumber)
        {
            var CanWithdraw = Protocols.CheckAccountability(Deposit, AccountNumber);
            if (CanWithdraw != null)
            {
                // created the record once the value is the withdrawal is authorised
                var CreateRecord = UserServices.Withdrawal(Description, AccountNumber,Deposit, CanWithdraw.Balance);
                CanWithdraw.Balance = CreateRecord.balance; 
                CanWithdraw.ValidTransactions.Add(CreateRecord);
                await SaveCustomer();
                await fileLoader();
                return true;// withdrawal is successful
            }
            return false;// if the person has in sufficient balance

        }

        public async Task<bool> RetrieveDeposit(string Description, decimal Deposit, string AccountNumber)
        {
            // this is used to check whether the Account has been created
            var IsExiting = Protocols.IsAValidAccount(AccountNumber);
            if (IsExiting != null)
            {
                var CreateRecord = UserServices.Deposit(Description, AccountNumber, Deposit, IsExiting.Balance);

                IsExiting.Balance = CreateRecord.balance;
                IsExiting.ValidTransactions.Add(CreateRecord);
                await SaveCustomer();
                await fileLoader();
                return true;
            }
            return false;
        }

        public async Task<bool> TransferRetrieval(string Description,string SenderAccountNO,string RecipientAccountNO,decimal Amount)
        {
            //when logging in first deduct from the sender
            var ISuccessfull =await RetrieveWithdrawal(Description, Amount, SenderAccountNO);
            if (ISuccessfull)
            {
                //then is the process that is used to transfer money
                var IsTranfered = await RetrieveDeposit( Description, Amount, RecipientAccountNO);
                if (IsTranfered)
                {
                    return IsTranfered;
                }
                else
                {
                    var ReFundSender = RetrieveDeposit( "Refunding money", Amount,SenderAccountNO);
                }
            }
            return false;// couldn't  
        }


        private async Task<bool> SaveCustomer()
        {
            try
            {
                string fileContent = JsonConvert.SerializeObject(BankRepository.Database);
                await Task.Run(()=>File.WriteAllText(BankRepository.FileLocation, fileContent));
                return true;
            }
            catch
            {
                return false;
            }
        }
        private async Task fileLoader()
        {
            var FileContent = File.Exists(BankRepository.FileLocation) ? await Task.Run(() => File.ReadAllText(BankRepository.FileLocation)) : "";
            BankRepository.Database = FileContent != "" ? JsonConvert.DeserializeObject<List<Customer>>(FileContent) : new();
            var value = from x in BankRepository.Database
                        where x.PersonalDetails.Email.Contains(Protocols.SESSIONS.SESSION.PersonalDetails.Email) &&
                        x.Password.Contains(Protocols.SESSIONS.SESSION.Password)
                        select x;
            // this is used to re update the session object
            foreach(var item in value) { Protocols.SESSIONS.SESSION = item; break; }
        }
    }
}
