using Data.Interfaces;
using Enum;
using Model;
using System;
using System.Linq;
using EasyEncryption;

namespace Data
{
    public class Protocols : IProtocols
    {
        public ISESSIONS SESSIONS { get; set; }
        public IBankRepository CustomerRepository { get; }
        public Protocols(ISESSIONS SESSION, IBankRepository CustomerRepository)
        {
            this.CustomerRepository = CustomerRepository;
            this.SESSIONS = SESSION;
        }
        public bool IsValid(decimal Deposit, AccountType AccountType)
        {
            if (SESSIONS.IsLogged)
            {
                var Account = (int)AccountType == 1 ? Policy.CurLeast : Policy.SavLeast;
                if (Deposit >= Convert.ToDecimal((int)Account))
                {
                    return true;
                }
            }
            return false;
        }
        public bool IsAuthenticated(string Email, string Password)
        {
            foreach (var item in CustomerRepository.Database)
            {
                if (item.Password == SHA.ComputeSHA256Hash(Password) &&
                    item.PersonalDetails.Email.ToLower() == Email.ToLower())
                {
                    SESSIONS.SESSION = item;
                    SESSIONS.IsLogged = true;
                    return true;
                }
            }
            return false;
        }
        public AccountDetails IsAValidAccount(string AccountNumber)
        {
            foreach (var Customer in CustomerRepository.Database)
            {
                // where linq statement
                var value = from Number in Customer.CustomerAccountDetails
                            where Number.AccountNumber.Contains(AccountNumber)
                            select Number;
                if (value.Count() > 0)
                    foreach (var item in value) { return item; }
            }

            return null;
        }

        public AccountDetails CheckAccountability(decimal Withdrawal, string AccountNumber)
        {
            // system where linq
            var value = from Number in SESSIONS.SESSION.CustomerAccountDetails
                        where Number.AccountNumber.Contains(AccountNumber)
                        select Number;
            AccountDetails container = null;
            // this is used to unpack the list into the container
            if(value !=null)
            foreach (var item in value) { container = item; }

            if (container != null)
            {
                if (container.Balance - Withdrawal > (container.AccountType == 0 ? (int)Policy.SavLeast : (int)Policy.CurLeast))
                    return container;
                return null;
            }
            return null;
        }

    }
}
