using System.Collections.Generic;
using Enum;

namespace Model
{
    public class AccountDetails
    {
        private AccountType _AccountType;
        public AccountType AccountType
        {
            get { return _AccountType; }
            set { _AccountType = value; }
        }

        public decimal Balance{ get; set; }

        private List<ValidTransactions> _ValidTransactions;
        public List<ValidTransactions> ValidTransactions
        {
            get { return _ValidTransactions; }
            set { _ValidTransactions = value; }
        }

        private string _AccountNumber;
        public string AccountNumber
        {
            get { return _AccountNumber; }
            set
            {
                _AccountNumber = value;
            }
        }

        public AccountDetails(AccountType AccountType, decimal Balance,string AccountNumber)
        {
            this.AccountType = AccountType;
            this.AccountNumber = AccountNumber;
            this.Balance = Balance;
            this.ValidTransactions = new List<ValidTransactions>();
        }
    }
}

