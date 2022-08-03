using Data.Interfaces;
using Model;
using Utility;

namespace Data.Repositories
{
    
    public class GetBankingRecord : IGetBankingRecord
    {
        ISESSIONS SESSIONS;
        IProtocols Protocol;
        public GetBankingRecord(ISESSIONS SESSIONS,IProtocols protocols)
        {
            this.Protocol = protocols;
            this.SESSIONS = SESSIONS;
        }
        
        public void PrintStatement(string AccountNumber)
        {
            if (SESSIONS.IsLogged)
            {
                var AccountIsValid = Protocol.IsAValidAccount(AccountNumber);

                if (AccountIsValid != null)
                {
                    //PrintCustomerInfo.TransactionDetails(AccountIsValid.ValidTransactions);
                }
            }
        }
    }
}
